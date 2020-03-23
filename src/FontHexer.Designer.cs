namespace FontHexer
{
    partial class FontHexer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFont = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnPickFont = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shaveLeft = new System.Windows.Forms.NumericUpDown();
            this.chkHexOutput = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.chk4bpp = new System.Windows.Forms.RadioButton();
            this.shaveRight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.shaveTop = new System.Windows.Forms.NumericUpDown();
            this.shaveBottom = new System.Windows.Forms.NumericUpDown();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAutoLimitShaving = new System.Windows.Forms.CheckBox();
            this.chkClearType = new System.Windows.Forms.CheckBox();
            this.chkJsonOutput = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.minCodePoint = new System.Windows.Forms.NumericUpDown();
            this.maxCodePoint = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaveLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaveRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaveTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaveBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minCodePoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCodePoint)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFont
            // 
            this.lblFont.Location = new System.Drawing.Point(11, 62);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(139, 60);
            this.lblFont.TabIndex = 1;
            this.lblFont.Text = "Select a font.";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(12, 128);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(797, 310);
            this.txtOutput.TabIndex = 7;
            this.txtOutput.WordWrap = false;
            // 
            // btnPickFont
            // 
            this.btnPickFont.Location = new System.Drawing.Point(12, 10);
            this.btnPickFont.Name = "btnPickFont";
            this.btnPickFont.Size = new System.Drawing.Size(74, 23);
            this.btnPickFont.TabIndex = 0;
            this.btnPickFont.Text = "&Pick font";
            this.btnPickFont.UseVisualStyleBackColor = true;
            this.btnPickFont.Click += new System.EventHandler(this.btnPickFont_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(156, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(653, 60);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shave pixels from left/right";
            // 
            // shaveLeft
            // 
            this.shaveLeft.Location = new System.Drawing.Point(304, 76);
            this.shaveLeft.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.shaveLeft.Name = "shaveLeft";
            this.shaveLeft.Size = new System.Drawing.Size(39, 20);
            this.shaveLeft.TabIndex = 3;
            this.shaveLeft.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.shaveLeft.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // chkHexOutput
            // 
            this.chkHexOutput.AutoSize = true;
            this.chkHexOutput.Checked = true;
            this.chkHexOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHexOutput.Location = new System.Drawing.Point(394, 103);
            this.chkHexOutput.Name = "chkHexOutput";
            this.chkHexOutput.Size = new System.Drawing.Size(106, 17);
            this.chkHexOutput.TabIndex = 4;
            this.chkHexOutput.Text = "Hex string output";
            this.chkHexOutput.UseVisualStyleBackColor = true;
            this.chkHexOutput.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(598, 77);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "One bit per pixel";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // chk4bpp
            // 
            this.chk4bpp.AutoSize = true;
            this.chk4bpp.Checked = true;
            this.chk4bpp.Location = new System.Drawing.Point(598, 103);
            this.chk4bpp.Name = "chk4bpp";
            this.chk4bpp.Size = new System.Drawing.Size(107, 17);
            this.chk4bpp.TabIndex = 6;
            this.chk4bpp.TabStop = true;
            this.chk4bpp.Text = "Four bits per pixel";
            this.chk4bpp.UseVisualStyleBackColor = true;
            this.chk4bpp.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // shaveRight
            // 
            this.shaveRight.Location = new System.Drawing.Point(349, 76);
            this.shaveRight.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.shaveRight.Name = "shaveRight";
            this.shaveRight.Size = new System.Drawing.Size(39, 20);
            this.shaveRight.TabIndex = 3;
            this.shaveRight.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.shaveRight.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shave pixels from top/bottom";
            // 
            // shaveTop
            // 
            this.shaveTop.Location = new System.Drawing.Point(304, 102);
            this.shaveTop.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.shaveTop.Name = "shaveTop";
            this.shaveTop.Size = new System.Drawing.Size(39, 20);
            this.shaveTop.TabIndex = 3;
            this.shaveTop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shaveTop.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // shaveBottom
            // 
            this.shaveBottom.Location = new System.Drawing.Point(349, 102);
            this.shaveBottom.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.shaveBottom.Name = "shaveBottom";
            this.shaveBottom.Size = new System.Drawing.Size(39, 20);
            this.shaveBottom.TabIndex = 3;
            this.shaveBottom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shaveBottom.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(92, 14);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(47, 17);
            this.chkBold.TabIndex = 8;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // nudFontSize
            // 
            this.nudFontSize.DecimalPlaces = 1;
            this.nudFontSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudFontSize.Location = new System.Drawing.Point(92, 37);
            this.nudFontSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFontSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(58, 20);
            this.nudFontSize.TabIndex = 3;
            this.nudFontSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudFontSize.ValueChanged += new System.EventHandler(this.nudFontSize_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Font &Size:";
            // 
            // chkAutoLimitShaving
            // 
            this.chkAutoLimitShaving.AutoSize = true;
            this.chkAutoLimitShaving.Checked = true;
            this.chkAutoLimitShaving.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoLimitShaving.Location = new System.Drawing.Point(394, 77);
            this.chkAutoLimitShaving.Name = "chkAutoLimitShaving";
            this.chkAutoLimitShaving.Size = new System.Drawing.Size(108, 17);
            this.chkAutoLimitShaving.TabIndex = 4;
            this.chkAutoLimitShaving.Text = "Auto-limit shaving";
            this.chkAutoLimitShaving.UseVisualStyleBackColor = true;
            this.chkAutoLimitShaving.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // chkClearType
            // 
            this.chkClearType.AutoSize = true;
            this.chkClearType.Location = new System.Drawing.Point(508, 77);
            this.chkClearType.Name = "chkClearType";
            this.chkClearType.Size = new System.Drawing.Size(74, 17);
            this.chkClearType.TabIndex = 4;
            this.chkClearType.Text = "ClearType";
            this.chkClearType.UseVisualStyleBackColor = true;
            this.chkClearType.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // chkJsonOutput
            // 
            this.chkJsonOutput.AutoSize = true;
            this.chkJsonOutput.Location = new System.Drawing.Point(508, 103);
            this.chkJsonOutput.Name = "chkJsonOutput";
            this.chkJsonOutput.Size = new System.Drawing.Size(87, 17);
            this.chkJsonOutput.TabIndex = 4;
            this.chkJsonOutput.Text = "JSON output";
            this.chkJsonOutput.UseVisualStyleBackColor = true;
            this.chkJsonOutput.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Codepoint range:";
            // 
            // minCodePoint
            // 
            this.minCodePoint.Location = new System.Drawing.Point(711, 102);
            this.minCodePoint.Maximum = new decimal(new int[] {
            65534,
            0,
            0,
            0});
            this.minCodePoint.Name = "minCodePoint";
            this.minCodePoint.Size = new System.Drawing.Size(47, 20);
            this.minCodePoint.TabIndex = 11;
            this.minCodePoint.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.minCodePoint.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // maxCodePoint
            // 
            this.maxCodePoint.Location = new System.Drawing.Point(758, 102);
            this.maxCodePoint.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.maxCodePoint.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.maxCodePoint.Name = "maxCodePoint";
            this.maxCodePoint.Size = new System.Drawing.Size(51, 20);
            this.maxCodePoint.TabIndex = 11;
            this.maxCodePoint.Value = new decimal(new int[] {
            126,
            0,
            0,
            0});
            this.maxCodePoint.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // FontHexer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.maxCodePoint);
            this.Controls.Add(this.minCodePoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkBold);
            this.Controls.Add(this.chk4bpp);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.chkJsonOutput);
            this.Controls.Add(this.chkClearType);
            this.Controls.Add(this.chkAutoLimitShaving);
            this.Controls.Add(this.chkHexOutput);
            this.Controls.Add(this.shaveBottom);
            this.Controls.Add(this.shaveRight);
            this.Controls.Add(this.shaveTop);
            this.Controls.Add(this.nudFontSize);
            this.Controls.Add(this.shaveLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnPickFont);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblFont);
            this.Name = "FontHexer";
            this.Text = "FontHexer: Convert Font to Number Sequence";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaveLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaveRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaveTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaveBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minCodePoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCodePoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnPickFont;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown shaveLeft;
        private System.Windows.Forms.CheckBox chkHexOutput;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton chk4bpp;
        private System.Windows.Forms.NumericUpDown shaveRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown shaveTop;
        private System.Windows.Forms.NumericUpDown shaveBottom;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAutoLimitShaving;
        private System.Windows.Forms.CheckBox chkClearType;
        private System.Windows.Forms.CheckBox chkJsonOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown minCodePoint;
        private System.Windows.Forms.NumericUpDown maxCodePoint;
    }
}

