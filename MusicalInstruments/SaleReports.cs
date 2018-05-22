using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicalInstruments
{
    public partial class SaleReports : Form
    {
        public SaleReports(User user)
        {
            InitializeComponent();

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            string appPath = Application.StartupPath;
            string dbPath = appPath + "\\db\\MUS_DB.FDB";

            FbConnectionStringBuilder cs = new FbConnectionStringBuilder();
            cs.DataSource = "localhost";
            cs.Database = dbPath;
            cs.UserID = user.Login;
            cs.Password = user.Password;
            cs.Charset = "WIN1251";
            cs.Pooling = false;
            cs.Role = user.Role;

            var cn = new FbConnection(cs.ToString());
            var cmd = new FbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select 
                                m_sale.""DATE"" as sale_date,
                                m_instrument.name as inst_name,
                                m_sale.""COUNT"" as inst_count,
                                m_seller.seller_name as cust,
                                m_sale.buyer as buyer,
                                m_instrument.price as price,
                                m_sale.""COUNT"" * m_instrument.price as end_price
                            from m_instrument
                               inner join m_sale on (m_instrument.id = m_sale.instrument_id)
                                inner join m_seller on (m_seller.id = m_sale.seller_id)";
            cmd.Connection = cn;

            DataTable dt = GetTable(cmd);

            String file = File.ReadAllText("reports\\sale_report.rdl");

            File.WriteAllText("reports\\sale_report_tmp.rdl", file);

            string filepath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "reports\\sale_report_tmp.rdl");

            Uri url = new Uri(filepath);
            this.rdlViewer1.SourceFile = url;

            this.rdlViewer1.Report.DataSets["Data"].SetData(dt);
            this.rdlViewer1.Report.DataSets["Data"].SetSource(cmd.CommandText);
            this.rdlViewer1.Parameters += string.Format("ConnectionString={0}", cs.ToString());

            this.rdlViewer1.Rebuild();
        }

        public DataTable GetTable(FbCommand cmd)
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

        private void btnApplyFilter_Click (object sender, EventArgs e)
        {
            string filter = generateFilter();

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            string appPath = Application.StartupPath;
            string user = "SYSDBA";
            string password = "masterkey";
            string dbPath = appPath + "\\db\\MUS_DB.FDB";
            string connection =
                "database=" + dbPath + ";data source=localhost;user=" + user + ";password=" + password;


            var cn = new FbConnection(connection);
            var cmd = new FbCommand();
            cmd.CommandType = CommandType.Text;
            string command = @"select 
                                m_sale.""DATE"" as sale_date,
                                m_instrument.name as inst_name,
                                m_sale.""COUNT"" as inst_count,
                                m_seller.seller_name as cust,
                                m_sale.buyer as buyer,
                                m_instrument.price as price,
                                m_sale.""COUNT"" * m_instrument.price as end_price
                            from m_instrument
                               inner join m_sale on (m_instrument.id = m_sale.instrument_id)
                                inner join m_seller on (m_seller.id = m_sale.seller_id)";
            cmd.Connection = cn;

            if (!String.IsNullOrEmpty(filter))
            {
                command += " WHERE " + filter;
            }

            cmd.CommandText = command;

            DataTable dt = GetTable(cmd);

            String file = File.ReadAllText("reports\\sale_report.rdl");

            File.WriteAllText("reports\\sale_report_tmp.rdl", file);

            string filepath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "reports\\sale_report_tmp.rdl");

            Uri url = new Uri(filepath);
            this.rdlViewer1.SourceFile = url;

            this.rdlViewer1.Report.DataSets["Data"].SetData(dt);
            this.rdlViewer1.Report.DataSets["Data"].SetSource(cmd.CommandText);

            this.rdlViewer1.Rebuild();
        }

        private string generateFilter ()
        {
            string filter = "";
            bool first = true;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!first && row.Cells[0].Value != null)
                    filter += "\n AND \n";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        if (cell.ColumnIndex == 0)
                        {
                            if (cell.Value.ToString() == "Дата продажи")
                                filter += " m_sale.\"DATE\" ";
                            else if (cell.Value.ToString() == "Инструмент")
                                filter += " m_instrument.name ";
                            else if (cell.Value.ToString() == "Количество")
                                filter += " m_sale.\"COUNT\" ";
                            else if (cell.Value.ToString() == "Продавец")
                                filter += " m_seller.seller_name ";
                            else if (cell.Value.ToString() == "Покупатель")
                                filter += " m_sale.buyer ";
                            else if (cell.Value.ToString() == "Цена за 1 ед.")
                                filter += " m_instrument.price ";
                            else if (cell.Value.ToString() == "Цена")
                                filter += " m_sale.\"COUNT\" * m_instrument.price ";
                        }
                        else if (cell.ColumnIndex == 1)
                        {
                            if (cell.Value.ToString() != "Содержит")
                                filter += cell.Value.ToString();
                            else
                                filter += " CONTAINING ";
                        }
                        else
                        {
                            filter += " '" + cell.Value + "' ";
                        }
                    }
                }
                if (first)
                    first = false;
            }

            return filter;
        }
    }
}
