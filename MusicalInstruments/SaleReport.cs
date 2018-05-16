using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicalInstruments
{
    public partial class SaleReport : Form
    {

        public SaleReport(DateTime currentDate, String instrument, String manufacturer, String mark, String seller, String buyer, int count, int price, int endPrice)
        {
            InitializeComponent();

            String file = File.ReadAllText("reports\\sale_inst_report.rdl");

            file = file.Replace("_REP_CURRENT_DATE_", currentDate.ToShortDateString());

            file = file.Replace("_REP_INST_NAME_", instrument);

            file = file.Replace("_REP_MANUFACTURER_", manufacturer);

            file = file.Replace("_REP_MARK_", mark);

            file = file.Replace("_REP_COUNT_", count.ToString());

            file = file.Replace("_REP_SELLER_", seller);

            file = file.Replace("_REP_BUYER_", buyer);

            file = file.Replace("_REP_PRICE_", price.ToString());

            file = file.Replace("_REP_END_PRICE_", endPrice.ToString());

            File.WriteAllText("reports\\sale_inst_report_tmp.rdl", file);

            string filepath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "reports\\sale_inst_report_tmp.rdl");
            rdlViewer1.SourceFile = new Uri(filepath);

            rdlViewer1.Rebuild();
        }
    }
}
