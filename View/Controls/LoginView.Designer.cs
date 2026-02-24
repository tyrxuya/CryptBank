namespace View.Controls
{
    partial class LoginView
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
            tlpCard = new TableLayoutPanel();
            tlpForm = new TableLayoutPanel();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblLogin = new Label();
            btnLogin = new Button();
            tlpRoot = new TableLayoutPanel();
            panelCard = new Panel();
            tlpCard.SuspendLayout();
            tlpForm.SuspendLayout();
            tlpRoot.SuspendLayout();
            panelCard.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCard
            // 
            tlpCard.AutoSize = true;
            tlpCard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpCard.ColumnCount = 1;
            tlpCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCard.Controls.Add(tlpForm, 0, 1);
            tlpCard.Controls.Add(lblLogin, 0, 0);
            tlpCard.Controls.Add(btnLogin, 0, 2);
            tlpCard.Location = new Point(23, 23);
            tlpCard.Name = "tlpCard";
            tlpCard.RowCount = 3;
            tlpCard.RowStyles.Add(new RowStyle());
            tlpCard.RowStyles.Add(new RowStyle());
            tlpCard.RowStyles.Add(new RowStyle());
            tlpCard.Size = new Size(278, 131);
            tlpCard.TabIndex = 0;
            // 
            // tlpForm
            // 
            tlpForm.AutoSize = true;
            tlpForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpForm.ColumnCount = 2;
            tlpForm.ColumnStyles.Add(new ColumnStyle());
            tlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpForm.Controls.Add(txtPassword, 1, 1);
            tlpForm.Controls.Add(lblPassword, 0, 1);
            tlpForm.Controls.Add(txtUsername, 1, 0);
            tlpForm.Controls.Add(lblUsername, 0, 0);
            tlpForm.Dock = DockStyle.Top;
            tlpForm.Location = new Point(3, 35);
            tlpForm.Name = "tlpForm";
            tlpForm.RowCount = 2;
            tlpForm.RowStyles.Add(new RowStyle());
            tlpForm.RowStyles.Add(new RowStyle());
            tlpForm.RowStyles.Add(new RowStyle());
            tlpForm.RowStyles.Add(new RowStyle());
            tlpForm.Size = new Size(272, 52);
            tlpForm.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(69, 29);
            txtPassword.MaximumSize = new Size(200, 20);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 20);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(6, 31);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(69, 3);
            txtUsername.MaximumSize = new Size(200, 20);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 20);
            txtUsername.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(3, 5);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Dock = DockStyle.Fill;
            lblLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblLogin.Location = new Point(3, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(272, 32);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            lblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Location = new Point(39, 106);
            btnLogin.Margin = new Padding(0, 16, 0, 0);
            btnLogin.MaximumSize = new Size(200, 25);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 25);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
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
            tlpRoot.Size = new Size(818, 727);
            tlpRoot.TabIndex = 3;
            // 
            // panelCard
            // 
            panelCard.Anchor = AnchorStyles.None;
            panelCard.AutoSize = true;
            panelCard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelCard.BackColor = Color.White;
            panelCard.Controls.Add(tlpCard);
            panelCard.Location = new Point(247, 275);
            panelCard.Margin = new Padding(0);
            panelCard.MaximumSize = new Size(400, 0);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(20);
            panelCard.Size = new Size(324, 177);
            panelCard.TabIndex = 0;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 243, 255);
            Controls.Add(tlpRoot);
            Name = "LoginView";
            Size = new Size(818, 727);
            tlpCard.ResumeLayout(false);
            tlpCard.PerformLayout();
            tlpForm.ResumeLayout(false);
            tlpForm.PerformLayout();
            tlpRoot.ResumeLayout(false);
            tlpRoot.PerformLayout();
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCard;
        private TableLayoutPanel tlpForm;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblLogin;
        private Button btnLogin;
        private TableLayoutPanel tlpRoot;
        private Panel panelCard;
    }
}
