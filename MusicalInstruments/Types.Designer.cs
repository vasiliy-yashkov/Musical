namespace MusicalInstruments
{
    partial class Types
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Types));
            this.m_TYPEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.m_TYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.m_TYPEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.m_TYPEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_TYPETableAdapter = new MusicalInstruments.MusDataSetTableAdapters.M_TYPETableAdapter();
            this.tableAdapterManager = new MusicalInstruments.MusDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.m_TYPEBindingNavigator)).BeginInit();
            this.m_TYPEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_TYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_TYPEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // m_TYPEBindingNavigator
            // 
            this.m_TYPEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_TYPEBindingNavigator.BindingSource = this.m_TYPEBindingSource;
            this.m_TYPEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_TYPEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_TYPEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_TYPEBindingNavigatorSaveItem});
            this.m_TYPEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_TYPEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_TYPEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_TYPEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_TYPEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_TYPEBindingNavigator.Name = "m_TYPEBindingNavigator";
            this.m_TYPEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_TYPEBindingNavigator.Size = new System.Drawing.Size(884, 25);
            this.m_TYPEBindingNavigator.TabIndex = 0;
            this.m_TYPEBindingNavigator.Text = "bindingNavigator1";
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
            // m_TYPEBindingSource
            // 
            this.m_TYPEBindingSource.DataMember = "M_TYPE";
            this.m_TYPEBindingSource.DataSource = this.musDataSet;
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
            // m_TYPEBindingNavigatorSaveItem
            // 
            this.m_TYPEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_TYPEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_TYPEBindingNavigatorSaveItem.Image")));
            this.m_TYPEBindingNavigatorSaveItem.Name = "m_TYPEBindingNavigatorSaveItem";
            this.m_TYPEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.m_TYPEBindingNavigatorSaveItem.Text = "Save Data";
            this.m_TYPEBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_TYPEBindingNavigatorSaveItem_Click);
            // 
            // m_TYPEDataGridView
            // 
            this.m_TYPEDataGridView.AutoGenerateColumns = false;
            this.m_TYPEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_TYPEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.m_TYPEDataGridView.DataSource = this.m_TYPEBindingSource;
            this.m_TYPEDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_TYPEDataGridView.Location = new System.Drawing.Point(0, 25);
            this.m_TYPEDataGridView.Name = "m_TYPEDataGridView";
            this.m_TYPEDataGridView.Size = new System.Drawing.Size(884, 419);
            this.m_TYPEDataGridView.TabIndex = 1;
            this.m_TYPEDataGridView.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.m_TYPEDataGridView_CellValuePushed);
            this.m_TYPEDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.m_TYPEDataGridView_DataError);
            this.m_TYPEDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.m_TYPEDataGridView_RowsAdded);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TYPE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SUB_TYPE";
            this.dataGridViewTextBoxColumn3.HeaderText = "SUB_TYPE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // m_TYPETableAdapter
            // 
            this.m_TYPETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.M_DELIVERYTableAdapter = null;
            this.tableAdapterManager.M_INSTRUMENTTableAdapter = null;
            this.tableAdapterManager.M_MANUFACTURERTableAdapter = null;
            this.tableAdapterManager.M_MARKTableAdapter = null;
            this.tableAdapterManager.M_SALETableAdapter = null;
            this.tableAdapterManager.M_STORAGE_DELIVERYTableAdapter = null;
            this.tableAdapterManager.M_STORAGETableAdapter = null;
            this.tableAdapterManager.M_TYPETableAdapter = this.m_TYPETableAdapter;
            this.tableAdapterManager.UpdateOrder = MusicalInstruments.MusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 444);
            this.Controls.Add(this.m_TYPEDataGridView);
            this.Controls.Add(this.m_TYPEBindingNavigator);
            this.Name = "Types";
            this.Text = "Типы музыкальных инструментов";
            this.Load += new System.EventHandler(this.Types_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_TYPEBindingNavigator)).EndInit();
            this.m_TYPEBindingNavigator.ResumeLayout(false);
            this.m_TYPEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_TYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_TYPEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MusDataSet musDataSet;
        private System.Windows.Forms.BindingSource m_TYPEBindingSource;
        private MusDataSetTableAdapters.M_TYPETableAdapter m_TYPETableAdapter;
        private MusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_TYPEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_TYPEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView m_TYPEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}