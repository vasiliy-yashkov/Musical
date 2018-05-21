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
            string connString = "database=" + dbPath + ";data source=localhost;user=" + login + ";password=" + password;
            connectionStringsSection.ConnectionStrings["MusicalInstruments.Properties.Settings.ConnectionString"].ConnectionString =
                connString;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

            bool onClosing = false;

            FbConnection connection = new FbConnection(connString);
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

            user = new User();

            user.Login = login;
            user.Password = password;
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
            DeliveryReports delReports = new DeliveryReports();
            delReports.ShowDialog();
        }

        private void saleReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleReports salReports = new SaleReports();
            salReports.ShowDialog();
        }

        private void availableInstrumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvailableInst avInst = new AvailableInst();
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
