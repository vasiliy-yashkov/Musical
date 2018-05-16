namespace MusicalInstruments
{
    partial class Accessories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accessories));
            this.musDataSet = new MusicalInstruments.MusDataSet();
            this.m_ACCESSORIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_ACCESSORIESTableAdapter = new MusicalInstruments.MusDataSetTableAdapters.M_ACCESSORIESTableAdapter();
            this.tableAdapterManager = new MusicalInstruments.MusDataSetTableAdapters.TableAdapterManager();
            this.m_ACCESSORIESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.m_ACCESSORIESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.m_ACCESSORIESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.AddImageColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.musDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ACCESSORIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ACCESSORIESBindingNavigator)).BeginInit();
            this.m_ACCESSORIESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_ACCESSORIESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // musDataSet
            // 
            this.musDataSet.DataSetName = "MusDataSet";
            this.musDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_ACCESSORIESBindingSource
            // 
            this.m_ACCESSORIESBindingSource.DataMember = "M_ACCESSORIES";
            this.m_ACCESSORIESBindingSource.DataSource = this.musDataSet;
            // 
            // m_ACCESSORIESTableAdapter
            // 
            this.m_ACCESSORIESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.M_ACCESSORIESTableAdapter = this.m_ACCESSORIESTableAdapter;
            this.tableAdapterManager.M_DELIVERYTableAdapter = null;
            this.tableAdapterManager.M_INSTRUMENTTableAdapter = null;
            this.tableAdapterManager.M_MANUFACTURERTableAdapter = null;
            this.tableAdapterManager.M_MARKTableAdapter = null;
            this.tableAdapterManager.M_SALETableAdapter = null;
            this.tableAdapterManager.M_SELLERTableAdapter = null;
            this.tableAdapterManager.M_STORAGE_DELIVERYTableAdapter = null;
            this.tableAdapterManager.M_STORAGETableAdapter = null;
            this.tableAdapterManager.M_TYPETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MusicalInstruments.MusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m_ACCESSORIESBindingNavigator
            // 
            this.m_ACCESSORIESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_ACCESSORIESBindingNavigator.BindingSource = this.m_ACCESSORIESBindingSource;
            this.m_ACCESSORIESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_ACCESSORIESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_ACCESSORIESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_ACCESSORIESBindingNavigatorSaveItem});
            this.m_ACCESSORIESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_ACCESSORIESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_ACCESSORIESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_ACCESSORIESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_ACCESSORIESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_ACCESSORIESBindingNavigator.Name = "m_ACCESSORIESBindingNavigator";
            this.m_ACCESSORIESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_ACCESSORIESBindingNavigator.Size = new System.Drawing.Size(704, 25);
            this.m_ACCESSORIESBindingNavigator.TabIndex = 0;
            this.m_ACCESSORIESBindingNavigator.Text = "bindingNavigator1";
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
            // m_ACCESSORIESBindingNavigatorSaveItem
            // 
            this.m_ACCESSORIESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_ACCESSORIESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_ACCESSORIESBindingNavigatorSaveItem.Image")));
            this.m_ACCESSORIESBindingNavigatorSaveItem.Name = "m_ACCESSORIESBindingNavigatorSaveItem";
            this.m_ACCESSORIESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.m_ACCESSORIESBindingNavigatorSaveItem.Text = "Save Data";
            this.m_ACCESSORIESBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_ACCESSORIESBindingNavigatorSaveItem_Click);
            // 
            // m_ACCESSORIESDataGridView
            // 
            this.m_ACCESSORIESDataGridView.AutoGenerateColumns = false;
            this.m_ACCESSORIESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_ACCESSORIESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1,
            this.AddImageColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.m_ACCESSORIESDataGridView.DataSource = this.m_ACCESSORIESBindingSource;
            this.m_ACCESSORIESDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_ACCESSORIESDataGridView.Location = new System.Drawing.Point(0, 25);
            this.m_ACCESSORIESDataGridView.Name = "m_ACCESSORIESDataGridView";
            this.m_ACCESSORIESDataGridView.RowTemplate.Height = 64;
            this.m_ACCESSORIESDataGridView.Size = new System.Drawing.Size(704, 416);
            this.m_ACCESSORIESDataGridView.TabIndex = 1;
            this.m_ACCESSORIESDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_ACCESSORIESDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ACC_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ACC_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ACC_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "ACC_IMAGE";
            this.dataGridViewImageColumn1.HeaderText = "Изображение";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 250;
            // 
            // AddImageColumn
            // 
            this.AddImageColumn.HeaderText = "Загрузить изображение";
            this.AddImageColumn.Name = "AddImageColumn";
            this.AddImageColumn.Text = "Открыть";
            this.AddImageColumn.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ACC_PRICE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена (руб.)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ACC_TAGS";
            this.dataGridViewTextBoxColumn4.HeaderText = "Совместимые инструменты";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // Accessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.m_ACCESSORIESDataGridView);
            this.Controls.Add(this.m_ACCESSORIESBindingNavigator);
            this.Name = "Accessories";
            this.Text = "Аксессуары";
            this.Load += new System.EventHandler(this.Accessories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ACCESSORIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ACCESSORIESBindingNavigator)).EndInit();
            this.m_ACCESSORIESBindingNavigator.ResumeLayout(false);
            this.m_ACCESSORIESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_ACCESSORIESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MusDataSet musDataSet;
        private System.Windows.Forms.BindingSource m_ACCESSORIESBindingSource;
        private MusDataSetTableAdapters.M_ACCESSORIESTableAdapter m_ACCESSORIESTableAdapter;
        private MusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_ACCESSORIESBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_ACCESSORIESBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView m_ACCESSORIESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn AddImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}