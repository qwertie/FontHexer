using Loyc;
using Loyc.Syntax;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace HexFont
{
    public partial class FontHexer : Form
    {
        public FontHexer()
        {
            InitializeComponent();
        }

        const int MaxCharWidth = 32, MaxCharHeight = 40;

        private void btnPickFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                var font = fontDialog.Font;
                chkBold.Checked = font.Bold;
                nudFontSize.Value = (decimal)font.SizeInPoints;
                Generate();
            }
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            fontDialog.Font = new Font(fontDialog.Font, chkBold.Checked ? FontStyle.Bold : FontStyle.Regular);
            Generate();
        }
        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            var font = fontDialog.Font;
            fontDialog.Font = new Font(font.FontFamily, (float)nudFontSize.Value, font.Style, GraphicsUnit.Point);
            Generate();
        }
        private void ValueChanged(object sender, EventArgs e) => Generate();
        private void CheckedChanged(object sender, EventArgs e) => Generate();

        private void Generate()
        {
            var font = fontDialog.Font;
            lblFont.Text = font.Name + " " + font.Size + " " + font.Style;
            lblFont.Font = font;

            var shave = new Padding((int)shaveLeft.Value, (int)shaveTop.Value, (int)shaveRight.Value, (int)shaveBottom.Value);
            int minCh = (int)minCodePoint.Value;
            int maxCh = (int)maxCodePoint.Value;

            (var bitmap, var text, var maxSize) = ConvertFont
                (font, minCh, maxCh, shave, 
                chkAutoLimitShaving.Checked, chkHexOutput.Checked, 
                chkClearType.Checked, chkJsonOutput.Checked, 
                chk4bpp.Checked);

            txtOutput.Text = $"MaxWidth: {maxSize.Width}, MaxHeight: {maxSize.Height}\r\n" + text;

            // Produce double-size output
            var bitmap2 = new Bitmap(bitmap.Width * 2, pictureBox.Height);
            using (var g = Graphics.FromImage(bitmap2))
            {
                g.Clear(Color.Gray);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(bitmap, 0, 0, bitmap.Width * 2, bitmap.Height * 2);
            }
            pictureBox.Image = bitmap2;

            bitmap.Dispose();
        }

        private (Bitmap, string, SizeF) ConvertFont(Font font, int minCh, int maxCh, Padding shave, bool autoShave, bool hexStringOutput, bool clearType, bool json, bool fourBitsPerPixel)
        {
            var outputs = new List<(string Char, float Width, List<BigInteger> CharBitmap)>();
            SizeF maxSize = new SizeF();

            int bmpWidth = Min(Max(maxCh - minCh + 1, 0) * MaxCharWidth, 32000);
            var bitmap = new Bitmap(bmpWidth, MaxCharHeight);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.Black);

                int left = 0;
                for (int i = minCh; i <= maxCh; i++)
                {
                    // Measure and draw character (char)i
                    string c = new string((char)i, 1);

                    g.TextRenderingHint = clearType ? TextRenderingHint.ClearTypeGridFit
                                        : fourBitsPerPixel ? TextRenderingHint.AntiAliasGridFit 
                                        : TextRenderingHint.SingleBitPerPixelGridFit;

                    var size = g.MeasureString(c, font);
                    int fullWidth = (int)Round(size.Width);
                    maxSize = new SizeF(Max(size.Width, maxSize.Width), Max(size.Height, maxSize.Height));
                    g.DrawString(c, font, Brushes.White, left, 0);

                    // Shave off left and right based on actual pixels
                    if (autoShave)
                    {
                        int shaveLeft, shaveRight;
                        for (shaveLeft = 0; shaveLeft < shave.Left; shaveLeft++)
                            if (!ColumnIsEmpty(left + shaveLeft))
                                break;
                        for (shaveRight = 0; shaveRight < shave.Right; shaveRight++)
                            if (!ColumnIsEmpty(left + fullWidth - 1 - shaveRight))
                                break;
                        shave.Left = shaveLeft;
                        shave.Right = shaveRight;

                        bool ColumnIsEmpty(int x)
                        {
                            if (x < 0)
                                return false;
                            for (int y = 0; y < size.Height; y++)
                            {
                                Color px = bitmap.GetPixel(x, y);
                                if (((px.R + px.G * 2 + px.B) >> 9) != 0)
                                    return false;
                            }
                            return true;
                        }
                    }

                    // Convert to a list of scanlines in 4-bit grayscale
                    var charBitmap = new List<BigInteger>();
                    for (int y = 0; y < Round(size.Height); y++)
                    {
                        BigInteger row = 0;
                        for (int x = shave.Left; x < fullWidth - shave.Right; x++)
                        {
                            Color px = bitmap.GetPixel(left + x, y);
                            int fourBitGray = (px.R + px.G * 2 + px.B) >> 6;
                            if (fourBitsPerPixel)
                                row = (row << 4) + fourBitGray;
                            else
                                row = (row << 1) + (fourBitGray >> 3);
                        }
                        charBitmap.Add(row);
                    }

                    bitmap.SetPixel(left, (int)size.Height, Color.Red);

                    outputs.Add((c, Max(size.Width - (shave.Left + shave.Right), 1), charBitmap));

                    // Advance render position
                    left += Max(fullWidth - shave.Right, 0);
                }
            }

            // Shave top & bottom
            long mask = fourBitsPerPixel ? 0x888888888888888 : 0xFFFFFFFFFFFFFFF;
            for (int y = 0; y < shave.Top; y++)
            {
                if (autoShave && outputs.Any(item => (item.CharBitmap[0] & mask) != 0))
                    break;
                foreach (var item in outputs.Where(it => it.CharBitmap.Count > 0))
                    item.CharBitmap.RemoveAt(0);
            }
            for (int y = 0; y < shave.Bottom; y++)
            {
                if (autoShave && outputs.Any(item => (item.CharBitmap[item.CharBitmap.Count - 1] & mask) != 0))
                    break;
                foreach (var item in outputs.Where(it => it.CharBitmap.Count > 0))
                    item.CharBitmap.RemoveAt(item.CharBitmap.Count - 1);
            }

            var lines = new List<string>();
            if (!json)
            {
                foreach (var (ch, width, charBitmap) in outputs)
                {
                    int intWidth = (int)Round(width);
                    string nums = NumberList(intWidth, charBitmap);
                    lines.Add($"{((int)ch[0]).ToString().PadRight(3,' ')},{intWidth.ToString().PadRight(3, ' ')},{nums}, {ch}");
                }
            }
            else
            {
                lines.Add("[");
                foreach (var (ch, width, charBitmap) in outputs)
                {
                    string c = "\"" + PrintHelpers.EscapeCStyle(ch) + "\"";
                    if (lines.Any())
                        lines[lines.Count - 1] += ",";
                    lines.Add(@"{");
                    int intWidth = (int)Round(width);
                    lines.Add($@"  ""char"": {c}, ""floatWidth"": {width}, ""width"": {intWidth}, ""bits"":");
                    if (hexStringOutput)
                        lines.Add($@"    ""{NumberList(intWidth, charBitmap)}""");
                    else
                        lines.Add($"    [ {NumberList(intWidth, charBitmap)} ]");
                    lines.Add(@"}");
                }
                lines.Add("]");
            }
            return (bitmap, string.Join("\r\n", lines), maxSize);

            string NumberList(int intWidth, List<BigInteger> charBitmap)
            {
                if (hexStringOutput) {
                    int rowLength = fourBitsPerPixel ? intWidth : (intWidth + 3) >> 2;
                    return string.Join(",", charBitmap.Select(row => row.ToString("X" + rowLength).Right(rowLength)));
                } else
                    return string.Join(",", charBitmap);
            }
        }
    }
}
