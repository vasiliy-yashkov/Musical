﻿namespace MusicalInstruments
{
    partial class SaleReport
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
            this.rdlViewer1 = new fyiReporting.RdlViewer.RdlViewer();
            this.viewerToolstrip1 = new fyiReporting.RdlViewer.ViewerToolstrip();
            this.SuspendLayout();
            // 
            // rdlViewer1
            // 
            this.rdlViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rdlViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdlViewer1.dSubReportGetContent = null;
            this.rdlViewer1.Folder = null;
            this.rdlViewer1.HighlightAll = false;
            this.rdlViewer1.HighlightAllColor = System.Drawing.Color.Fuchsia;
            this.rdlViewer1.HighlightCaseSensitive = false;
            this.rdlViewer1.HighlightItemColor = System.Drawing.Color.Aqua;
            this.rdlViewer1.HighlightPageItem = null;
            this.rdlViewer1.HighlightText = null;
            this.rdlViewer1.Location = new System.Drawing.Point(0, 28);
            this.rdlViewer1.Name = "rdlViewer1";
            this.rdlViewer1.PageCurrent = 1;
            this.rdlViewer1.Parameters = "";
            this.rdlViewer1.ReportName = null;
            this.rdlViewer1.ScrollMode = fyiReporting.RdlViewer.ScrollModeEnum.Continuous;
            this.rdlViewer1.SelectTool = false;
            this.rdlViewer1.ShowFindPanel = false;
            this.rdlViewer1.ShowParameterPanel = false;
            this.rdlViewer1.ShowWaitDialog = true;
            this.rdlViewer1.Size = new System.Drawing.Size(833, 657);
            this.rdlViewer1.SourceFile = null;
            this.rdlViewer1.SourceRdl = null;
            this.rdlViewer1.TabIndex = 0;
            this.rdlViewer1.UseTrueMargins = true;
            this.rdlViewer1.Zoom = 0.9684689F;
            this.rdlViewer1.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.FitWidth;
            // 
            // viewerToolstrip1
            // 
            this.viewerToolstrip1.Location = new System.Drawing.Point(0, 0);
            this.viewerToolstrip1.Name = "viewerToolstrip1";
            this.viewerToolstrip1.Size = new System.Drawing.Size(833, 25);
            this.viewerToolstrip1.TabIndex = 1;
            this.viewerToolstrip1.Text = "viewerToolstrip1";
            this.viewerToolstrip1.Viewer = this.rdlViewer1;
            // 
            // SaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 686);
            this.Controls.Add(this.viewerToolstrip1);
            this.Controls.Add(this.rdlViewer1);
            this.Name = "SaleReport";
            this.Text = "Отчет о продаже";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private fyiReporting.RdlViewer.RdlViewer rdlViewer1;
        private fyiReporting.RdlViewer.ViewerToolstrip viewerToolstrip1;
    }
}