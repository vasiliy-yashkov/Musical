namespace MusicalInstruments
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.musDataSet = new MusicalInstruments.MusDataSet();
            this.mINSTRUMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_INSTRUMENTTableAdapter = new MusicalInstruments.MusDataSetTableAdapters.M_INSTRUMENTTableAdapter();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtEndPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuyer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbInstruments = new System.Windows.Forms.ComboBox();
            this.cmbSeller = new System.Windows.Forms.ComboBox();
            this.mSELLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_SELLERTableAdapter = new MusicalInstruments.MusDataSetTableAdapters.M_SELLERTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.mTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.m_TYPETableAdapter = new MusicalInstruments.MusDataSetTableAdapters.M_TYPETableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_ACCESSORIESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ACCESSORIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.m_ACCESSORIESTableAdapter = new MusicalInstruments.MusDataSetTableAdapters.M_ACCESSORIESTableAdapter();
            this.tableAdapterManager = new MusicalInstruments.MusDataSetTableAdapters.TableAdapterManager();
            this.selectedDataGrid = new DataGridViewExtended.DataGridViewExtended();
            this.AccName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccAllPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAccPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.musDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mINSTRUMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSELLERBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTYPEBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_ACCESSORIESDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ACCESSORIESBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // musDataSet
            // 
            this.musDataSet.DataSetName = "MusDataSet";
            this.musDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mINSTRUMENTBindingSource
            // 
            this.mINSTRUMENTBindingSource.DataMember = "M_INSTRUMENT";
            this.mINSTRUMENTBindingSource.DataSource = this.musDataSet;
            // 
            // m_INSTRUMENTTableAdapter
            // 
            this.m_INSTRUMENTTableAdapter.ClearBeforeFill = true;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(807, 649);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(107, 23);
            this.btnApply.TabIndex = 25;
            this.btnApply.Text = "Оформить заказ";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtEndPrice
            // 
            this.txtEndPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndPrice.Location = new System.Drawing.Point(103, 151);
            this.txtEndPrice.Name = "txtEndPrice";
            this.txtEndPrice.ReadOnly = true;
            this.txtEndPrice.Size = new System.Drawing.Size(790, 20);
            this.txtEndPrice.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Итоговае цена";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Location = new System.Drawing.Point(103, 125);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(790, 20);
            this.txtPrice.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Цена за единицу";
            // 
            // numCount
            // 
            this.numCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCount.Location = new System.Drawing.Point(103, 99);
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(393, 20);
            this.numCount.TabIndex = 20;
            this.numCount.ValueChanged += new System.EventHandler(this.numCount_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Музыкальный инструмент";
            // 
            // txtBuyer
            // 
            this.txtBuyer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuyer.Location = new System.Drawing.Point(85, 46);
            this.txtBuyer.Name = "txtBuyer";
            this.txtBuyer.Size = new System.Drawing.Size(829, 20);
            this.txtBuyer.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Покупатель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Продавец";
            // 
            // cmbInstruments
            // 
            this.cmbInstruments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbInstruments.DataSource = this.mINSTRUMENTBindingSource;
            this.cmbInstruments.DisplayMember = "NAME";
            this.cmbInstruments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstruments.FormattingEnabled = true;
            this.cmbInstruments.Location = new System.Drawing.Point(6, 72);
            this.cmbInstruments.Name = "cmbInstruments";
            this.cmbInstruments.Size = new System.Drawing.Size(887, 21);
            this.cmbInstruments.TabIndex = 13;
            this.cmbInstruments.ValueMember = "ID";
            this.cmbInstruments.SelectedIndexChanged += new System.EventHandler(this.cmbInstruments_SelectedIndexChanged);
            // 
            // cmbSeller
            // 
            this.cmbSeller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSeller.DataSource = this.mSELLERBindingSource;
            this.cmbSeller.DisplayMember = "SELLER_NAME";
            this.cmbSeller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeller.FormattingEnabled = true;
            this.cmbSeller.Location = new System.Drawing.Point(85, 20);
            this.cmbSeller.Name = "cmbSeller";
            this.cmbSeller.Size = new System.Drawing.Size(829, 21);
            this.cmbSeller.TabIndex = 26;
            this.cmbSeller.ValueMember = "ID";
            // 
            // mSELLERBindingSource
            // 
            this.mSELLERBindingSource.DataMember = "M_SELLER";
            this.mSELLERBindingSource.DataSource = this.musDataSet;
            // 
            // m_SELLERTableAdapter
            // 
            this.m_SELLERTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbInstruments);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEndPrice);
            this.groupBox1.Controls.Add(this.numCount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Location = new System.Drawing.Point(15, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 188);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор инструмента";
            // 
            // cmbType
            // 
            this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbType.DataSource = this.mTYPEBindingSource;
            this.cmbType.DisplayMember = "TYPE";
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(6, 32);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(887, 21);
            this.cmbType.TabIndex = 26;
            this.cmbType.ValueMember = "ID";
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // mTYPEBindingSource
            // 
            this.mTYPEBindingSource.DataMember = "M_TYPE";
            this.mTYPEBindingSource.DataSource = this.musDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Тип инструмента";
            // 
            // m_TYPETableAdapter
            // 
            this.m_TYPETableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtAccPrice);
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Location = new System.Drawing.Point(15, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 369);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор комплектующих";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Size = new System.Drawing.Size(893, 315);
            this.splitContainer1.SplitterDistance = 439;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.m_ACCESSORIESDataGridView);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 315);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Доступные комплектующие";
            // 
            // m_ACCESSORIESDataGridView
            // 
            this.m_ACCESSORIESDataGridView.AllowUserToAddRows = false;
            this.m_ACCESSORIESDataGridView.AllowUserToDeleteRows = false;
            this.m_ACCESSORIESDataGridView.AutoGenerateColumns = false;
            this.m_ACCESSORIESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_ACCESSORIESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.m_ACCESSORIESDataGridView.DataSource = this.m_ACCESSORIESBindingSource;
            this.m_ACCESSORIESDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_ACCESSORIESDataGridView.Location = new System.Drawing.Point(3, 16);
            this.m_ACCESSORIESDataGridView.Name = "m_ACCESSORIESDataGridView";
            this.m_ACCESSORIESDataGridView.RowTemplate.Height = 64;
            this.m_ACCESSORIESDataGridView.Size = new System.Drawing.Size(433, 296);
            this.m_ACCESSORIESDataGridView.TabIndex = 0;
            this.m_ACCESSORIESDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_ACCESSORIESDataGridView_CellClick);
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
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "ACC_IMAGE";
            this.dataGridViewImageColumn1.HeaderText = "Изображение";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ACC_PRICE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ACC_TAGS";
            this.dataGridViewTextBoxColumn4.HeaderText = "ACC_TAGS";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // m_ACCESSORIESBindingSource
            // 
            this.m_ACCESSORIESBindingSource.DataMember = "M_ACCESSORIES";
            this.m_ACCESSORIESBindingSource.DataSource = this.musDataSet;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.selectedDataGrid);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 315);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Выбранные комплектующие";
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
            this.tableAdapterManager.M_INSTRUMENTTableAdapter = this.m_INSTRUMENTTableAdapter;
            this.tableAdapterManager.M_MANUFACTURERTableAdapter = null;
            this.tableAdapterManager.M_MARKTableAdapter = null;
            this.tableAdapterManager.M_SALETableAdapter = null;
            this.tableAdapterManager.M_SELLERTableAdapter = this.m_SELLERTableAdapter;
            this.tableAdapterManager.M_STORAGE_DELIVERYTableAdapter = null;
            this.tableAdapterManager.M_STORAGETableAdapter = null;
            this.tableAdapterManager.M_TYPETableAdapter = this.m_TYPETableAdapter;
            this.tableAdapterManager.UpdateOrder = MusicalInstruments.MusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // selectedDataGrid
            // 
            this.selectedDataGrid.AllowUserToAddRows = false;
            this.selectedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccName,
            this.AccPrice,
            this.AccCount,
            this.AccAllPrice});
            this.selectedDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedDataGrid.Location = new System.Drawing.Point(3, 16);
            this.selectedDataGrid.Name = "selectedDataGrid";
            this.selectedDataGrid.Size = new System.Drawing.Size(444, 296);
            this.selectedDataGrid.TabIndex = 0;
            this.selectedDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedDataGrid_CellEndEdit);
            this.selectedDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.selectedDataGrid_RowsAdded);
            this.selectedDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.selectedDataGrid_RowsRemoved);
            // 
            // AccName
            // 
            this.AccName.HeaderText = "Название";
            this.AccName.Name = "AccName";
            this.AccName.ReadOnly = true;
            // 
            // AccPrice
            // 
            this.AccPrice.HeaderText = "Цена за 1 ед.";
            this.AccPrice.Name = "AccPrice";
            this.AccPrice.ReadOnly = true;
            // 
            // AccCount
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.AccCount.DefaultCellStyle = dataGridViewCellStyle3;
            this.AccCount.HeaderText = "Кол-во";
            this.AccCount.Name = "AccCount";
            // 
            // AccAllPrice
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.AccAllPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.AccAllPrice.HeaderText = "Цена";
            this.AccAllPrice.Name = "AccAllPrice";
            this.AccAllPrice.ReadOnly = true;
            // 
            // txtAccPrice
            // 
            this.txtAccPrice.Location = new System.Drawing.Point(149, 337);
            this.txtAccPrice.Name = "txtAccPrice";
            this.txtAccPrice.ReadOnly = true;
            this.txtAccPrice.Size = new System.Drawing.Size(744, 20);
            this.txtAccPrice.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Цена за комплектующие:";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 684);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbSeller);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtBuyer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sales";
            this.Text = "Продажа инструментов";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mINSTRUMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSELLERBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTYPEBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_ACCESSORIESDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ACCESSORIESBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectedDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MusDataSet musDataSet;
        private System.Windows.Forms.BindingSource mINSTRUMENTBindingSource;
        private MusDataSetTableAdapters.M_INSTRUMENTTableAdapter m_INSTRUMENTTableAdapter;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtEndPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuyer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbInstruments;
        private System.Windows.Forms.ComboBox cmbSeller;
        private System.Windows.Forms.BindingSource mSELLERBindingSource;
        private MusDataSetTableAdapters.M_SELLERTableAdapter m_SELLERTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource mTYPEBindingSource;
        private MusDataSetTableAdapters.M_TYPETableAdapter m_TYPETableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource m_ACCESSORIESBindingSource;
        private MusDataSetTableAdapters.M_ACCESSORIESTableAdapter m_ACCESSORIESTableAdapter;
        private MusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView m_ACCESSORIESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView selectedDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccAllPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAccPrice;
    }
}