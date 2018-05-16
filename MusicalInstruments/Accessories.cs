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
    public partial class Accessories : Form
    {
        public Accessories ()
        {
            InitializeComponent();
        }

        private void m_ACCESSORIESBindingNavigatorSaveItem_Click (object sender, EventArgs e)
        {
            this.Validate();
            this.m_ACCESSORIESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musDataSet);

        }

        private void Accessories_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musDataSet.M_ACCESSORIES' table. You can move, or remove it, as needed.
            this.m_ACCESSORIESTableAdapter.Fill(this.musDataSet.M_ACCESSORIES);

        }

        private void m_ACCESSORIESDataGridView_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Image image = null;
                byte[] obj = null;
                if (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value != null &&
                    !String.IsNullOrWhiteSpace(senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString()))
                {
                    obj = (byte[])senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value;

                    using (var ms = new MemoryStream(obj))
                    {
                        image = Image.FromStream(ms);
                    }
                }

                ImageLoader imageLoader = new ImageLoader(image);
                if (imageLoader.ShowDialog() == DialogResult.OK)
                {
                    image = imageLoader.Image;
                    using (var ms = new MemoryStream())
                    {
                        image.Save(ms, image.RawFormat);
                        obj = ms.ToArray();
                        senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value = obj;
                    }
                }
            }
        }
    }
}
