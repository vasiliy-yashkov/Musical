namespace MusicalInstruments
{
    partial class Instruments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instruments));
            this.m_INSTRUMENTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.m_INSTRUMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musDataSet = new MusicalInstruments.MusDataSet();
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
            this.m_INSTRUMENTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.m_INSTRUMENTDataGridView = new DataGridViewExtended.DataGridViewExtended();
            this.mMARKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_INSTRUMENTTableAdapter = new MusicalInstruments.MusDataSetTableAdapters.M_INSTRUMENTTableAdapter();
            this.tableAdapterManager = new MusicalInstruments.MusDataSetTableAdapters.TableAdapterManager();
            this.m_MARKTableAdapter = new MusicalInstruments.MusDataSetTableAdapters.M_MARKTableAdapter();
            this.m_TYPETableAdapter = new MusicalInstruments.MusDataSetTableAdapters.M_TYPETableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_INSTRUMENTBindingNavigator)).BeginInit();
            this.m_INSTRUMENTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_INSTRUMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_INSTRUMENTDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMARKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTYPEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // m_INSTRUMENTBindingNavigator
            // 
            this.m_INSTRUMENTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_INSTRUMENTBindingNavigator.BindingSource = this.m_INSTRUMENTBindingSource;
            this.m_INSTRUMENTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_INSTRUMENTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_INSTRUMENTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_INSTRUMENTBindingNavigatorSaveItem});
            this.m_INSTRUMENTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_INSTRUMENTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_INSTRUMENTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_INSTRUMENTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_INSTRUMENTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_INSTRUMENTBindingNavigator.Name = "m_INSTRUMENTBindingNavigator";
            this.m_INSTRUMENTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_INSTRUMENTBindingNavigator.Size = new System.Drawing.Size(1065, 25);
            this.m_INSTRUMENTBindingNavigator.TabIndex = 0;
            this.m_INSTRUMENTBindingNavigator.Text = "bindingNavigator1";
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
            // m_INSTRUMENTBindingSource
            // 
            this.m_INSTRUMENTBindingSource.DataMember = "M_INSTRUMENT";
            this.m_INSTRUMENTBindingSource.DataSource = this.musDataSet;
            // 
            // musDataSet
            // 
            this.musDataSet.DataSetName = "MusDataSet";
            this.musDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // m_INSTRUMENTBindingNavigatorSaveItem
            // 
            this.m_INSTRUMENTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_INSTRUMENTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_INSTRUMENTBindingNavigatorSaveItem.Image")));
            this.m_INSTRUMENTBindingNavigatorSaveItem.Name = "m_INSTRUMENTBindingNavigatorSaveItem";
            this.m_INSTRUMENTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.m_INSTRUMENTBindingNavigatorSaveItem.Text = "Save Data";
            this.m_INSTRUMENTBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_INSTRUMENTBindingNavigatorSaveItem_Click);
            // 
            // m_INSTRUMENTDataGridView
            // 
            this.m_INSTRUMENTDataGridView.AutoGenerateColumns = false;
            this.m_INSTRUMENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_INSTRUMENTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.PRICE});
            this.m_INSTRUMENTDataGridView.DataSource = this.m_INSTRUMENTBindingSource;
            this.m_INSTRUMENTDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_INSTRUMENTDataGridView.Location = new System.Drawing.Point(0, 25);
            this.m_INSTRUMENTDataGridView.Name = "m_INSTRUMENTDataGridView";
            this.m_INSTRUMENTDataGridView.Size = new System.Drawing.Size(1065, 440);
            this.m_INSTRUMENTDataGridView.TabIndex = 1;
            this.m_INSTRUMENTDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.m_INSTRUMENTDataGridView_DataError);
            // 
            // mMARKBindingSource
            // 
            this.mMARKBindingSource.DataMember = "M_MARK";
            this.mMARKBindingSource.DataSource = this.musDataSet;
            // 
            // mTYPEBindingSource
            // 
            this.mTYPEBindingSource.DataMember = "M_TYPE";
            this.mTYPEBindingSource.DataSource = this.musDataSet;
            // 
            // m_INSTRUMENTTableAdapter
            // 
            this.m_INSTRUMENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.M_DELIVERYTableAdapter = null;
            this.tableAdapterManager.M_INSTRUMENTTableAdapter = this.m_INSTRUMENTTableAdapter;
            this.tableAdapterManager.M_MANUFACTURERTableAdapter = null;
            this.tableAdapterManager.M_MARKTableAdapter = this.m_MARKTableAdapter;
            this.tableAdapterManager.M_SALETableAdapter = null;
            this.tableAdapterManager.M_SELLERTableAdapter = null;
            this.tableAdapterManager.M_STORAGE_DELIVERYTableAdapter = null;
            this.tableAdapterManager.M_STORAGETableAdapter = null;
            this.tableAdapterManager.M_TYPETableAdapter = this.m_TYPETableAdapter;
            this.tableAdapterManager.UpdateOrder = MusicalInstruments.MusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m_MARKTableAdapter
            // 
            this.m_MARKTableAdapter.ClearBeforeFill = true;
            // 
            // m_TYPETableAdapter
            // 
            this.m_TYPETableAdapter.ClearBeforeFill = true;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "INFO";
            this.dataGridViewTextBoxColumn3.HeaderText = "Информация";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MARK_ID";
            this.dataGridViewTextBoxColumn4.DataSource = this.mMARKBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "NAME";
            this.dataGridViewTextBoxColumn4.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "ID";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TYPE_ID";
            this.dataGridViewTextBoxColumn5.DataSource = this.mTYPEBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "TYPE";
            this.dataGridViewTextBoxColumn5.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "ID";
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // PRICE
            // 
            this.PRICE.DataPropertyName = "PRICE";
            this.PRICE.HeaderText = "Цена";
            this.PRICE.Name = "PRICE";
            // 
            // Instruments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 465);
            this.Controls.Add(this.m_INSTRUMENTDataGridView);
            this.Controls.Add(this.m_INSTRUMENTBindingNavigator);
            this.Name = "Instruments";
            this.Text = "Музыкальные инструменты";
            this.Load += new System.EventHandler(this.Instruments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_INSTRUMENTBindingNavigator)).EndInit();
            this.m_INSTRUMENTBindingNavigator.ResumeLayout(false);
            this.m_INSTRUMENTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_INSTRUMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_INSTRUMENTDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMARKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTYPEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MusDataSet musDataSet;
        private System.Windows.Forms.BindingSource m_INSTRUMENTBindingSource;
        private MusDataSetTableAdapters.M_INSTRUMENTTableAdapter m_INSTRUMENTTableAdapter;
        private MusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_INSTRUMENTBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_INSTRUMENTBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView m_INSTRUMENTDataGridView;
        private MusDataSetTableAdapters.M_MARKTableAdapter m_MARKTableAdapter;
        private System.Windows.Forms.BindingSource mMARKBindingSource;
        private MusDataSetTableAdapters.M_TYPETableAdapter m_TYPETableAdapter;
        private System.Windows.Forms.BindingSource mTYPEBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
    }
}