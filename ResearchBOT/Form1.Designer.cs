namespace ResearchBOT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startResearchBtn = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.browseLabel = new System.Windows.Forms.Label();
            this.selectedFile = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.resultText = new System.Windows.Forms.RichTextBox();
            this.appTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.helpBtn = new System.Windows.Forms.Button();
            this.startRange = new System.Windows.Forms.NumericUpDown();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.endRange = new System.Windows.Forms.NumericUpDown();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.resetRangeBtn = new System.Windows.Forms.Button();
            this.textResultchkBx = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.aboutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endRange)).BeginInit();
            this.SuspendLayout();
            // 
            // startResearchBtn
            // 
            this.startResearchBtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.startResearchBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startResearchBtn.Location = new System.Drawing.Point(12, 411);
            this.startResearchBtn.Name = "startResearchBtn";
            this.startResearchBtn.Size = new System.Drawing.Size(232, 40);
            this.startResearchBtn.TabIndex = 0;
            this.startResearchBtn.Text = "START RESEARCH";
            this.startResearchBtn.UseVisualStyleBackColor = false;
            this.startResearchBtn.Click += new System.EventHandler(this.startResearchBtn_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.BackColor = System.Drawing.Color.Sienna;
            this.browseBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.browseBtn.Location = new System.Drawing.Point(54, 138);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(164, 35);
            this.browseBtn.TabIndex = 1;
            this.browseBtn.Text = "BROWSE";
            this.browseBtn.UseVisualStyleBackColor = false;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // browseLabel
            // 
            this.browseLabel.AutoSize = true;
            this.browseLabel.BackColor = System.Drawing.Color.Transparent;
            this.browseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.browseLabel.Location = new System.Drawing.Point(46, 106);
            this.browseLabel.Name = "browseLabel";
            this.browseLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.browseLabel.Size = new System.Drawing.Size(178, 13);
            this.browseLabel.TabIndex = 2;
            this.browseLabel.Text = "SELECT THE FILE TO RESEARCH";
            this.browseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedFile
            // 
            this.selectedFile.AutoSize = true;
            this.selectedFile.BackColor = System.Drawing.Color.Transparent;
            this.selectedFile.ForeColor = System.Drawing.Color.Sienna;
            this.selectedFile.Location = new System.Drawing.Point(80, 187);
            this.selectedFile.MaximumSize = new System.Drawing.Size(110, 50);
            this.selectedFile.Name = "selectedFile";
            this.selectedFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectedFile.Size = new System.Drawing.Size(107, 13);
            this.selectedFile.TabIndex = 0;
            this.selectedFile.Text = "NO FILE SELECTED";
            this.selectedFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // resultText
            // 
            this.resultText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultText.BackColor = System.Drawing.Color.DarkSlateGray;
            this.resultText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultText.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultText.ForeColor = System.Drawing.SystemColors.Info;
            this.resultText.Location = new System.Drawing.Point(262, 0);
            this.resultText.Margin = new System.Windows.Forms.Padding(0);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(571, 567);
            this.resultText.TabIndex = 4;
            this.resultText.Text = "";
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.BackColor = System.Drawing.Color.Transparent;
            this.appTitle.Font = new System.Drawing.Font("MS Outlook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.Location = new System.Drawing.Point(42, 29);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(176, 24);
            this.appTitle.TabIndex = 5;
            this.appTitle.Text = "RESEARCH BOT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "V 1.0";
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.helpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.helpBtn.Location = new System.Drawing.Point(167, 470);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(0);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(74, 32);
            this.helpBtn.TabIndex = 7;
            this.helpBtn.Text = "HELP";
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // startRange
            // 
            this.startRange.BackColor = System.Drawing.Color.Silver;
            this.startRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startRange.Location = new System.Drawing.Point(27, 293);
            this.startRange.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.startRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startRange.Name = "startRange";
            this.startRange.Size = new System.Drawing.Size(92, 20);
            this.startRange.TabIndex = 8;
            this.startRange.Tag = "";
            this.startRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startLabel.Location = new System.Drawing.Point(27, 267);
            this.startLabel.Name = "startLabel";
            this.startLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startLabel.Size = new System.Drawing.Size(77, 13);
            this.startLabel.TabIndex = 9;
            this.startLabel.Text = "START FROM";
            this.startLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.BackColor = System.Drawing.Color.Transparent;
            this.endLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.endLabel.Location = new System.Drawing.Point(143, 267);
            this.endLabel.Name = "endLabel";
            this.endLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.endLabel.Size = new System.Drawing.Size(47, 13);
            this.endLabel.TabIndex = 10;
            this.endLabel.Text = "END AT";
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endRange
            // 
            this.endRange.BackColor = System.Drawing.Color.Silver;
            this.endRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.endRange.Location = new System.Drawing.Point(143, 293);
            this.endRange.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.endRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endRange.Name = "endRange";
            this.endRange.Size = new System.Drawing.Size(88, 20);
            this.endRange.TabIndex = 11;
            this.endRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.BackColor = System.Drawing.Color.Transparent;
            this.rangeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rangeLabel.Location = new System.Drawing.Point(30, 239);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rangeLabel.Size = new System.Drawing.Size(194, 13);
            this.rangeLabel.TabIndex = 12;
            this.rangeLabel.Text = "SELECT THE RANGE TO RESEARCH";
            this.rangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetRangeBtn
            // 
            this.resetRangeBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.resetRangeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resetRangeBtn.Location = new System.Drawing.Point(74, 330);
            this.resetRangeBtn.Name = "resetRangeBtn";
            this.resetRangeBtn.Size = new System.Drawing.Size(104, 30);
            this.resetRangeBtn.TabIndex = 13;
            this.resetRangeBtn.Text = "RESET RANGE";
            this.resetRangeBtn.UseVisualStyleBackColor = false;
            this.resetRangeBtn.Click += new System.EventHandler(this.resetRangeBtn_Click);
            // 
            // textResultchkBx
            // 
            this.textResultchkBx.AutoSize = true;
            this.textResultchkBx.Location = new System.Drawing.Point(30, 375);
            this.textResultchkBx.Name = "textResultchkBx";
            this.textResultchkBx.Size = new System.Drawing.Size(139, 17);
            this.textResultchkBx.TabIndex = 15;
            this.textResultchkBx.Text = "RESULT IN TEXT FILE";
            this.textResultchkBx.UseVisualStyleBackColor = true;
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.Color.Sienna;
            this.aboutBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aboutBtn.Location = new System.Drawing.Point(9, 470);
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(0);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(146, 35);
            this.aboutBtn.TabIndex = 14;
            this.aboutBtn.Text = "ABOUT";
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 562);
            this.Controls.Add(this.textResultchkBx);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.resetRangeBtn);
            this.Controls.Add(this.rangeLabel);
            this.Controls.Add(this.endRange);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.startRange);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appTitle);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.selectedFile);
            this.Controls.Add(this.browseLabel);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.startResearchBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "RESEARCH BOT V 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.startRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startResearchBtn;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label browseLabel;
        private System.Windows.Forms.Label selectedFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox resultText;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.NumericUpDown startRange;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.NumericUpDown endRange;
        private System.Windows.Forms.Label rangeLabel;
        private System.Windows.Forms.Button resetRangeBtn;
        private System.Windows.Forms.CheckBox textResultchkBx;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button aboutBtn;
    }
}


