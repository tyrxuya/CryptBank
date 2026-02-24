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

        }
    }
}
