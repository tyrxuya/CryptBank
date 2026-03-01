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
    public partial class StrengthView : UserControl
    {
        public StrengthView()
        {
            InitializeComponent();
            cmbG.SelectedIndex = 3;

            txtPassword.TextChanged += (_, __) => UpdateStrength();
            cmbG.SelectedIndexChanged += (_, __) => UpdateStrength();
        }

        private void UpdateStrength()
        {
            double g = ParseGuessesPerSecond();
            var r = PasswordStrengthService.Evaluate(txtPassword.Text, g);

            lblLengthVal.Text = r.Length.ToString();
            lblAlphabetSizeVal.Text = r.AlphabetSize.ToString();
            lblEntropyVal.Text = $"{r.EntropyBits:F1} bits";

            lblCrackTimeVal.Text = PasswordStrengthService.FormatTime(r.CrackTimeSeconds);

            progressStrength.Value = Math.Clamp(r.Score, 0, 100);

            lblLowercase.Text = txtPassword.Text.Any(char.IsLower) ? "✔️ lowercase" : "❌ lowercase";
            lblLowercase.Font = new Font(lblLowercase.Font, txtPassword.Text.Any(char.IsLower) ? FontStyle.Bold : FontStyle.Regular);
            lblLowercase.ForeColor = txtPassword.Text.Any(char.IsLower) ? Color.Green : Color.Red;

            lblUppercase.Text = txtPassword.Text.Any(char.IsUpper) ? "✔️ uppercase" : "❌ uppercase";
            lblUppercase.Font = new Font(lblUppercase.Font, txtPassword.Text.Any(char.IsUpper) ? FontStyle.Bold : FontStyle.Regular);
            lblUppercase.ForeColor = txtPassword.Text.Any(char.IsUpper) ? Color.Green : Color.Red;

            lblDigits.Text = txtPassword.Text.Any(char.IsDigit) ? "✔️ digits" : "❌ digits";
            lblDigits.Font = new Font(lblDigits.Font, txtPassword.Text.Any(char.IsDigit) ? FontStyle.Bold : FontStyle.Regular);
            lblDigits.ForeColor = txtPassword.Text.Any(char.IsDigit) ? Color.Green : Color.Red;

            lblSpecial.Text = txtPassword.Text.Any(ch => !char.IsLetterOrDigit(ch)) ? "✔️ special" : "❌ special";
            lblSpecial.Font = new Font(lblSpecial.Font, txtPassword.Text.Any(ch => !char.IsLetterOrDigit(ch)) ? FontStyle.Bold : FontStyle.Regular);
            lblSpecial.ForeColor = txtPassword.Text.Any(ch => !char.IsLetterOrDigit(ch)) ? Color.Green : Color.Red;
        }

        private double ParseGuessesPerSecond()
        {
            if (double.TryParse(cmbG.Text.Replace(" ", ""), out var g))
            {
                return g; 
            }

            return 1.0;
        }
    }
}
