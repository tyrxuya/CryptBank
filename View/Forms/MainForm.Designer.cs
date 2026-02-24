namespace View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnPerf = new Button();
            btnStrength = new Button();
            btnRegister = new Button();
            btnLogin = new Button();
            panelTop = new Panel();
            panelContent = new Panel();
            panelSidebar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(230, 223, 255);
            panelSidebar.Controls.Add(tableLayoutPanel1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 681);
            panelSidebar.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnPerf, 0, 4);
            tableLayoutPanel1.Controls.Add(btnStrength, 0, 3);
            tableLayoutPanel1.Controls.Add(btnRegister, 0, 1);
            tableLayoutPanel1.Controls.Add(btnLogin, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(220, 681);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // btnPerf
            // 
            btnPerf.Anchor = AnchorStyles.None;
            btnPerf.Location = new Point(10, 418);
            btnPerf.Margin = new Padding(10);
            btnPerf.Name = "btnPerf";
            btnPerf.Size = new Size(200, 48);
            btnPerf.TabIndex = 2;
            btnPerf.Text = "PBKDF2 Test";
            btnPerf.UseVisualStyleBackColor = true;
            btnPerf.Click += btnPerf_Click;
            // 
            // btnStrength
            // 
            btnStrength.Anchor = AnchorStyles.None;
            btnStrength.Location = new Point(10, 350);
            btnStrength.Margin = new Padding(10);
            btnStrength.Name = "btnStrength";
            btnStrength.Size = new Size(200, 48);
            btnStrength.TabIndex = 3;
            btnStrength.Text = "Password strength";
            btnStrength.UseVisualStyleBackColor = true;
            btnStrength.Click += btnStrength_Click;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.Location = new Point(10, 214);
            btnRegister.Margin = new Padding(10);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 48);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.Location = new Point(10, 282);
            btnLogin.Margin = new Padding(10);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 48);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(221, 211, 255);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(220, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(844, 60);
            panelTop.TabIndex = 1;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(246, 243, 255);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(220, 60);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(844, 621);
            panelContent.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Controls.Add(panelSidebar);
            Name = "MainForm";
            Text = "PBKDF2";
            panelSidebar.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelTop;
        private Panel panelContent;
        private Button btnStrength;
        private Button btnPerf;
        private Button btnLogin;
        private Button btnRegister;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
