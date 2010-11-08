namespace CarsMaintenance.Reports
{
    partial class BarcodeReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewerBarcode = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ToolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ToolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerBarcode
            // 
            this.reportViewerBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsTool";
            reportDataSource1.Value = this.ToolBindingSource;
            this.reportViewerBarcode.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBarcode.LocalReport.ReportEmbeddedResource = "CarsMaintenance.Reports.BarcodeReport.rdlc";
            this.reportViewerBarcode.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBarcode.Name = "reportViewerBarcode";
            this.reportViewerBarcode.Size = new System.Drawing.Size(284, 262);
            this.reportViewerBarcode.TabIndex = 0;
            // 
            // ToolBindingSource
            // 
            this.ToolBindingSource.DataSource = typeof(TMS.Model.Tool);
            // 
            // BarcodeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewerBarcode);
            this.Name = "BarcodeReport";
            this.Text = "条码本";
            this.Load += new System.EventHandler(this.BarcodeReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToolBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBarcode;
        private System.Windows.Forms.BindingSource ToolBindingSource;
    }
}