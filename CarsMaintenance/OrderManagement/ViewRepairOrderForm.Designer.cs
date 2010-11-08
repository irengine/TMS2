namespace CarsMaintenance.OrderManagement
{
    partial class ViewRepairOrderForm
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
            this.contextMenuStripRepairOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemBrowseRepairOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCreateRepairOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCreateSelfRepairOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewRepairOrder = new System.Windows.Forms.DataGridView();
            this.repairOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtBeginDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.contextMenuStripRepairOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepairOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOrderBindingSource)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripRepairOrder
            // 
            this.contextMenuStripRepairOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBrowseRepairOrder,
            this.toolStripSeparator1,
            this.toolStripMenuItemCreateRepairOrder,
            this.toolStripMenuItemCreateSelfRepairOrder});
            this.contextMenuStripRepairOrder.Name = "contextMenuStripToolInventory";
            this.contextMenuStripRepairOrder.Size = new System.Drawing.Size(113, 76);
            // 
            // toolStripMenuItemBrowseRepairOrder
            // 
            this.toolStripMenuItemBrowseRepairOrder.Name = "toolStripMenuItemBrowseRepairOrder";
            this.toolStripMenuItemBrowseRepairOrder.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemBrowseRepairOrder.Text = "查看";
            this.toolStripMenuItemBrowseRepairOrder.Click += new System.EventHandler(this.toolStripMenuItemBrowseRepairOrder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // toolStripMenuItemCreateRepairOrder
            // 
            this.toolStripMenuItemCreateRepairOrder.Name = "toolStripMenuItemCreateRepairOrder";
            this.toolStripMenuItemCreateRepairOrder.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemCreateRepairOrder.Text = "修理";
            this.toolStripMenuItemCreateRepairOrder.Click += new System.EventHandler(this.toolStripMenuItemCreateRepairOrder_Click);
            // 
            // toolStripMenuItemCreateSelfRepairOrder
            // 
            this.toolStripMenuItemCreateSelfRepairOrder.Name = "toolStripMenuItemCreateSelfRepairOrder";
            this.toolStripMenuItemCreateSelfRepairOrder.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemCreateSelfRepairOrder.Text = "自修理";
            this.toolStripMenuItemCreateSelfRepairOrder.Click += new System.EventHandler(this.toolStripMenuItemCreateSelfRepairOrder_Click);
            // 
            // dataGridViewRepairOrder
            // 
            this.dataGridViewRepairOrder.AllowUserToAddRows = false;
            this.dataGridViewRepairOrder.AllowUserToDeleteRows = false;
            this.dataGridViewRepairOrder.AutoGenerateColumns = false;
            this.dataGridViewRepairOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewRepairOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRepairOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repairOrderIDDataGridViewTextBoxColumn,
            this.repairDateDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridViewRepairOrder.ContextMenuStrip = this.contextMenuStripRepairOrder;
            this.dataGridViewRepairOrder.DataSource = this.repairOrderBindingSource;
            this.dataGridViewRepairOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRepairOrder.Location = new System.Drawing.Point(3, 63);
            this.dataGridViewRepairOrder.Name = "dataGridViewRepairOrder";
            this.dataGridViewRepairOrder.ReadOnly = true;
            this.dataGridViewRepairOrder.RowTemplate.Height = 23;
            this.dataGridViewRepairOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRepairOrder.Size = new System.Drawing.Size(648, 372);
            this.dataGridViewRepairOrder.TabIndex = 1;
            this.dataGridViewRepairOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewScrapOrder_CellDoubleClick);
            // 
            // repairOrderIDDataGridViewTextBoxColumn
            // 
            this.repairOrderIDDataGridViewTextBoxColumn.DataPropertyName = "RepairOrderID";
            this.repairOrderIDDataGridViewTextBoxColumn.HeaderText = "序号";
            this.repairOrderIDDataGridViewTextBoxColumn.Name = "repairOrderIDDataGridViewTextBoxColumn";
            this.repairOrderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repairDateDataGridViewTextBoxColumn
            // 
            this.repairDateDataGridViewTextBoxColumn.DataPropertyName = "RepairDate";
            this.repairDateDataGridViewTextBoxColumn.HeaderText = "修理日期";
            this.repairDateDataGridViewTextBoxColumn.Name = "repairDateDataGridViewTextBoxColumn";
            this.repairDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "修理单号";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repairOrderBindingSource
            // 
            this.repairOrderBindingSource.DataSource = typeof(TMS.Model.RepairOrder);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewRepairOrder, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelSearch, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(654, 438);
            this.tableLayoutPanelMain.TabIndex = 3;
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
            this.panelSearch.Size = new System.Drawing.Size(648, 54);
            this.panelSearch.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(378, 16);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(229, 18);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(134, 21);
            this.dtEndDate.TabIndex = 6;
            // 
            // dtBeginDate
            // 
            this.dtBeginDate.Location = new System.Drawing.Point(76, 18);
            this.dtBeginDate.Name = "dtBeginDate";
            this.dtBeginDate.Size = new System.Drawing.Size(134, 21);
            this.dtBeginDate.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(17, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 12);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "日期范围";
            // 
            // ViewRepairOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 438);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "ViewRepairOrderForm";
            this.Text = "修理单管理";
            this.Load += new System.EventHandler(this.FormLoad);
            this.contextMenuStripRepairOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepairOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOrderBindingSource)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripRepairOrder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBrowseRepairOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCreateRepairOrder;
        private System.Windows.Forms.DataGridView dataGridViewRepairOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCreateSelfRepairOrder;
        private System.Windows.Forms.BindingSource repairOrderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtBeginDate;
        private System.Windows.Forms.Label lblDate;
    }
}