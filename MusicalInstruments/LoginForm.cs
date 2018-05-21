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
    }
}
