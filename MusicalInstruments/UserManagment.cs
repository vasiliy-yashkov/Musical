using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicalInstruments
{
    public partial class UserManagment : Form
    {
        public UserManagment ()
        {
            InitializeComponent();
        }

        private void m_USERSBindingNavigatorSaveItem_Click (object sender, EventArgs e)
        {
            this.Validate();
            this.m_USERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musDataSet);

        }

        private void UserManagment_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musDataSet.M_ROLES' table. You can move, or remove it, as needed.
            this.m_ROLESTableAdapter.Fill(this.musDataSet.M_ROLES);
            // TODO: This line of code loads data into the 'musDataSet.M_USERS' table. You can move, or remove it, as needed.
            this.m_USERSTableAdapter.Fill(this.musDataSet.M_USERS);

        }

        private void bindingNavigatorDeleteItem_Click (object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            string conn = connectionStringsSection.ConnectionStrings["MusicalInstruments.Properties.Settings.ConnectionString"].ConnectionString;
            FirebirdSql.Data.Services.FbSecurity security = new FirebirdSql.Data.Services.FbSecurity(conn);
            FirebirdSql.Data.Services.FbUserData user = new FirebirdSql.Data.Services.FbUserData();
            if (m_USERSDataGridView.SelectedRows.Count == 0)
                return;
            user.UserName = m_USERSDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            security.DeleteUser(user);

            m_USERSBindingNavigatorSaveItem_Click(null, null);

            m_USERSBindingNavigatorSaveItem_Click(null, null);
        }

        private void bindingNavigatorAddNewItem_Click (object sender, EventArgs e)
        {
            AddUser adduser = new AddUser();
            if (adduser.ShowDialog() == DialogResult.OK)
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                string conn = connectionStringsSection.ConnectionStrings["MusicalInstruments.Properties.Settings.ConnectionString"].ConnectionString;
                FirebirdSql.Data.Services.FbSecurity security = new FirebirdSql.Data.Services.FbSecurity(conn);
                FirebirdSql.Data.Services.FbUserData user = new FirebirdSql.Data.Services.FbUserData();
                user.UserName = adduser.User;
                user.UserPassword = adduser.Password;
                security.AddUser(user);

                int i = m_USERSTableAdapter.InsertQuery(adduser.User, adduser.Role);
                this.tableAdapterManager.UpdateAll(this.musDataSet);
            }
        }
    }
}
