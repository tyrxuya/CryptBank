using Core.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View.Controls
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string pass = txtPassword.Text;

            var user = AppServices.UserCreds.FindByUsername(username);
            if (user == null)
            {
                MessageBox.Show("Грешно потребителско име или парола.");
                return;
            }

            bool ok = PasswordHashService.VerifyPassword(
                password: pass,
                saltB64: user.SaltB64,
                iterations: user.Iterations,
                dkLen: user.DkLen,
                expectedHashB64: user.HashB64
            );

            if (ok)
            {
                MessageBox.Show("Успешен вход!");
            }
                
            else
            {
                MessageBox.Show("Грешно потребителско име или парола.");
            }
                
            txtPassword.Clear();
        }
    }
}
