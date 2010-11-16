namespace CarsMaintenance.Reports
{
    partial class ToolInfoReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ToolInfoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtBeginDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbJobType = new System.Windows.Forms.ComboBox();
            this.cbJobPosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ToolInfoDataSetBindingSource)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolInfoDataSetBindingSource
            // 
            this.ToolInfoDataSetBindingSource.DataMember = "ToolInfoDataset";
            this.ToolInfoDataSetBindingSource.DataSource = typeof(CarsMaintenance.Reports.ToolInfoDataSet);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "ToolInfoDataSe";
            reportDataSource3.Value = this.ToolInfoDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CarsMaintenance.Reports.ToolInfoReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(826, 341);
            this.reportViewer1.TabIndex = 1;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.cbJobPosition);
            this.panelSearch.Controls.Add(this.cbJobType);
            this.panelSearch.Controls.Add(this.label2);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.btnQuery);
            this.panelSearch.Controls.Add(this.dtEndDate);
            this.panelSearch.Controls.Add(this.dtBeginDate);
            this.panelSearch.Controls.Add(this.lblDate);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(3, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(826, 54);
            this.panelSearch.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(742, 18);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(226, 19);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(134, 21);
            this.dtEndDate.TabIndex = 6;
            // 
            // dtBeginDate
            // 
            this.dtBeginDate.Location = new System.Drawing.Point(73, 19);
            this.dtBeginDate.Name = "dtBeginDate";
            this.dtBeginDate.Size = new System.Drawing.Size(134, 21);
            this.dtBeginDate.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(14, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 12);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "日期范围";
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
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(832, 407);
            this.tableLayoutPanelMain.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "作业位置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "外／内货";
            // 
            // cbJobType
            // 
            this.cbJobType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobType.FormattingEnabled = true;
            this.cbJobType.Location = new System.Drawing.Point(617, 20);
            this.cbJobType.Name = "cbJobType";
            this.cbJobType.Size = new System.Drawing.Size(119, 20);
            this.cbJobType.TabIndex = 11;
            // 
            // cbJobPosition
            // 
            this.cbJobPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobPosition.FormattingEnabled = true;
            this.cbJobPosition.Location = new System.Drawing.Point(452, 18);
            this.cbJobPosition.Name = "cbJobPosition";
            this.cbJobPosition.Size = new System.Drawing.Size(101, 20);
            this.cbJobPosition.TabIndex = 12;
            // 
            // ToolInfoReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 407);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "ToolInfoReport";
            this.Text = "工属具报废表";
            this.Load += new System.EventHandler(this.ToolInfoReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToolInfoDataSetBindingSource)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ToolInfoDataSetBindingSource;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtBeginDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbJobType;
        private System.Windows.Forms.ComboBox cbJobPosition;
    }
}