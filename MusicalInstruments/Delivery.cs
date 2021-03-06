﻿using System;
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
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }

        private void m_DELIVERYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.m_DELIVERYBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.musDataSet);
            }
            catch (Exception ex)
            {
                MessageBoxWithDetails message = new MessageBoxWithDetails("Пожалуйста, проверьте корректность введенных данных!",
                    "Ошибка", ex.Message);
                message.ShowDialog();
            }

        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musDataSet.M_INSTRUMENT' table. You can move, or remove it, as needed.
            this.m_INSTRUMENTTableAdapter.Fill(this.musDataSet.M_INSTRUMENT);
            // TODO: This line of code loads data into the 'musDataSet.M_DELIVERY' table. You can move, or remove it, as needed.
            this.m_DELIVERYTableAdapter.Fill(this.musDataSet.M_DELIVERY);

        }

        private void m_DELIVERYDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBoxWithDetails message = new MessageBoxWithDetails("Пожалуйста, проверьте корректность введенных данных!",
                "Ошибка", e.Exception.Message);
            message.ShowDialog();
        }
    }
}
