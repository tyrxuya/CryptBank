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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            progressBar1 = new ProgressBar();
            lblScore = new Label();
            this.lblStrength = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tlpRoot.SuspendLayout();
            panelCard.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            panelCard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelCard.BackColor = Color.White;
            panelCard.Controls.Add(tableLayoutPanel1);
            panelCard.Location = new Point(300, 250);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(24);
            panelCard.Size = new Size(400, 300);
            panelCard.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label8, 0, 9);
            tableLayoutPanel1.Controls.Add(label7, 0, 8);
            tableLayoutPanel1.Controls.Add(label6, 0, 7);
            tableLayoutPanel1.Controls.Add(label5, 0, 6);
            tableLayoutPanel1.Controls.Add(label4, 0, 5);
            tableLayoutPanel1.Controls.Add(this.lblStrength, 0, 4);
            tableLayoutPanel1.Controls.Add(lblScore, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(progressBar1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(24, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(352, 198);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(346, 30);
            label1.TabIndex = 0;
            label1.Text = "Password Strength Checker";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(26, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 23);
            textBox1.TabIndex = 1;
            textBox1.UseSystemPasswordChar = true;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.None;
            progressBar1.Location = new Point(26, 62);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(300, 18);
            progressBar1.TabIndex = 2;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Dock = DockStyle.Fill;
            lblScore.Font = new Font("Segoe UI", 10F);
            lblScore.Location = new Point(3, 83);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(346, 19);
            lblScore.TabIndex = 3;
            lblScore.Text = "Score: 0 / 100";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Dock = DockStyle.Fill;
            this.lblStrength.Font = new Font("Segoe UI", 12F);
            this.lblStrength.ForeColor = Color.Red;
            this.lblStrength.Location = new Point(3, 102);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new Size(346, 21);
            this.lblStrength.TabIndex = 4;
            this.lblStrength.Text = "Weak";
            this.lblStrength.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(110, 106, 134);
            label4.Location = new Point(3, 123);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(110, 106, 134);
            label5.Location = new Point(3, 138);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(110, 106, 134);
            label6.Location = new Point(3, 153);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 7;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(110, 106, 134);
            label7.Location = new Point(3, 168);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 8;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(110, 106, 134);
            label8.Location = new Point(3, 183);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 9;
            label8.Text = "label8";
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpRoot;
        private Panel panelCard;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblStrength;
        private Label lblScore;
        private Label label1;
        private TextBox textBox1;
        private ProgressBar progressBar1;
    }
}
