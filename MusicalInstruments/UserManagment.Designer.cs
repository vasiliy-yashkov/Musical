namespace MusicalInstruments
{
    partial class UserManagment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagment));
            this.m_USERSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteRowButton = new System.Windows.Forms.ToolStripButton();
            this.m_USERSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.m_USERSDataGridView = new System.Windows.Forms.DataGridView();
            this.mROLESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.musDataSet = new MusicalInstruments.MusDataSet();
            this.m_USERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mROLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_USERSTableAdapter = new MusicalInstruments.MusDataSetTableAdapters.M_USERSTableAdapter();
            this.tableAdapterManager = new MusicalInstruments.MusDataSetTableAdapters.TableAdapterManager();
            this.m_ROLESTableAdapter = new MusicalInstruments.MusDataSetTableAdapters.M_ROLESTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_USERSBindingNavigator)).BeginInit();
            this.m_USERSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_USERSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mROLESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_USERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mROLESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // m_USERSBindingNavigator
            // 
            this.m_USERSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_USERSBindingNavigator.BindingSource = this.m_USERSBindingSource;
            this.m_USERSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_USERSBindingNavigator.DeleteItem = null;
            this.m_USERSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.deleteRowButton,
            this.m_USERSBindingNavigatorSaveItem});
            this.m_USERSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_USERSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_USERSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_USERSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_USERSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_USERSBindingNavigator.Name = "m_USERSBindingNavigator";
            this.m_USERSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_USERSBindingNavigator.Size = new System.Drawing.Size(624, 25);
            this.m_USERSBindingNavigator.TabIndex = 0;
            this.m_USERSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // deleteRowButton
            // 
            this.deleteRowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteRowButton.Image = global::MusicalInstruments.Properties.Resources.error;
            this.deleteRowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteRowButton.Name = "deleteRowButton";
            this.deleteRowButton.Size = new System.Drawing.Size(23, 22);
            this.deleteRowButton.Text = "toolStripButton1";
            this.deleteRowButton.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // m_USERSBindingNavigatorSaveItem
            // 
            this.m_USERSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_USERSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_USERSBindingNavigatorSaveItem.Image")));
            this.m_USERSBindingNavigatorSaveItem.Name = "m_USERSBindingNavigatorSaveItem";
            this.m_USERSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.m_USERSBindingNavigatorSaveItem.Text = "Save Data";
            this.m_USERSBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_USERSBindingNavigatorSaveItem_Click);
            // 
            // m_USERSDataGridView
            // 
            this.m_USERSDataGridView.AllowUserToAddRows = false;
            this.m_USERSDataGridView.AllowUserToDeleteRows = false;
            this.m_USERSDataGridView.AutoGenerateColumns = false;
            this.m_USERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_USERSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.m_USERSDataGridView.DataSource = this.m_USERSBindingSource;
            this.m_USERSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_USERSDataGridView.Location = new System.Drawing.Point(0, 25);
            this.m_USERSDataGridView.Name = "m_USERSDataGridView";
            this.m_USERSDataGridView.RowHeadersVisible = false;
            this.m_USERSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.m_USERSDataGridView.Size = new System.Drawing.Size(624, 416);
            this.m_USERSDataGridView.TabIndex = 1;
            this.m_USERSDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_USERSDataGridView_CellClick);
            // 
            // mROLESBindingSource1
            // 
            this.mROLESBindingSource1.DataMember = "M_ROLES";
            this.mROLESBindingSource1.DataSource = this.musDataSet;
            // 
            // musDataSet
            // 
            this.musDataSet.DataSetName = "MusDataSet";
            this.musDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_USERSBindingSource
            // 
            this.m_USERSBindingSource.DataMember = "M_USERS";
            this.m_USERSBindingSource.DataSource = this.musDataSet;
            // 
            // mROLESBindingSource
            // 
            this.mROLESBindingSource.DataMember = "M_ROLES";
            this.mROLESBindingSource.DataSource = this.musDataSet;
            // 
            // m_USERSTableAdapter
            // 
            this.m_USERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.M_ACCESSORIESTableAdapter = null;
            this.tableAdapterManager.M_DELIVERYTableAdapter = null;
            this.tableAdapterManager.M_INSTRUMENTTableAdapter = null;
            this.tableAdapterManager.M_MANUFACTURERTableAdapter = null;
            this.tableAdapterManager.M_MARKTableAdapter = null;
            this.tableAdapterManager.M_ROLESTableAdapter = this.m_ROLESTableAdapter;
            this.tableAdapterManager.M_SALETableAdapter = null;
            this.tableAdapterManager.M_SELLERTableAdapter = null;
            this.tableAdapterManager.M_STORAGE_DELIVERYTableAdapter = null;
            this.tableAdapterManager.M_STORAGETableAdapter = null;
            this.tableAdapterManager.M_TYPETableAdapter = null;
            this.tableAdapterManager.M_USERSTableAdapter = this.m_USERSTableAdapter;
            this.tableAdapterManager.UpdateOrder = MusicalInstruments.MusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m_ROLESTableAdapter
            // 
            this.m_ROLESTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "U_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "U_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "U_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя пользователя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "U_ROLE";
            this.dataGridViewTextBoxColumn3.DataSource = this.mROLESBindingSource1;
            this.dataGridViewTextBoxColumn3.DisplayMember = "R_TITLE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Роль";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "R_ID";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // UserManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.m_USERSDataGridView);
            this.Controls.Add(this.m_USERSBindingNavigator);
            this.Name = "UserManagment";
            this.Text = "Управление пользователями";
            this.Load += new System.EventHandler(this.UserManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_USERSBindingNavigator)).EndInit();
            this.m_USERSBindingNavigator.ResumeLayout(false);
            this.m_USERSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_USERSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mROLESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_USERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mROLESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MusDataSet musDataSet;
        private System.Windows.Forms.BindingSource m_USERSBindingSource;
        private MusDataSetTableAdapters.M_USERSTableAdapter m_USERSTableAdapter;
        private MusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_USERSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton m_USERSBindingNavigatorSaveItem;
        private MusDataSetTableAdapters.M_ROLESTableAdapter m_ROLESTableAdapter;
        private System.Windows.Forms.DataGridView m_USERSDataGridView;
        private System.Windows.Forms.BindingSource mROLESBindingSource;
        private System.Windows.Forms.ToolStripButton deleteRowButton;
        private System.Windows.Forms.BindingSource mROLESBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
    }
}