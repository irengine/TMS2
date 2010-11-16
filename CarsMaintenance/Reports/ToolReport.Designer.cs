namespace CarsMaintenance.Reports
{
    partial class ToolReport
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
            this.ToolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnQuery = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ToolName = new System.Windows.Forms.MaskedTextBox();
            this.ToolCode = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ToolDataSetBindingSource)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolDataSetBindingSource
            // 
            this.ToolDataSetBindingSource.DataMember = "ToolDataSet";
            this.ToolDataSetBindingSource.DataSource = typeof(CarsMaintenance.Reports.ToolDataSet);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(359, 19);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelSearch, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.reportViewer1, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(876, 266);
            this.tableLayoutPanelMain.TabIndex = 6;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.ToolCode);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.ToolName);
            this.panelSearch.Controls.Add(this.btnQuery);
            this.panelSearch.Controls.Add(this.lblDate);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(3, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(870, 54);
            this.panelSearch.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(17, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(29, 12);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "名称";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ToolDataSet";
            reportDataSource1.Value = this.ToolDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CarsMaintenance.Reports.ToolReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(870, 200);
            this.reportViewer1.TabIndex = 1;
            // 
            // ToolName
            // 
            this.ToolName.Location = new System.Drawing.Point(67, 19);
            this.ToolName.Name = "ToolName";
            this.ToolName.Size = new System.Drawing.Size(100, 21);
            this.ToolName.TabIndex = 8;
            // 
            // ToolCode
            // 
            this.ToolCode.Location = new System.Drawing.Point(225, 19);
            this.ToolCode.Name = "ToolCode";
            this.ToolCode.Size = new System.Drawing.Size(100, 21);
            this.ToolCode.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "编号";
            // 
            // ToolReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 266);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "ToolReport";
            this.Text = "工属具明细表";
            this.Load += new System.EventHandler(this.ToolReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToolDataSetBindingSource)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblDate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ToolDataSetBindingSource;
        private System.Windows.Forms.MaskedTextBox ToolCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox ToolName;
    }
}