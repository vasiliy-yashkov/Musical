using FirebirdSql.Data.FirebirdClient;
using fyiReporting.RdlDesign;
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

using GuitarTuner;

namespace MusicalInstruments
{
    public partial class MainForm : Form
    {
        private User user;

        public MainForm(string login, string password)
        {
            InitializeComponent();

            // Тут можно изменить настройки и залогиниться под другой учетной записью, если надо
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            string appPath = Application.StartupPath;
            string dbPath = appPath + "\\db\\MUS_DB.FDB";
            FbConnectionStringBuilder cs = new FbConnectionStringBuilder();
            cs.DataSource = "localhost";
            cs.Database = dbPath;
            cs.UserID = login;
            cs.Password = password;
            cs.Charset = "WIN1251";
            cs.Pooling = false;
            //cs.Role = "SELLER";

            //connectionStringsSection.ConnectionStrings["MusicalInstruments.Properties.Settings.ConnectionString"].ConnectionString =
            //    cs.ToString();
            //config.Save();
            //ConfigurationManager.RefreshSection("connectionStrings");

            //connectionStringsSection.ConnectionStrings["MusicalInstruments.Properties.Settings.ConnectionString"].ConnectionString =
            //    cs.ToString();
            //config.Save();
            //ConfigurationManager.RefreshSection("connectionStrings");

            bool onClosing = false;

            FbConnection connection = new FbConnection(cs.ToString());
            try
            {
                connection.Open();
                connection.Close();

                connectionLabel.Text = "Статус: " + dbPath + "; Пользователь: " + login;
                this.connectionLabel.Image = global::MusicalInstruments.Properties.Resources.ok;
                objectsToolStripMenuItem.Enabled = true;
                controlToolStripMenuItem.Enabled = true;
                reportsToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка соединения с базой данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connectionLabel.Text = "Статус: соединение не установлено";
                this.connectionLabel.Image = global::MusicalInstruments.Properties.Resources.error;
                objectsToolStripMenuItem.Enabled = false;
                controlToolStripMenuItem.Enabled = false;
                reportsToolStripMenuItem.Enabled = false;

                onClosing = true;
            }

            if (onClosing)
                Close();
            else
            {

                var cn = new FbConnection(cs.ToString());
                var cmd = new FbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"select r_name from m_roles
                                    join m_users on u_role = r_id
                                    where u_name = '" + login + "'";
                cmd.Connection = cn;

                DataTable dt = GetTable(cmd);

                string role = dt.Rows[0].ItemArray[0].ToString();

                user = new User();

                user.Login = login;
                user.Password = password;
                user.Role = role;//roleRow.R_NAME;

                checkAccess();

                cs.Role = user.Role;
                config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["MusicalInstruments.Properties.Settings.ConnectionString"].ConnectionString =
    cs.ToString();
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");
            }
        }

        public DataTable GetTable (FbCommand cmd)
        {
            System.Data.ConnectionState original = cmd.Connection.State;
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }

            DataTable dt = new DataTable();
            FbDataReader dr;

            try
            {
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                dr.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте корректность введенных данных и фильтров!" + Environment.NewLine + ex.Message, "Ошибка выполнения запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }

            return dt;
        }

        private void checkAccess ()
        {
            if (user.Role.ToUpper().Equals("RDB$ADMIN") || user.Role.ToUpper().Equals("MADMIN"))
            {
                if (user.Role.ToUpper().Equals("MADMIN"))
                {
                    usersToolStripMenuItem.Visible = false;
                }
            }
            else
            {
                deliveriesToolStripMenuItem.Visible = false;
                objectsToolStripMenuItem.Visible = false;
                usersToolStripMenuItem.Visible = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void typesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Types types = new Types();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Types))
                    types = (Types)form;
            }
            types.MdiParent = this;
            types.Show();
        }

        private void designerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RdlDesigner designer = new RdlDesigner("", true);
            designer.Show();
        }

        private void instrumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instruments instruments = new Instruments();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Instruments))
                    instruments = (Instruments)form;
            }
            instruments.MdiParent = this;
            instruments.Show();
        }

        private void marksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marks marks = new Marks();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Marks))
                    marks = (Marks)form;
            }
            marks.MdiParent = this;
            marks.Show();
        }

        private void manufacturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manufacturers manufacturers = new Manufacturers();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Manufacturers))
                    manufacturers = (Manufacturers)form;
            }
            manufacturers.MdiParent = this;
            manufacturers.Show();
        }

        private void deliveriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Delivery))
                    delivery = (Delivery)form;
            }
            delivery.MdiParent = this;
            delivery.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Sales))
                    sales = (Sales)form;
            }
            sales.MdiParent = this;
            sales.Show();
        }

        private void deliveryReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeliveryReports delReports = new DeliveryReports(user);
            delReports.ShowDialog();
        }

        private void saleReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleReports salReports = new SaleReports(user);
            salReports.ShowDialog();
        }

        private void availableInstrumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvailableInst avInst = new AvailableInst(user);
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(AvailableInst))
                    avInst = (AvailableInst)form;
            }
            avInst.MdiParent = this;
            avInst.Show();
        }

        private void sellersToolStripMenuItem_Click (object sender, EventArgs e)
        {
            Sellers sellers = new Sellers();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Sellers))
                    sellers = (Sellers)form;
            }
            sellers.MdiParent = this;
            sellers.Show();
        }

        private void tunerToolStripMenuItem_Click (object sender, EventArgs e)
        {
            TunerView tuner = new TunerView();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(TunerView))
                    tuner = (TunerView)form;
            }
            tuner.MdiParent = this;
            tuner.Show();
        }

        private void accessoriesToolStripMenuItem_Click (object sender, EventArgs e)
        {
            Accessories acc = new Accessories();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Accessories))
                    acc = (Accessories)form;
            }
            acc.MdiParent = this;
            acc.Show();
        }

        private void userManagementToolStripMenuItem_Click (object sender, EventArgs e)
        {
            UserManagment users = new UserManagment();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(UserManagment))
                    users = (UserManagment)form;
            }
            users.MdiParent = this;
            users.Show();
        }
    }
}
