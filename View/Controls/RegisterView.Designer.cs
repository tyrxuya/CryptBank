namespace View.Controls
{
    partial class RegisterView
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
            tlpForm = new TableLayoutPanel();
            txtConfirm = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblConfirm = new Label();
            lblIterations = new Label();
            txtUsername = new TextBox();
            cmbIterations = new ComboBox();
            lblUsername = new Label();
            lblRegister = new Label();
            btnRegister = new Button();
            tlpRoot.SuspendLayout();
            panelCard.SuspendLayout();
            tlpCard.SuspendLayout();
            tlpForm.SuspendLayout();
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
            tlpRoot.Size = new Size(967, 794);
            tlpRoot.TabIndex = 0;
            // 
            // panelCard
            // 
            panelCard.Anchor = AnchorStyles.None;
            panelCard.AutoSize = true;
            panelCard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelCard.BackColor = Color.White;
            panelCard.Controls.Add(tlpCard);
            panelCard.Location = new Point(301, 282);
            panelCard.Margin = new Padding(0);
            panelCard.MaximumSize = new Size(400, 0);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(20);
            panelCard.Size = new Size(365, 229);
            panelCard.TabIndex = 0;
            // 
            // tlpCard
            // 
            tlpCard.AutoSize = true;
            tlpCard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpCard.ColumnCount = 1;
            tlpCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCard.Controls.Add(tlpForm, 0, 1);
            tlpCard.Controls.Add(lblRegister, 0, 0);
            tlpCard.Controls.Add(btnRegister, 0, 2);
            tlpCard.Location = new Point(20, 20);
            tlpCard.Name = "tlpCard";
            tlpCard.RowCount = 3;
            tlpCard.RowStyles.Add(new RowStyle());
            tlpCard.RowStyles.Add(new RowStyle());
            tlpCard.RowStyles.Add(new RowStyle());
            tlpCard.Size = new Size(322, 186);
            tlpCard.TabIndex = 0;
            // 
            // tlpForm
            // 
            tlpForm.AutoSize = true;
            tlpForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpForm.ColumnCount = 2;
            tlpForm.ColumnStyles.Add(new ColumnStyle());
            tlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpForm.Controls.Add(txtConfirm, 1, 2);
            tlpForm.Controls.Add(txtPassword, 1, 1);
            tlpForm.Controls.Add(lblPassword, 0, 1);
            tlpForm.Controls.Add(lblConfirm, 0, 2);
            tlpForm.Controls.Add(lblIterations, 0, 3);
            tlpForm.Controls.Add(txtUsername, 1, 0);
            tlpForm.Controls.Add(cmbIterations, 1, 3);
            tlpForm.Controls.Add(lblUsername, 0, 0);
            tlpForm.Dock = DockStyle.Top;
            tlpForm.Location = new Point(3, 35);
            tlpForm.Name = "tlpForm";
            tlpForm.RowCount = 4;
            tlpForm.RowStyles.Add(new RowStyle());
            tlpForm.RowStyles.Add(new RowStyle());
            tlpForm.RowStyles.Add(new RowStyle());
            tlpForm.RowStyles.Add(new RowStyle());
            tlpForm.Size = new Size(316, 107);
            tlpForm.TabIndex = 1;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(113, 55);
            txtConfirm.MaximumSize = new Size(200, 20);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(200, 20);
            txtConfirm.TabIndex = 6;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(113, 29);
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
            lblPassword.Location = new Point(50, 31);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblConfirm
            // 
            lblConfirm.Anchor = AnchorStyles.Right;
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(3, 57);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(104, 15);
            lblConfirm.TabIndex = 2;
            lblConfirm.Text = "Confirm password";
            // 
            // lblIterations
            // 
            lblIterations.Anchor = AnchorStyles.Right;
            lblIterations.AutoSize = true;
            lblIterations.Location = new Point(51, 85);
            lblIterations.Name = "lblIterations";
            lblIterations.Size = new Size(56, 15);
            lblIterations.TabIndex = 3;
            lblIterations.Text = "Iterations";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(113, 3);
            txtUsername.MaximumSize = new Size(200, 20);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 20);
            txtUsername.TabIndex = 4;
            // 
            // cmbIterations
            // 
            cmbIterations.FormattingEnabled = true;
            cmbIterations.Items.AddRange(new object[] { "1000", "10000", "100000", "500000", "1000000" });
            cmbIterations.Location = new Point(113, 81);
            cmbIterations.MaximumSize = new Size(200, 0);
            cmbIterations.Name = "cmbIterations";
            cmbIterations.Size = new Size(200, 23);
            cmbIterations.TabIndex = 7;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(47, 5);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Dock = DockStyle.Fill;
            lblRegister.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblRegister.Location = new Point(3, 0);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(316, 32);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "Register";
            lblRegister.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegister.Location = new Point(61, 161);
            btnRegister.Margin = new Padding(0, 16, 0, 0);
            btnRegister.MaximumSize = new Size(200, 25);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 25);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(246, 243, 255);
            Controls.Add(tlpRoot);
            Name = "RegisterView";
            Size = new Size(967, 794);
            tlpRoot.ResumeLayout(false);
            tlpRoot.PerformLayout();
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            tlpCard.ResumeLayout(false);
            tlpCard.PerformLayout();
            tlpForm.ResumeLayout(false);
            tlpForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpRoot;
        private Panel panelCard;
        private TextBox textBox4;
        private TableLayoutPanel tlpCard;
        private TableLayoutPanel tlpForm;
        private TextBox txtConfirm;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirm;
        private Label lblIterations;
        private TextBox txtUsername;
        private ComboBox cmbIterations;
        private Label lblRegister;
        private Button btnRegister;
    }
}
