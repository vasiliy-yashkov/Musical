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
    public partial class DeliveryReports : Form
    {
        public DeliveryReports()
        {
            InitializeComponent();

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
            cmd.CommandText = @"select 
                                m_delivery.""DATE"" as del_date,
                                m_delivery.provider as prov_name,
                                m_delivery.""COUNT"" as inst_count,
                                m_delivery.release_date as rel_date,
                                m_instrument.name as inst_name,
                                m_instrument.price as inst_price,
                                m_manufacturer.name as man_name,
                                m_mark.name as mark_name
                            from m_manufacturer
                               inner join m_mark on (m_manufacturer.id = m_mark.man_id)
                               inner join m_instrument on (m_mark.id = m_instrument.mark_id)
                               inner join m_delivery on (m_instrument.id = m_delivery.instrument_id)";
            cmd.Connection = cn;

            DataTable dt = GetTable(cmd);

            String file = File.ReadAllText("reports\\delivery_report.rdl");

            File.WriteAllText("reports\\delivery_report_tmp.rdl", file);

            string filepath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "reports\\delivery_report_tmp.rdl");

            Uri url = new Uri(filepath);
            this.rdlViewer1.SourceFile = url;

            this.rdlViewer1.Report.DataSets["Data"].SetData(dt);
            this.rdlViewer1.Report.DataSets["Data"].SetSource(cmd.CommandText);
            this.rdlViewer1.Parameters += string.Format("ConnectionString={0}", connection);

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
            /*
             *
             *Дата поставки
                Поставщик
                Количество
                Наименование
                Цена за ед.
                Производитель
                Марка 
             */

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
                                m_delivery.""DATE"" as del_date,
                                m_delivery.provider as prov_name,
                                m_delivery.""COUNT"" as inst_count,
                                m_delivery.release_date as rel_date,
                                m_instrument.name as inst_name,
                                m_instrument.price as inst_price,
                                m_manufacturer.name as man_name,
                                m_mark.name as mark_name
                            from m_manufacturer
                               inner join m_mark on (m_manufacturer.id = m_mark.man_id)
                               inner join m_instrument on (m_mark.id = m_instrument.mark_id)
                               inner join m_delivery on (m_instrument.id = m_delivery.instrument_id)";
            cmd.Connection = cn;

            if (!String.IsNullOrEmpty(filter))
            {
                command += " WHERE " + filter;
            }

            cmd.CommandText = command;

            DataTable dt = GetTable(cmd);

            String file = File.ReadAllText("reports\\delivery_report.rdl");

            File.WriteAllText("reports\\delivery_report_tmp.rdl", file);

            string filepath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "reports\\delivery_report_tmp.rdl");

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
                            if (cell.Value.ToString() == "Дата поставки")
                                filter += " m_delivery.\"DATE\" ";
                            else if (cell.Value.ToString() == "Поставщик")
                                filter += " m_delivery.provider ";
                            else if (cell.Value.ToString() == "Количество")
                                filter += " m_delivery.\"COUNT\" ";
                            else if (cell.Value.ToString() == "Наименование")
                                filter += " m_instrument.name ";
                            else if (cell.Value.ToString() == "Цена за ед.")
                                filter += " m_instrument.price ";
                            else if (cell.Value.ToString() == "Производитель")
                                filter += " m_manufacturer.name ";
                            else if (cell.Value.ToString() == "Марка")
                                filter += " m_mark.name ";
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
