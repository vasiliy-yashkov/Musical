namespace MusicalInstruments
{
    partial class Manufacturers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manufacturers));
            this.musDataSet = new MusicalInstruments.MusDataSet();
            this.m_MANUFACTURERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_MANUFACTURERTableAdapter = new MusicalInstruments.MusDataSetTableAdapters.M_MANUFACTURERTableAdapter();
            this.tableAdapterManager = new MusicalInstruments.MusDataSetTableAdapters.TableAdapterManager();
            this.m_MANUFACTURERBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.m_MANUFACTURERBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.m_MANUFACTURERDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.musDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MANUFACTURERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MANUFACTURERBindingNavigator)).BeginInit();
            this.m_MANUFACTURERBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_MANUFACTURERDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // musDataSet
            // 
            this.musDataSet.DataSetName = "MusDataSet";
            this.musDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_MANUFACTURERBindingSource
            // 
            this.m_MANUFACTURERBindingSource.DataMember = "M_MANUFACTURER";
            this.m_MANUFACTURERBindingSource.DataSource = this.musDataSet;
            // 
            // m_MANUFACTURERTableAdapter
            // 
            this.m_MANUFACTURERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.M_DELIVERYTableAdapter = null;
            this.tableAdapterManager.M_INSTRUMENTTableAdapter = null;
            this.tableAdapterManager.M_MANUFACTURERTableAdapter = this.m_MANUFACTURERTableAdapter;
            this.tableAdapterManager.M_MARKTableAdapter = null;
            this.tableAdapterManager.M_SALETableAdapter = null;
            this.tableAdapterManager.M_STORAGE_DELIVERYTableAdapter = null;
            this.tableAdapterManager.M_STORAGETableAdapter = null;
            this.tableAdapterManager.M_TYPETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MusicalInstruments.MusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m_MANUFACTURERBindingNavigator
            // 
            this.m_MANUFACTURERBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_MANUFACTURERBindingNavigator.BindingSource = this.m_MANUFACTURERBindingSource;
            this.m_MANUFACTURERBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_MANUFACTURERBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_MANUFACTURERBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_MANUFACTURERBindingNavigatorSaveItem});
            this.m_MANUFACTURERBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_MANUFACTURERBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_MANUFACTURERBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_MANUFACTURERBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_MANUFACTURERBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_MANUFACTURERBindingNavigator.Name = "m_MANUFACTURERBindingNavigator";
            this.m_MANUFACTURERBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_MANUFACTURERBindingNavigator.Size = new System.Drawing.Size(739, 25);
            this.m_MANUFACTURERBindingNavigator.TabIndex = 0;
            this.m_MANUFACTURERBindingNavigator.Text = "bindingNavigator1";
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
            // m_MANUFACTURERBindingNavigatorSaveItem
            // 
            this.m_MANUFACTURERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_MANUFACTURERBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_MANUFACTURERBindingNavigatorSaveItem.Image")));
            this.m_MANUFACTURERBindingNavigatorSaveItem.Name = "m_MANUFACTURERBindingNavigatorSaveItem";
            this.m_MANUFACTURERBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.m_MANUFACTURERBindingNavigatorSaveItem.Text = "Save Data";
            this.m_MANUFACTURERBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_MANUFACTURERBindingNavigatorSaveItem_Click);
            // 
            // m_MANUFACTURERDataGridView
            // 
            this.m_MANUFACTURERDataGridView.AutoGenerateColumns = false;
            this.m_MANUFACTURERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_MANUFACTURERDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.m_MANUFACTURERDataGridView.DataSource = this.m_MANUFACTURERBindingSource;
            this.m_MANUFACTURERDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_MANUFACTURERDataGridView.Location = new System.Drawing.Point(0, 25);
            this.m_MANUFACTURERDataGridView.Name = "m_MANUFACTURERDataGridView";
            this.m_MANUFACTURERDataGridView.Size = new System.Drawing.Size(739, 347);
            this.m_MANUFACTURERDataGridView.TabIndex = 1;
            this.m_MANUFACTURERDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.m_MANUFACTURERDataGridView_DataError);
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
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // Manufacturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 372);
            this.Controls.Add(this.m_MANUFACTURERDataGridView);
            this.Controls.Add(this.m_MANUFACTURERBindingNavigator);
            this.Name = "Manufacturers";
            this.Text = "Производители музыкальных инструментов";
            this.Load += new System.EventHandler(this.Manufacturers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MANUFACTURERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MANUFACTURERBindingNavigator)).EndInit();
            this.m_MANUFACTURERBindingNavigator.ResumeLayout(false);
            this.m_MANUFACTURERBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_MANUFACTURERDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MusDataSet musDataSet;
        private System.Windows.Forms.BindingSource m_MANUFACTURERBindingSource;
        private MusDataSetTableAdapters.M_MANUFACTURERTableAdapter m_MANUFACTURERTableAdapter;
        private MusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_MANUFACTURERBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_MANUFACTURERBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView m_MANUFACTURERDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}