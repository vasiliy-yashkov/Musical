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
    public partial class Instruments : Form
    {
        public Instruments()
        {
            InitializeComponent();
        }

        private void m_INSTRUMENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.m_INSTRUMENTBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.musDataSet);
            }
            catch (Exception ex)
            {
                MessageBoxWithDetails message = new MessageBoxWithDetails("Пожалуйста, проверьте корректность введенных данных!",
                    "Ошибка", ex.Message);
                message.ShowDialog();
            }
        }

        private void Instruments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musDataSet.M_TYPE' table. You can move, or remove it, as needed.
            this.m_TYPETableAdapter.Fill(this.musDataSet.M_TYPE);
            // TODO: This line of code loads data into the 'musDataSet.M_MARK' table. You can move, or remove it, as needed.
            this.m_MARKTableAdapter.Fill(this.musDataSet.M_MARK);
            // TODO: This line of code loads data into the 'musDataSet.M_INSTRUMENT' table. You can move, or remove it, as needed.
            this.m_INSTRUMENTTableAdapter.Fill(this.musDataSet.M_INSTRUMENT);

        }

        private void m_INSTRUMENTDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBoxWithDetails message = new MessageBoxWithDetails("Пожалуйста, проверьте корректность введенных данных!",
                "Ошибка", e.Exception.Message);
            message.ShowDialog();
        }
    }
}
