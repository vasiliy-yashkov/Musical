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
    public partial class Sellers : Form
    {
        public Sellers ()
        {
            InitializeComponent();
        }

        private void m_SELLERBindingNavigatorSaveItem_Click (object sender, EventArgs e)
        {
            this.Validate();
            this.m_SELLERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musDataSet);

        }

        private void Sellers_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musDataSet.M_SELLER' table. You can move, or remove it, as needed.
            this.m_SELLERTableAdapter.Fill(this.musDataSet.M_SELLER);

        }
    }
}
