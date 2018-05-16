namespace MusicalInstruments
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manufacturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableInstrumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentsSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tunerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.objectsToolStripMenuItem,
            this.controlToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.instrumentsSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.systemToolStripMenuItem.Text = "Система";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // objectsToolStripMenuItem
            // 
            this.objectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typesToolStripMenuItem,
            this.instrumentsToolStripMenuItem,
            this.marksToolStripMenuItem,
            this.manufacturersToolStripMenuItem,
            this.sellersToolStripMenuItem,
            this.accessoriesToolStripMenuItem});
            this.objectsToolStripMenuItem.Name = "objectsToolStripMenuItem";
            this.objectsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.objectsToolStripMenuItem.Text = "Объекты";
            // 
            // typesToolStripMenuItem
            // 
            this.typesToolStripMenuItem.Name = "typesToolStripMenuItem";
            this.typesToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.typesToolStripMenuItem.Text = "Типы инструментов";
            this.typesToolStripMenuItem.Click += new System.EventHandler(this.typesToolStripMenuItem_Click);
            // 
            // instrumentsToolStripMenuItem
            // 
            this.instrumentsToolStripMenuItem.Name = "instrumentsToolStripMenuItem";
            this.instrumentsToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.instrumentsToolStripMenuItem.Text = "Инструменты";
            this.instrumentsToolStripMenuItem.Click += new System.EventHandler(this.instrumentsToolStripMenuItem_Click);
            // 
            // marksToolStripMenuItem
            // 
            this.marksToolStripMenuItem.Name = "marksToolStripMenuItem";
            this.marksToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.marksToolStripMenuItem.Text = "Марки инструментов";
            this.marksToolStripMenuItem.Click += new System.EventHandler(this.marksToolStripMenuItem_Click);
            // 
            // manufacturersToolStripMenuItem
            // 
            this.manufacturersToolStripMenuItem.Name = "manufacturersToolStripMenuItem";
            this.manufacturersToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.manufacturersToolStripMenuItem.Text = "Производители инструментов";
            this.manufacturersToolStripMenuItem.Click += new System.EventHandler(this.manufacturersToolStripMenuItem_Click);
            // 
            // sellersToolStripMenuItem
            // 
            this.sellersToolStripMenuItem.Name = "sellersToolStripMenuItem";
            this.sellersToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.sellersToolStripMenuItem.Text = "Продавцы";
            this.sellersToolStripMenuItem.Click += new System.EventHandler(this.sellersToolStripMenuItem_Click);
            // 
            // accessoriesToolStripMenuItem
            // 
            this.accessoriesToolStripMenuItem.Name = "accessoriesToolStripMenuItem";
            this.accessoriesToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.accessoriesToolStripMenuItem.Text = "Аксессуары";
            this.accessoriesToolStripMenuItem.Click += new System.EventHandler(this.accessoriesToolStripMenuItem_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deliveriesToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.availableInstrumentsToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.controlToolStripMenuItem.Text = "Управление";
            // 
            // deliveriesToolStripMenuItem
            // 
            this.deliveriesToolStripMenuItem.Name = "deliveriesToolStripMenuItem";
            this.deliveriesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.deliveriesToolStripMenuItem.Text = "Поставки инструментов";
            this.deliveriesToolStripMenuItem.Click += new System.EventHandler(this.deliveriesToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.salesToolStripMenuItem.Text = "Продажа инструментов";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // availableInstrumentsToolStripMenuItem
            // 
            this.availableInstrumentsToolStripMenuItem.Name = "availableInstrumentsToolStripMenuItem";
            this.availableInstrumentsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.availableInstrumentsToolStripMenuItem.Text = "Наличие";
            this.availableInstrumentsToolStripMenuItem.Click += new System.EventHandler(this.availableInstrumentsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.designerToolStripMenuItem,
            this.deliveryReportsToolStripMenuItem,
            this.saleReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reportsToolStripMenuItem.Text = "Отчеты";
            // 
            // designerToolStripMenuItem
            // 
            this.designerToolStripMenuItem.Name = "designerToolStripMenuItem";
            this.designerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.designerToolStripMenuItem.Text = "Дизайнер отчетов";
            this.designerToolStripMenuItem.Click += new System.EventHandler(this.designerToolStripMenuItem_Click);
            // 
            // deliveryReportsToolStripMenuItem
            // 
            this.deliveryReportsToolStripMenuItem.Name = "deliveryReportsToolStripMenuItem";
            this.deliveryReportsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.deliveryReportsToolStripMenuItem.Text = "Отчеты по доставке";
            this.deliveryReportsToolStripMenuItem.Click += new System.EventHandler(this.deliveryReportsToolStripMenuItem_Click);
            // 
            // saleReportsToolStripMenuItem
            // 
            this.saleReportsToolStripMenuItem.Name = "saleReportsToolStripMenuItem";
            this.saleReportsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saleReportsToolStripMenuItem.Text = "Отчеты по продажам";
            this.saleReportsToolStripMenuItem.Click += new System.EventHandler(this.saleReportsToolStripMenuItem_Click);
            // 
            // instrumentsSettingsToolStripMenuItem
            // 
            this.instrumentsSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tunerToolStripMenuItem});
            this.instrumentsSettingsToolStripMenuItem.Name = "instrumentsSettingsToolStripMenuItem";
            this.instrumentsSettingsToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.instrumentsSettingsToolStripMenuItem.Text = "Настройка инструментов";
            // 
            // tunerToolStripMenuItem
            // 
            this.tunerToolStripMenuItem.Name = "tunerToolStripMenuItem";
            this.tunerToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.tunerToolStripMenuItem.Text = " Частотная настройка";
            this.tunerToolStripMenuItem.Click += new System.EventHandler(this.tunerToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(704, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connectionLabel
            // 
            this.connectionLabel.Image = global::MusicalInstruments.Properties.Resources.error;
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(62, 17);
            this.connectionLabel.Text = "Статус:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИС \"Музыкальные инструменты\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connectionLabel;
        private System.Windows.Forms.ToolStripMenuItem designerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manufacturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availableInstrumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentsSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tunerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessoriesToolStripMenuItem;
    }
}

