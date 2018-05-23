using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicalInstruments
{
    public partial class LoginForm : Form
    {
        private string login;
        private string password;

        private string oldText;

        public LoginForm ()
        {
            InitializeComponent();
        }

        public string Login
        {
            get
            {
                return login;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
        }

        private void btnOK_Click (object sender, EventArgs e)
        {
            this.login = txtLogin.Text;
            this.password = txtPassword.Text;
        }

        private void txtLogin_KeyPress (object sender, KeyPressEventArgs e)
        {
            oldText = txtLogin.Text;
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLogin_TextChanged (object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtLogin.Text, @"^[a-zA-Z0-9\\_\\.]+$"))
            {
                txtLogin.Text = oldText;
            }
        }
    }
}
