namespace View.Controls
{
    partial class StrengthView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpRoot = new TableLayoutPanel();
            panelCard = new Panel();
            tlpCard = new TableLayoutPanel();
            tlpChecks = new TableLayoutPanel();
            lblSpecial = new Label();
            lblDigits = new Label();
            lblUppercase = new Label();
            lblLowercase = new Label();
            lblTitle = new Label();
            txtPassword = new TextBox();
            progressStrength = new ProgressBar();
            tlpMetrics = new TableLayoutPanel();
            lblCrackTimeVal = new Label();
            lblCrackTime = new Label();
            lblGuesses = new Label();
            lblEntropyVal = new Label();
            lblEntropy = new Label();
            lblAlphabetSizeVal = new Label();
            lblAlphabetSize = new Label();
            lblLengthVal = new Label();
            lblLength = new Label();
            cmbG = new ComboBox();
            tlpRoot.SuspendLayout();
            panelCard.SuspendLayout();
            tlpCard.SuspendLayout();
            tlpChecks.SuspendLayout();
            tlpMetrics.SuspendLayout();
            SuspendLayout();
            // 
            // tlpRoot
            // 
            tlpRoot.ColumnCount = 3;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRoot.ColumnStyles.Add(new ColumnStyle());
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRoot.Controls.Add(panelCard, 1, 1);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Location = new Point(0, 0);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.RowCount = 3;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRoot.RowStyles.Add(new RowStyle());
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRoot.Size = new Size(1000, 800);
            tlpRoot.TabIndex = 0;
            // 
            // panelCard
            // 
            panelCard.Anchor = AnchorStyles.None;
            panelCard.BackColor = Color.White;
            panelCard.Controls.Add(tlpCard);
            panelCard.Location = new Point(240, 200);
            panelCard.MaximumSize = new Size(520, 400);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(24);
            panelCard.Size = new Size(520, 400);
            panelCard.TabIndex = 0;
            // 
            // tlpCard
            // 
            tlpCard.AutoSize = true;
            tlpCard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpCard.ColumnCount = 1;
            tlpCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCard.Controls.Add(tlpChecks, 0, 5);
            tlpCard.Controls.Add(lblTitle, 0, 0);
            tlpCard.Controls.Add(txtPassword, 0, 1);
            tlpCard.Controls.Add(progressStrength, 0, 2);
            tlpCard.Controls.Add(tlpMetrics, 0, 4);
            tlpCard.Dock = DockStyle.Top;
            tlpCard.Location = new Point(24, 24);
            tlpCard.Name = "tlpCard";
            tlpCard.RowCount = 6;
            tlpCard.RowStyles.Add(new RowStyle());
            tlpCard.RowStyles.Add(new RowStyle());
            tlpCard.RowStyles.Add(new RowStyle());
            tlpCard.RowStyles.Add(new RowStyle());
            tlpCard.RowStyles.Add(new RowStyle());
            tlpCard.RowStyles.Add(new RowStyle());
            tlpCard.Size = new Size(472, 323);
            tlpCard.TabIndex = 0;
            // 
            // tlpChecks
            // 
            tlpChecks.AutoSize = true;
            tlpChecks.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpChecks.ColumnCount = 1;
            tlpChecks.ColumnStyles.Add(new ColumnStyle());
            tlpChecks.Controls.Add(lblSpecial, 1, 3);
            tlpChecks.Controls.Add(lblDigits, 0, 3);
            tlpChecks.Controls.Add(lblUppercase, 1, 0);
            tlpChecks.Controls.Add(lblLowercase, 0, 0);
            tlpChecks.Dock = DockStyle.Top;
            tlpChecks.Location = new Point(3, 255);
            tlpChecks.Name = "tlpChecks";
            tlpChecks.RowCount = 3;
            tlpChecks.RowStyles.Add(new RowStyle());
            tlpChecks.RowStyles.Add(new RowStyle());
            tlpChecks.RowStyles.Add(new RowStyle());
            tlpChecks.RowStyles.Add(new RowStyle());
            tlpChecks.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpChecks.Size = new Size(466, 65);
            tlpChecks.TabIndex = 7;
            // 
            // lblSpecial
            // 
            lblSpecial.AutoSize = true;
            lblSpecial.ForeColor = Color.Red;
            lblSpecial.Location = new Point(3, 45);
            lblSpecial.Name = "lblSpecial";
            lblSpecial.Size = new Size(58, 15);
            lblSpecial.TabIndex = 8;
            lblSpecial.Text = "✖ special";
            // 
            // lblDigits
            // 
            lblDigits.AutoSize = true;
            lblDigits.ForeColor = Color.Red;
            lblDigits.Location = new Point(3, 30);
            lblDigits.Name = "lblDigits";
            lblDigits.Size = new Size(51, 15);
            lblDigits.TabIndex = 7;
            lblDigits.Text = "✖ digits";
            // 
            // lblUppercase
            // 
            lblUppercase.AutoSize = true;
            lblUppercase.ForeColor = Color.Red;
            lblUppercase.Location = new Point(3, 15);
            lblUppercase.Name = "lblUppercase";
            lblUppercase.Size = new Size(76, 15);
            lblUppercase.TabIndex = 2;
            lblUppercase.Text = "✖ uppercase";
            // 
            // lblLowercase
            // 
            lblLowercase.AutoSize = true;
            lblLowercase.ForeColor = Color.Red;
            lblLowercase.Location = new Point(3, 0);
            lblLowercase.Name = "lblLowercase";
            lblLowercase.Size = new Size(74, 15);
            lblLowercase.TabIndex = 1;
            lblLowercase.Text = "✖ lowercase";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(0, 0, 0, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(472, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Password Strength";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(86, 45);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // progressStrength
            // 
            progressStrength.Anchor = AnchorStyles.None;
            progressStrength.Location = new Point(86, 79);
            progressStrength.Margin = new Padding(0, 8, 0, 6);
            progressStrength.Name = "progressStrength";
            progressStrength.Size = new Size(300, 18);
            progressStrength.TabIndex = 2;
            // 
            // tlpMetrics
            // 
            tlpMetrics.AutoSize = true;
            tlpMetrics.ColumnCount = 2;
            tlpMetrics.ColumnStyles.Add(new ColumnStyle());
            tlpMetrics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMetrics.Controls.Add(lblCrackTimeVal, 1, 4);
            tlpMetrics.Controls.Add(lblCrackTime, 0, 4);
            tlpMetrics.Controls.Add(lblGuesses, 0, 3);
            tlpMetrics.Controls.Add(lblEntropyVal, 1, 2);
            tlpMetrics.Controls.Add(lblEntropy, 0, 2);
            tlpMetrics.Controls.Add(lblAlphabetSizeVal, 1, 1);
            tlpMetrics.Controls.Add(lblAlphabetSize, 0, 1);
            tlpMetrics.Controls.Add(lblLengthVal, 1, 0);
            tlpMetrics.Controls.Add(lblLength, 0, 0);
            tlpMetrics.Controls.Add(cmbG, 1, 3);
            tlpMetrics.Dock = DockStyle.Top;
            tlpMetrics.Location = new Point(3, 106);
            tlpMetrics.Name = "tlpMetrics";
            tlpMetrics.RowCount = 5;
            tlpMetrics.RowStyles.Add(new RowStyle());
            tlpMetrics.RowStyles.Add(new RowStyle());
            tlpMetrics.RowStyles.Add(new RowStyle());
            tlpMetrics.RowStyles.Add(new RowStyle());
            tlpMetrics.RowStyles.Add(new RowStyle());
            tlpMetrics.Size = new Size(466, 143);
            tlpMetrics.TabIndex = 6;
            // 
            // lblCrackTimeVal
            // 
            lblCrackTimeVal.Anchor = AnchorStyles.Left;
            lblCrackTimeVal.AutoSize = true;
            lblCrackTimeVal.Location = new Point(113, 122);
            lblCrackTimeVal.Margin = new Padding(0, 6, 0, 6);
            lblCrackTimeVal.Name = "lblCrackTimeVal";
            lblCrackTimeVal.Size = new Size(0, 15);
            lblCrackTimeVal.TabIndex = 9;
            // 
            // lblCrackTime
            // 
            lblCrackTime.Anchor = AnchorStyles.Right;
            lblCrackTime.AutoSize = true;
            lblCrackTime.Location = new Point(34, 122);
            lblCrackTime.Margin = new Padding(0, 6, 12, 6);
            lblCrackTime.Name = "lblCrackTime";
            lblCrackTime.Size = new Size(67, 15);
            lblCrackTime.TabIndex = 8;
            lblCrackTime.Text = "Crack time:";
            // 
            // lblGuesses
            // 
            lblGuesses.Anchor = AnchorStyles.Right;
            lblGuesses.AutoSize = true;
            lblGuesses.Location = new Point(8, 91);
            lblGuesses.Margin = new Padding(0, 6, 12, 6);
            lblGuesses.Name = "lblGuesses";
            lblGuesses.Size = new Size(93, 15);
            lblGuesses.TabIndex = 6;
            lblGuesses.Text = "Guesses/sec (G):";
            // 
            // lblEntropyVal
            // 
            lblEntropyVal.Anchor = AnchorStyles.Left;
            lblEntropyVal.AutoSize = true;
            lblEntropyVal.Location = new Point(113, 60);
            lblEntropyVal.Margin = new Padding(0, 6, 0, 6);
            lblEntropyVal.Name = "lblEntropyVal";
            lblEntropyVal.Size = new Size(0, 15);
            lblEntropyVal.TabIndex = 5;
            // 
            // lblEntropy
            // 
            lblEntropy.Anchor = AnchorStyles.Right;
            lblEntropy.AutoSize = true;
            lblEntropy.Location = new Point(30, 60);
            lblEntropy.Margin = new Padding(0, 6, 12, 6);
            lblEntropy.Name = "lblEntropy";
            lblEntropy.Size = new Size(71, 15);
            lblEntropy.TabIndex = 4;
            lblEntropy.Text = "Entropy (H):";
            // 
            // lblAlphabetSizeVal
            // 
            lblAlphabetSizeVal.Anchor = AnchorStyles.Left;
            lblAlphabetSizeVal.AutoSize = true;
            lblAlphabetSizeVal.Location = new Point(113, 33);
            lblAlphabetSizeVal.Margin = new Padding(0, 6, 0, 6);
            lblAlphabetSizeVal.Name = "lblAlphabetSizeVal";
            lblAlphabetSizeVal.Size = new Size(0, 15);
            lblAlphabetSizeVal.TabIndex = 3;
            // 
            // lblAlphabetSize
            // 
            lblAlphabetSize.Anchor = AnchorStyles.Right;
            lblAlphabetSize.AutoSize = true;
            lblAlphabetSize.Location = new Point(0, 33);
            lblAlphabetSize.Margin = new Padding(0, 6, 12, 6);
            lblAlphabetSize.Name = "lblAlphabetSize";
            lblAlphabetSize.Size = new Size(101, 15);
            lblAlphabetSize.TabIndex = 2;
            lblAlphabetSize.Text = "Alphabet Size (N):";
            // 
            // lblLengthVal
            // 
            lblLengthVal.Anchor = AnchorStyles.Left;
            lblLengthVal.AutoSize = true;
            lblLengthVal.Location = new Point(113, 6);
            lblLengthVal.Margin = new Padding(0, 6, 0, 6);
            lblLengthVal.Name = "lblLengthVal";
            lblLengthVal.Size = new Size(0, 15);
            lblLengthVal.TabIndex = 1;
            // 
            // lblLength
            // 
            lblLength.Anchor = AnchorStyles.Right;
            lblLength.AutoSize = true;
            lblLength.Location = new Point(37, 6);
            lblLength.Margin = new Padding(0, 6, 12, 6);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(64, 15);
            lblLength.TabIndex = 0;
            lblLength.Text = "Length (L):";
            // 
            // cmbG
            // 
            cmbG.Anchor = AnchorStyles.Left;
            cmbG.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbG.FormattingEnabled = true;
            cmbG.Items.AddRange(new object[] { "1", "1e3", "1e6", "1e9", "1e12" });
            cmbG.Location = new Point(113, 87);
            cmbG.Margin = new Padding(0, 6, 0, 6);
            cmbG.Name = "cmbG";
            cmbG.Size = new Size(121, 23);
            cmbG.TabIndex = 10;
            // 
            // StrengthView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 243, 255);
            Controls.Add(tlpRoot);
            Name = "StrengthView";
            Size = new Size(1000, 800);
            tlpRoot.ResumeLayout(false);
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            tlpCard.ResumeLayout(false);
            tlpCard.PerformLayout();
            tlpChecks.ResumeLayout(false);
            tlpChecks.PerformLayout();
            tlpMetrics.ResumeLayout(false);
            tlpMetrics.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpRoot;
        private Panel panelCard;
        private TableLayoutPanel tlpCard;
        private Label lblTitle;
        private TextBox txtPassword;
        private ProgressBar progressStrength;
        private TableLayoutPanel tlpChecks;
        private TableLayoutPanel tlpMetrics;
        private Label lblSpecial;
        private Label lblDigits;
        private Label lblUppercase;
        private Label lblLowercase;
        private Label lblCrackTimeVal;
        private Label lblCrackTime;
        private Label lblGuesses;
        private Label lblEntropyVal;
        private Label lblEntropy;
        private Label lblAlphabetSizeVal;
        private Label lblAlphabetSize;
        private Label lblLengthVal;
        private Label lblLength;
        private ComboBox cmbG;
    }
}
