namespace MusicalInstruments
{
    partial class SaleReports
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
            this.viewerToolstrip1 = new fyiReporting.RdlViewer.ViewerToolstrip();
            this.rdlViewer1 = new fyiReporting.RdlViewer.RdlViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Criterion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewerToolstrip1
            // 
            this.viewerToolstrip1.Location = new System.Drawing.Point(0, 0);
            this.viewerToolstrip1.Name = "viewerToolstrip1";
            this.viewerToolstrip1.Size = new System.Drawing.Size(1088, 25);
            this.viewerToolstrip1.TabIndex = 0;
            this.viewerToolstrip1.Text = "viewerToolstrip1";
            this.viewerToolstrip1.Viewer = this.rdlViewer1;
            // 
            // rdlViewer1
            // 
            this.rdlViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdlViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdlViewer1.dSubReportGetContent = null;
            this.rdlViewer1.Folder = null;
            this.rdlViewer1.HighlightAll = false;
            this.rdlViewer1.HighlightAllColor = System.Drawing.Color.Fuchsia;
            this.rdlViewer1.HighlightCaseSensitive = false;
            this.rdlViewer1.HighlightItemColor = System.Drawing.Color.Aqua;
            this.rdlViewer1.HighlightPageItem = null;
            this.rdlViewer1.HighlightText = null;
            this.rdlViewer1.Location = new System.Drawing.Point(12, 28);
            this.rdlViewer1.Name = "rdlViewer1";
            this.rdlViewer1.PageCurrent = 1;
            this.rdlViewer1.Parameters = "";
            this.rdlViewer1.ReportName = null;
            this.rdlViewer1.ScrollMode = fyiReporting.RdlViewer.ScrollModeEnum.Continuous;
            this.rdlViewer1.SelectTool = false;
            this.rdlViewer1.ShowFindPanel = false;
            this.rdlViewer1.ShowParameterPanel = false;
            this.rdlViewer1.ShowWaitDialog = true;
            this.rdlViewer1.Size = new System.Drawing.Size(564, 683);
            this.rdlViewer1.SourceFile = null;
            this.rdlViewer1.SourceRdl = null;
            this.rdlViewer1.TabIndex = 1;
            this.rdlViewer1.UseTrueMargins = true;
            this.rdlViewer1.Zoom = 0.6492065F;
            this.rdlViewer1.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.FitWidth;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnApplyFilter);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(583, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 683);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка фильтров";
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(6, 19);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(75, 23);
            this.btnApplyFilter.TabIndex = 2;
            this.btnApplyFilter.Text = "Применить";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(6, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 629);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.Criterion,
            this.Value});
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 607);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column
            // 
            this.Column.HeaderText = "Столбец";
            this.Column.Items.AddRange(new object[] {
            "Дата продажи",
            "Инструмент",
            "Количество",
            "Продавец",
            "Покупатель",
            "Цена за 1 ед.",
            "Цена"});
            this.Column.Name = "Column";
            // 
            // Criterion
            // 
            this.Criterion.HeaderText = "Критерий";
            this.Criterion.Items.AddRange(new object[] {
            "<",
            "<=",
            "=",
            ">=",
            ">",
            "Содержит"});
            this.Criterion.Name = "Criterion";
            // 
            // Value
            // 
            this.Value.HeaderText = "Значение";
            this.Value.Name = "Value";
            // 
            // SaleReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 723);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdlViewer1);
            this.Controls.Add(this.viewerToolstrip1);
            this.Name = "SaleReports";
            this.Text = "Отчеты по продажам";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private fyiReporting.RdlViewer.ViewerToolstrip viewerToolstrip1;
        private fyiReporting.RdlViewer.RdlViewer rdlViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column;
        private System.Windows.Forms.DataGridViewComboBoxColumn Criterion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}