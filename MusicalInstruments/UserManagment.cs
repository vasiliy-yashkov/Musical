﻿using FirebirdSql.Data.FirebirdClient;
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
        private int currentRow = -1;

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
            if (currentRow == -1)
                return;
            user.UserName = m_USERSDataGridView.Rows[currentRow].Cells[1].Value.ToString();

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

                try
                {
                    user.UserName = adduser.User;
                    user.UserPassword = adduser.Password;
                    //user.RoleName = adduser.RoleName;
                                        
                    var cn = new FbConnection(conn);
                    var cmd = new FbCommand();
                    cmd.CommandType = CommandType.Text;                
                    cmd.Connection = cn;
                    if (adduser.RoleName.ToUpper().Equals("RDB$ADMIN"))
                    {
                        cmd.CommandText = @"CREATE USER " + user.UserName + " PASSWORD '" + user.UserPassword + "' GRANT ADMIN ROLE";
                        adduser.RoleName = "RDB$ADMIN";
                        execute(cmd);
                    }
                    else
                    {
                        //security.AddUser(user);
                        //cmd.CommandText = @"grant " + adduser.RoleName + " to " + user.UserName;
                        cmd.CommandText = @"CREATE USER " + user.UserName + " PASSWORD '" + user.UserPassword + "'";
                        execute(cmd);
                        cmd.CommandText = @"grant " + adduser.RoleName + " to " + user.UserName;
                        execute(cmd);
                    }
                                       

                    int i = m_USERSTableAdapter.InsertQuery(adduser.User, adduser.Role);
                    this.tableAdapterManager.UpdateAll(this.musDataSet);
                    this.Validate();
                    this.m_USERSTableAdapter.Fill(this.musDataSet.M_USERS);

                    MessageBox.Show("Пользователь добавлен.", "Действие завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBoxWithDetails message = new MessageBoxWithDetails("Ошибка при добавлении пользователя!",
                        "Ошибка", ex.Message);
                    message.ShowDialog();
                }

            }
        }

        public int execute (FbCommand cmd)
        {
            System.Data.ConnectionState original = cmd.Connection.State;
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }

            int result = -13;

            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте корректность введенных данных и фильтров!" + Environment.NewLine + ex.Message, "Ошибка выполнения запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }

            return result;
        }

        private void m_USERSDataGridView_CellClick (object sender, DataGridViewCellEventArgs e)
        {
            currentRow = e.RowIndex;
        }

        private void deleteRow_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить пользователя?", "Требуется подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.No)
                return;
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            string conn = connectionStringsSection.ConnectionStrings["MusicalInstruments.Properties.Settings.ConnectionString"].ConnectionString;
            FirebirdSql.Data.Services.FbSecurity security = new FirebirdSql.Data.Services.FbSecurity(conn);
            FirebirdSql.Data.Services.FbUserData user = new FirebirdSql.Data.Services.FbUserData();
            if (currentRow == -1 || m_USERSDataGridView.Rows[currentRow].Cells[1].Value.ToString().Equals("SYSDBA"))
            {
                if (currentRow == -1)
                {
                    MessageBox.Show("Выберите пользователя для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (m_USERSDataGridView.Rows[currentRow].Cells[1].Value.ToString().Equals("SYSDBA"))
                {
                    MessageBox.Show("Невозможно удалить пользователя SYSDBA.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
            }
            user.UserName = m_USERSDataGridView.Rows[currentRow].Cells[1].Value.ToString();
            try
            {
                security.DeleteUser(user);

                m_USERSTableAdapter.DeleteQuery((int)((Int64)m_USERSDataGridView.Rows[currentRow].Cells[0].Value));

                this.tableAdapterManager.UpdateAll(this.musDataSet);
                this.Validate();
                this.m_USERSTableAdapter.Fill(this.musDataSet.M_USERS);

                MessageBox.Show("Пользователь удален.", "Действие завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                currentRow = 0;
            }
            catch (Exception ex)
            {
                MessageBoxWithDetails message = new MessageBoxWithDetails("Ошибка при удалении пользователя!",
                    "Ошибка", ex.Message);
                message.ShowDialog();
            }
        }
    }
}
