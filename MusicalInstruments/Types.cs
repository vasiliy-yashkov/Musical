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
    public partial class Types : Form
    {
        public Types()
        {
            InitializeComponent();
        }

        private void m_TYPEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.m_TYPEBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.musDataSet);
            }
            catch (Exception ex)
            {
                MessageBoxWithDetails message = new MessageBoxWithDetails("Пожалуйста, проверьте корректность введенных данных!",
                    "Ошибка", ex.Message);
                message.ShowDialog();
            }

            Types_Load(sender, e);
        }

        private void Types_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musDataSet.M_TYPE' table. You can move, or remove it, as needed.
            this.m_TYPETableAdapter.Fill(this.musDataSet.M_TYPE);
        }

        private void m_TYPEDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.HResult == -2146233033)
                return;
            e.Cancel = true;
            MessageBoxWithDetails message = new MessageBoxWithDetails("Пожалуйста, проверьте корректность введенных данных!",
                "Ошибка", e.Exception.Message);
            message.ShowDialog();
        }

        private void m_TYPEDataGridView_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            
        }

        private void m_TYPEDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }
    }
}
