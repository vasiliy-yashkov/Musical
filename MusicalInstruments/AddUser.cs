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
    public partial class AddUser : Form
    {
        private string user;
        private string password;
        private int role;
        private string roleName;

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public int Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }
        }

        public string RoleName
        {
            get
            {
                return roleName;
            }

            set
            {
                roleName = value;
            }
        }

        public AddUser ()
        {
            InitializeComponent();
        }

        private void btnOK_Click (object sender, EventArgs e)
        {
            this.user = txtLogin.Text;
            this.password = txtPassword.Text;
            this.role = (int)((Int64)comboBox1.SelectedValue);
            MusDataSet.M_ROLESDataTable roles = this.m_ROLESTableAdapter.GetDataByID(this.role);
            MusDataSet.M_ROLESRow row = (MusDataSet.M_ROLESRow)roles.Rows[0];
            this.RoleName = row.R_NAME;
        }

        private void btnCancel_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUser_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musDataSet.M_ROLES' table. You can move, or remove it, as needed.
            this.m_ROLESTableAdapter.Fill(this.musDataSet.M_ROLES);

        }
    }
}
