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
    public partial class Marks : Form
    {
        public Marks()
        {
            InitializeComponent();
        }

        private void m_MARKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.m_MARKBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.musDataSet);
            }
            catch (Exception ex)
            {
                MessageBoxWithDetails message = new MessageBoxWithDetails("Пожалуйста, проверьте корректность введенных данных!",
                    "Ошибка", ex.Message);
                message.ShowDialog();
            }
        }

        private void Marks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musDataSet.M_MANUFACTURER' table. You can move, or remove it, as needed.
            this.m_MANUFACTURERTableAdapter.Fill(this.musDataSet.M_MANUFACTURER);
            // TODO: This line of code loads data into the 'musDataSet.M_MARK' table. You can move, or remove it, as needed.
            this.m_MARKTableAdapter.Fill(this.musDataSet.M_MARK);

        }

        private void m_MARKDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBoxWithDetails message = new MessageBoxWithDetails("Пожалуйста, проверьте корректность введенных данных!",
                "Ошибка", e.Exception.Message);
            message.ShowDialog();
        }
    }
}
