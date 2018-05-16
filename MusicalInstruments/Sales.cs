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
    public partial class Sales : Form
    {
        private MusDataSetTableAdapters.M_STORAGETableAdapter storage;
        private MusDataSetTableAdapters.M_SALETableAdapter saleAdapter;
        private MusDataSetTableAdapters.M_MARKTableAdapter markAdapter;
        private MusDataSetTableAdapters.M_MANUFACTURERTableAdapter manAdapter;

        private String manufacturer;
        private String mark;

        private String command = null;

        public Sales ()
        {
            InitializeComponent();

            storage = new MusDataSetTableAdapters.M_STORAGETableAdapter();
            storage.ClearBeforeFill = true;

            saleAdapter = new MusDataSetTableAdapters.M_SALETableAdapter();
            saleAdapter.ClearBeforeFill = true;

            markAdapter = new MusDataSetTableAdapters.M_MARKTableAdapter();
            markAdapter.ClearBeforeFill = true;

            manAdapter = new MusDataSetTableAdapters.M_MANUFACTURERTableAdapter();
            manAdapter.ClearBeforeFill = true;
        }

        private void Sales_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musDataSet.M_TYPE' table. You can move, or remove it, as needed.
            this.m_TYPETableAdapter.Fill(this.musDataSet.M_TYPE);
            // TODO: This line of code loads data into the 'musDataSet.M_SELLER' table. You can move, or remove it, as needed.
            this.m_SELLERTableAdapter.Fill(this.musDataSet.M_SELLER);
            // TODO: This line of code loads data into the 'musDataSet.M_INSTRUMENT' table. You can move, or remove it, as needed.
            int value = Convert.ToInt32((long)cmbType.SelectedValue);
            this.m_INSTRUMENTTableAdapter.FillByInstID(this.musDataSet.M_INSTRUMENT, value);
            // TODO: This line of code loads data into the 'musDataSet.M_ACCESSORIES' table. You can move, or remove it, as needed. 
            this.m_ACCESSORIESTableAdapter.Fill(this.musDataSet.M_ACCESSORIES);

            if (String.IsNullOrEmpty(command))
                command = this.m_ACCESSORIESTableAdapter.Adapter.SelectCommand.CommandText;

            string whereCommand = command;

            if (!String.IsNullOrEmpty(cmbType.Text) || !String.IsNullOrEmpty(cmbInstruments.Text))
            {
                if (!whereCommand.Contains(" \n where \n"))
                    whereCommand += " \n where \n";

                if (!String.IsNullOrEmpty(cmbType.Text))
                    whereCommand += " acc_tags containing '" + cmbType.Text + "'";

                if (!String.IsNullOrEmpty(cmbInstruments.Text))
                    whereCommand += " or acc_tags containing '" + cmbInstruments.Text + "'";
            }

            this.m_ACCESSORIESTableAdapter.Adapter.SelectCommand.CommandText = whereCommand;
            this.m_ACCESSORIESTableAdapter.Fill(this.musDataSet.M_ACCESSORIES);

            cmbInstruments_SelectedIndexChanged(null, null);
        }

        private void cmbInstruments_SelectedIndexChanged (object sender, EventArgs e)
        {
            this.numCount.Minimum = 0;

            object selID = this.cmbInstruments.SelectedValue;
            if (selID != null)
            {
                MusDataSet.M_STORAGEDataTable table = storage.GetDataByInstID((long)selID);
                MusDataSet.M_STORAGERow row = table.Rows[0] as MusDataSet.M_STORAGERow;
                long count = row.COUNT;

                this.numCount.Maximum = count;

                MusDataSet.M_INSTRUMENTDataTable instTable = this.m_INSTRUMENTTableAdapter.GetDataByID((long)selID);
                MusDataSet.M_INSTRUMENTRow instRow = instTable.Rows[0] as MusDataSet.M_INSTRUMENTRow;

                txtPrice.Text = instRow.PRICE.ToString();
                txtEndPrice.Text = (instRow.PRICE * (double)this.numCount.Value).ToString();

                MusDataSet.M_MARKDataTable markTable = this.markAdapter.GetDataByID((long)instRow.MARK_ID);
                MusDataSet.M_MARKRow markRow = markTable.Rows[0] as MusDataSet.M_MARKRow;

                this.mark = markRow.NAME;

                MusDataSet.M_MANUFACTURERDataTable manTable = this.manAdapter.GetDataByID((long)markRow.MAN_ID);
                MusDataSet.M_MANUFACTURERRow manRow = manTable.Rows[0] as MusDataSet.M_MANUFACTURERRow;

                this.manufacturer = manRow.NAME;
            }
        }

        private void numCount_ValueChanged (object sender, EventArgs e)
        {
            txtEndPrice.Text = (Double.Parse(txtPrice.Text) * (double)this.numCount.Value).ToString();
        }

        private void btnApply_Click (object sender, EventArgs e)
        {
            if (cmbSeller.SelectedIndex == -1 || String.IsNullOrEmpty(txtBuyer.Text))
            {
                MessageBox.Show("Заполните продавца и покупателя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.numCount.Value == 0)
            {
                MessageBox.Show("Количество не может быть 0!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime currentDate = DateTime.Now;
            int instID = int.Parse(cmbInstruments.SelectedValue.ToString());
            int instCount = (int)this.numCount.Value;
            int sellerID = int.Parse(cmbSeller.SelectedValue.ToString());

            int res = saleAdapter.Insert(currentDate, instID, instCount, txtBuyer.Text, sellerID);
            if (res > 0)
            {
                string instrument = cmbInstruments.Text;
                string seller = cmbSeller.Text;
                Sales_Load(null, null);

                SaleReport saleReport = new SaleReport(currentDate, instrument, manufacturer, mark, seller, txtBuyer.Text,
                    instCount, int.Parse(txtPrice.Text), int.Parse(txtEndPrice.Text));
                saleReport.ShowDialog();
            }
        }

        private void cmbType_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (cmbType.SelectedValue == null)
                return;
            // TODO: This line of code loads data into the 'musDataSet.M_INSTRUMENT' table. You can move, or remove it, as needed.
            this.m_INSTRUMENTTableAdapter.FillByInstID(this.musDataSet.M_INSTRUMENT, Convert.ToInt32(cmbType.SelectedValue));

            string command = "select * from m_accessories";

            if (!String.IsNullOrEmpty(cmbType.Text) || !String.IsNullOrEmpty(cmbInstruments.Text))
            {
                if (!command.Contains(" \n where \n"))
                    command += " \n where \n";

                if (!String.IsNullOrEmpty(cmbType.Text))
                    command += " acc_tags containing '" + cmbType.Text + "'";

                if (!String.IsNullOrEmpty(cmbInstruments.Text))
                    command += " or acc_tags containing '" + cmbInstruments.Text + "'";
            }

            this.m_ACCESSORIESTableAdapter.Adapter.SelectCommand.CommandText = command;
            this.m_ACCESSORIESTableAdapter.Fill(this.musDataSet.M_ACCESSORIES);

            cmbInstruments_SelectedIndexChanged(null, null);
        }

        private void m_ACCESSORIESDataGridView_CellClick (object sender, DataGridViewCellEventArgs e)
        {
            object[] arr = new object[] { m_ACCESSORIESDataGridView.Rows[e.RowIndex].Cells[1].Value,
            (double)m_ACCESSORIESDataGridView.Rows[e.RowIndex].Cells[3].Value, (int)1, (double)0};

            selectedDataGrid.Rows.Add(arr);

            rebuildAccPrice();
        }

        private void selectedDataGrid_RowsAdded (object sender, DataGridViewRowsAddedEventArgs e)
        {
            selectedDataGrid.Rows[e.RowIndex].Cells[3].Value =
                (double)selectedDataGrid.Rows[e.RowIndex].Cells[1].Value * (int)selectedDataGrid.Rows[e.RowIndex].Cells[2].Value;
        }

        private void selectedDataGrid_CellEndEdit (object sender, DataGridViewCellEventArgs e)
        {
            if (selectedDataGrid.Rows[e.RowIndex].Cells[1].Value != null ||
                selectedDataGrid.Rows[e.RowIndex].Cells[1].Value != "")
            {

                double price = (double)selectedDataGrid.Rows[e.RowIndex].Cells[1].Value;
                int count = int.Parse(selectedDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                selectedDataGrid.Rows[e.RowIndex].Cells[3].Value =
                price * count;
            }

            rebuildAccPrice();
        }

        private void rebuildAccPrice ()
        {
            double price = 0d;
            foreach (DataGridViewRow row in selectedDataGrid.Rows)
            {
                string cell = row.Cells[3].Value.ToString().Replace(',', '.');
                price += double.Parse(cell);
            }

            txtAccPrice.Text = price.ToString();
        }

        private void selectedDataGrid_RowsRemoved (object sender, DataGridViewRowsRemovedEventArgs e)
        {
            rebuildAccPrice();
        }
    }
}
