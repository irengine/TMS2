namespace CarsMaintenance.OrderManagement
{
    partial class ViewOutboundOrderForm
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
            this.contextMenuStripOutboundOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemBrowseOutboundOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCreateOutboundOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAppendOutboundOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReturnOutboundOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.outboundOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewOutboundOrder = new System.Windows.Forms.DataGridView();
            this.outboundOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outboundDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.berthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hatchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtBeginDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.toolStripMenuItemPrintOutboundOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripOutboundOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outboundOrderBindingSource)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutboundOrder)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripOutboundOrder
            // 
            this.contextMenuStripOutboundOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBrowseOutboundOrder,
            this.toolStripMenuItemPrintOutboundOrder,
            this.toolStripSeparator1,
            this.toolStripMenuItemCreateOutboundOrder,
            this.toolStripMenuItemAppendOutboundOrder,
            this.toolStripMenuItemReturnOutboundOrder});
            this.contextMenuStripOutboundOrder.Name = "contextMenuStripToolInventory";
            this.contextMenuStripOutboundOrder.Size = new System.Drawing.Size(153, 142);
            // 
            // toolStripMenuItemBrowseOutboundOrder
            // 
            this.toolStripMenuItemBrowseOutboundOrder.Name = "toolStripMenuItemBrowseOutboundOrder";
            this.toolStripMenuItemBrowseOutboundOrder.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemBrowseOutboundOrder.Text = "查看";
            this.toolStripMenuItemBrowseOutboundOrder.Click += new System.EventHandler(this.toolStripMenuItemBrowseOutboundOrder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItemCreateOutboundOrder
            // 
            this.toolStripMenuItemCreateOutboundOrder.Name = "toolStripMenuItemCreateOutboundOrder";
            this.toolStripMenuItemCreateOutboundOrder.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemCreateOutboundOrder.Text = "借用";
            this.toolStripMenuItemCreateOutboundOrder.Click += new System.EventHandler(this.toolStripMenuItemCreateOutboundOrder_Click);
            // 
            // toolStripMenuItemAppendOutboundOrder
            // 
            this.toolStripMenuItemAppendOutboundOrder.Name = "toolStripMenuItemAppendOutboundOrder";
            this.toolStripMenuItemAppendOutboundOrder.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemAppendOutboundOrder.Text = "补借";
            this.toolStripMenuItemAppendOutboundOrder.Click += new System.EventHandler(this.toolStripMenuItemAppendOutboundOrder_Click);
            // 
            // toolStripMenuItemReturnOutboundOrder
            // 
            this.toolStripMenuItemReturnOutboundOrder.Name = "toolStripMenuItemReturnOutboundOrder";
            this.toolStripMenuItemReturnOutboundOrder.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemReturnOutboundOrder.Text = "归还";
            this.toolStripMenuItemReturnOutboundOrder.Click += new System.EventHandler(this.toolStripMenuItemReturnOutboundOrder_Click);
            // 
            // outboundOrderBindingSource
            // 
            this.outboundOrderBindingSource.DataSource = typeof(TMS.Model.OutboundOrder);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewOutboundOrder, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelSearch, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(695, 453);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // dataGridViewOutboundOrder
            // 
            this.dataGridViewOutboundOrder.AllowUserToAddRows = false;
            this.dataGridViewOutboundOrder.AllowUserToDeleteRows = false;
            this.dataGridViewOutboundOrder.AutoGenerateColumns = false;
            this.dataGridViewOutboundOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewOutboundOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutboundOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.outboundOrderIDDataGridViewTextBoxColumn,
            this.outboundDateDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.jobDataGridViewTextBoxColumn,
            this.berthDataGridViewTextBoxColumn,
            this.machineDataGridViewTextBoxColumn,
            this.shipDataGridViewTextBoxColumn,
            this.hatchDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.processDataGridViewTextBoxColumn,
            this.lastUpdatedByDataGridViewTextBoxColumn,
            this.lastUpdateTimeDataGridViewTextBoxColumn});
            this.dataGridViewOutboundOrder.ContextMenuStrip = this.contextMenuStripOutboundOrder;
            this.dataGridViewOutboundOrder.DataSource = this.outboundOrderBindingSource;
            this.dataGridViewOutboundOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutboundOrder.Location = new System.Drawing.Point(3, 63);
            this.dataGridViewOutboundOrder.Name = "dataGridViewOutboundOrder";
            this.dataGridViewOutboundOrder.ReadOnly = true;
            this.dataGridViewOutboundOrder.RowTemplate.Height = 23;
            this.dataGridViewOutboundOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOutboundOrder.Size = new System.Drawing.Size(689, 387);
            this.dataGridViewOutboundOrder.TabIndex = 1;
            this.dataGridViewOutboundOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOutboundOrder_CellDoubleClick);
            // 
            // outboundOrderIDDataGridViewTextBoxColumn
            // 
            this.outboundOrderIDDataGridViewTextBoxColumn.DataPropertyName = "OutboundOrderID";
            this.outboundOrderIDDataGridViewTextBoxColumn.HeaderText = "序号";
            this.outboundOrderIDDataGridViewTextBoxColumn.Name = "outboundOrderIDDataGridViewTextBoxColumn";
            this.outboundOrderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // outboundDateDataGridViewTextBoxColumn
            // 
            this.outboundDateDataGridViewTextBoxColumn.DataPropertyName = "OutboundDate";
            this.outboundDateDataGridViewTextBoxColumn.HeaderText = "借用日期";
            this.outboundDateDataGridViewTextBoxColumn.Name = "outboundDateDataGridViewTextBoxColumn";
            this.outboundDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "补借次数";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "借用单号";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // jobDataGridViewTextBoxColumn
            // 
            this.jobDataGridViewTextBoxColumn.DataPropertyName = "Job";
            this.jobDataGridViewTextBoxColumn.HeaderText = "作业号";
            this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            this.jobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // berthDataGridViewTextBoxColumn
            // 
            this.berthDataGridViewTextBoxColumn.DataPropertyName = "Berth";
            this.berthDataGridViewTextBoxColumn.HeaderText = "泊位";
            this.berthDataGridViewTextBoxColumn.Name = "berthDataGridViewTextBoxColumn";
            this.berthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // machineDataGridViewTextBoxColumn
            // 
            this.machineDataGridViewTextBoxColumn.DataPropertyName = "Machine";
            this.machineDataGridViewTextBoxColumn.HeaderText = "机械";
            this.machineDataGridViewTextBoxColumn.Name = "machineDataGridViewTextBoxColumn";
            this.machineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipDataGridViewTextBoxColumn
            // 
            this.shipDataGridViewTextBoxColumn.DataPropertyName = "Ship";
            this.shipDataGridViewTextBoxColumn.HeaderText = "船名";
            this.shipDataGridViewTextBoxColumn.Name = "shipDataGridViewTextBoxColumn";
            this.shipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hatchDataGridViewTextBoxColumn
            // 
            this.hatchDataGridViewTextBoxColumn.DataPropertyName = "Hatch";
            this.hatchDataGridViewTextBoxColumn.HeaderText = "舱口";
            this.hatchDataGridViewTextBoxColumn.Name = "hatchDataGridViewTextBoxColumn";
            this.hatchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "货物";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "数量";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // processDataGridViewTextBoxColumn
            // 
            this.processDataGridViewTextBoxColumn.DataPropertyName = "Process";
            this.processDataGridViewTextBoxColumn.HeaderText = "作业过程";
            this.processDataGridViewTextBoxColumn.Name = "processDataGridViewTextBoxColumn";
            this.processDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastUpdatedByDataGridViewTextBoxColumn
            // 
            this.lastUpdatedByDataGridViewTextBoxColumn.DataPropertyName = "LastUpdatedBy";
            this.lastUpdatedByDataGridViewTextBoxColumn.HeaderText = "LastUpdatedBy";
            this.lastUpdatedByDataGridViewTextBoxColumn.Name = "lastUpdatedByDataGridViewTextBoxColumn";
            this.lastUpdatedByDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastUpdatedByDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastUpdateTimeDataGridViewTextBoxColumn
            // 
            this.lastUpdateTimeDataGridViewTextBoxColumn.DataPropertyName = "LastUpdateTime";
            this.lastUpdateTimeDataGridViewTextBoxColumn.HeaderText = "LastUpdateTime";
            this.lastUpdateTimeDataGridViewTextBoxColumn.Name = "lastUpdateTimeDataGridViewTextBoxColumn";
            this.lastUpdateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastUpdateTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnQuery);
            this.panelSearch.Controls.Add(this.dtEndDate);
            this.panelSearch.Controls.Add(this.dtBeginDate);
            this.panelSearch.Controls.Add(this.lblDate);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(3, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(689, 54);
            this.panelSearch.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(383, 17);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 11;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(234, 19);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(134, 21);
            this.dtEndDate.TabIndex = 10;
            // 
            // dtBeginDate
            // 
            this.dtBeginDate.Location = new System.Drawing.Point(81, 19);
            this.dtBeginDate.Name = "dtBeginDate";
            this.dtBeginDate.Size = new System.Drawing.Size(134, 21);
            this.dtBeginDate.TabIndex = 9;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(22, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 12);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "日期范围";
            // 
            // toolStripMenuItemPrintOutboundOrder
            // 
            this.toolStripMenuItemPrintOutboundOrder.Name = "toolStripMenuItemPrintOutboundOrder";
            this.toolStripMenuItemPrintOutboundOrder.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemPrintOutboundOrder.Text = "打印";
            this.toolStripMenuItemPrintOutboundOrder.Click += new System.EventHandler(this.toolStripMenuItemPrintOutboundOrder_Click);
            // 
            // ViewOutboundOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 453);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "ViewOutboundOrderForm";
            this.Text = "借用单管理";
            this.Load += new System.EventHandler(this.FormLoad);
            this.contextMenuStripOutboundOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outboundOrderBindingSource)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutboundOrder)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewOutboundOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOutboundOrder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCreateOutboundOrder;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAppendOutboundOrder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReturnOutboundOrder;
        private System.Windows.Forms.BindingSource outboundOrderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn outboundOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outboundDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn berthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hatchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBrowseOutboundOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtBeginDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPrintOutboundOrder;
    }
}