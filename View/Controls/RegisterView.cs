using Core.DTO;
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
    public partial class RegisterView : UserControl
    {
        public RegisterView()
        {
            InitializeComponent();
            cmbIterations.SelectedIndex = 2;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string pass = txtPassword.Text;
            string confirm = txtConfirm.Text;

            if (username.Length < 3)
            {
                MessageBox.Show("Username трябва да е поне 3 символа.");
                return;
            }

            if (pass != confirm)
            {
                MessageBox.Show("Паролите не съвпадат.");
                return;
            }

            if (!IsPasswordOk(pass))
            {
                MessageBox.Show("Паролата трябва да е поне 8 символа и да има буква + цифра.");
                return;
            }

            int iterations = ParseIterationsFromCombo();

            if (AppServices.UserCreds.FindByUsername(username) != null)
            {
                MessageBox.Show("Това потребителско име вече съществува.");
                return;
            }

            var hashed = PasswordHashService.HashPassword(pass, iterations);

            var dto = new UserCredentialsDTO
            {
                Username = username,
                Algo = hashed.Algo,
                Iterations = hashed.Iterations,
                SaltB64 = hashed.SaltB64,
                DkLen = hashed.DkLen,
                HashB64 = hashed.HashB64
            };

            AppServices.UserCreds.Add(dto);

            MessageBox.Show("Успешна регистрация!");
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirm.Clear();
        }

        private int ParseIterationsFromCombo()
        {
            if (int.TryParse(cmbIterations.Text.Replace(" ", ""), out int it))
            {
                return it;
            }
                
            return 100_000;
        }

        private bool IsPasswordOk(string pass)
        {
            if (pass.Length < 8) return false;
            bool hasLetter = pass.Any(char.IsLetter);
            bool hasDigit = pass.Any(char.IsDigit);
            return hasLetter && hasDigit;
        }
    }
}
