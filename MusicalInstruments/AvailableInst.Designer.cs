namespace MusicalInstruments
{
    partial class AvailableInst
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableInst));
            this.musDataSet = new MusicalInstruments.MusDataSet();
            this.m_STORAGEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_STORAGETableAdapter = new MusicalInstruments.MusDataSetTableAdapters.M_STORAGETableAdapter();
            this.tableAdapterManager = new MusicalInstruments.MusDataSetTableAdapters.TableAdapterManager();
            this.m_INSTRUMENTTableAdapter = new MusicalInstruments.MusDataSetTableAdapters.M_INSTRUMENTTableAdapter();
            this.m_STORAGEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.m_STORAGEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.m_STORAGEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mINSTRUMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.musDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_STORAGEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_STORAGEBindingNavigator)).BeginInit();
            this.m_STORAGEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_STORAGEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mINSTRUMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // musDataSet
            // 
            this.musDataSet.DataSetName = "MusDataSet";
            this.musDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_STORAGEBindingSource
            // 
            this.m_STORAGEBindingSource.DataMember = "M_STORAGE";
            this.m_STORAGEBindingSource.DataSource = this.musDataSet;
            // 
            // m_STORAGETableAdapter
            // 
            this.m_STORAGETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.M_DELIVERYTableAdapter = null;
            this.tableAdapterManager.M_INSTRUMENTTableAdapter = this.m_INSTRUMENTTableAdapter;
            this.tableAdapterManager.M_MANUFACTURERTableAdapter = null;
            this.tableAdapterManager.M_MARKTableAdapter = null;
            this.tableAdapterManager.M_SALETableAdapter = null;
            this.tableAdapterManager.M_STORAGE_DELIVERYTableAdapter = null;
            this.tableAdapterManager.M_STORAGETableAdapter = this.m_STORAGETableAdapter;
            this.tableAdapterManager.M_TYPETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MusicalInstruments.MusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m_INSTRUMENTTableAdapter
            // 
            this.m_INSTRUMENTTableAdapter.ClearBeforeFill = true;
            // 
            // m_STORAGEBindingNavigator
            // 
            this.m_STORAGEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_STORAGEBindingNavigator.BindingSource = this.m_STORAGEBindingSource;
            this.m_STORAGEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_STORAGEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_STORAGEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.m_STORAGEBindingNavigatorSaveItem});
            this.m_STORAGEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_STORAGEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_STORAGEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_STORAGEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_STORAGEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_STORAGEBindingNavigator.Name = "m_STORAGEBindingNavigator";
            this.m_STORAGEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_STORAGEBindingNavigator.Size = new System.Drawing.Size(754, 25);
            this.m_STORAGEBindingNavigator.TabIndex = 0;
            this.m_STORAGEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // m_STORAGEBindingNavigatorSaveItem
            // 
            this.m_STORAGEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_STORAGEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_STORAGEBindingNavigatorSaveItem.Image")));
            this.m_STORAGEBindingNavigatorSaveItem.Name = "m_STORAGEBindingNavigatorSaveItem";
            this.m_STORAGEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.m_STORAGEBindingNavigatorSaveItem.Text = "Save Data";
            this.m_STORAGEBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_STORAGEBindingNavigatorSaveItem_Click);
            // 
            // m_STORAGEDataGridView
            // 
            this.m_STORAGEDataGridView.AutoGenerateColumns = false;
            this.m_STORAGEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_STORAGEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.m_STORAGEDataGridView.DataSource = this.m_STORAGEBindingSource;
            this.m_STORAGEDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_STORAGEDataGridView.Location = new System.Drawing.Point(0, 25);
            this.m_STORAGEDataGridView.Name = "m_STORAGEDataGridView";
            this.m_STORAGEDataGridView.Size = new System.Drawing.Size(754, 479);
            this.m_STORAGEDataGridView.TabIndex = 1;
            this.m_STORAGEDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.m_STORAGEDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "INSTRUMENT_ID";
            this.dataGridViewTextBoxColumn2.DataSource = this.mINSTRUMENTBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название инструмента";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // mINSTRUMENTBindingSource
            // 
            this.mINSTRUMENTBindingSource.DataMember = "M_INSTRUMENT";
            this.mINSTRUMENTBindingSource.DataSource = this.musDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "COUNT";
            this.dataGridViewTextBoxColumn3.HeaderText = "В наличии";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // AvailableInst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 504);
            this.Controls.Add(this.m_STORAGEDataGridView);
            this.Controls.Add(this.m_STORAGEBindingNavigator);
            this.Name = "AvailableInst";
            this.Text = "Наличие инструментов";
            this.Load += new System.EventHandler(this.AvailableInst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_STORAGEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_STORAGEBindingNavigator)).EndInit();
            this.m_STORAGEBindingNavigator.ResumeLayout(false);
            this.m_STORAGEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_STORAGEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mINSTRUMENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MusDataSet musDataSet;
        private System.Windows.Forms.BindingSource m_STORAGEBindingSource;
        private MusDataSetTableAdapters.M_STORAGETableAdapter m_STORAGETableAdapter;
        private MusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_STORAGEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton m_STORAGEBindingNavigatorSaveItem;
        private MusDataSetTableAdapters.M_INSTRUMENTTableAdapter m_INSTRUMENTTableAdapter;
        private System.Windows.Forms.DataGridView m_STORAGEDataGridView;
        private System.Windows.Forms.BindingSource mINSTRUMENTBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}