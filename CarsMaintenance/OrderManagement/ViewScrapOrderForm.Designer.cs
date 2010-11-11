namespace CarsMaintenance.OrderManagement
{
    partial class ViewScrapOrderForm
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
            this.contextMenuStripScrapOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemBrowseScrapOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCreateScrapOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCreateSelfScrapOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewScrapOrder = new System.Windows.Forms.DataGridView();
            this.scrapOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtBeginDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.scrapOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scrapDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrescrapQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScrapReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScrapQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepairingQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripScrapOrder.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScrapOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrapOrderBindingSource)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripScrapOrder
            // 
            this.contextMenuStripScrapOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBrowseScrapOrder,
            this.toolStripSeparator1,
            this.toolStripMenuItemCreateScrapOrder,
            this.toolStripMenuItemCreateSelfScrapOrder});
            this.contextMenuStripScrapOrder.Name = "contextMenuStripToolInventory";
            this.contextMenuStripScrapOrder.Size = new System.Drawing.Size(113, 76);
            // 
            // toolStripMenuItemBrowseScrapOrder
            // 
            this.toolStripMenuItemBrowseScrapOrder.Name = "toolStripMenuItemBrowseScrapOrder";
            this.toolStripMenuItemBrowseScrapOrder.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemBrowseScrapOrder.Text = "查看";
            this.toolStripMenuItemBrowseScrapOrder.Click += new System.EventHandler(this.toolStripMenuItemBrowseScrapOrder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // toolStripMenuItemCreateScrapOrder
            // 
            this.toolStripMenuItemCreateScrapOrder.Name = "toolStripMenuItemCreateScrapOrder";
            this.toolStripMenuItemCreateScrapOrder.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemCreateScrapOrder.Text = "报废";
            this.toolStripMenuItemCreateScrapOrder.Click += new System.EventHandler(this.toolStripMenuItemCreateScrapOrder_Click);
            // 
            // toolStripMenuItemCreateSelfScrapOrder
            // 
            this.toolStripMenuItemCreateSelfScrapOrder.Name = "toolStripMenuItemCreateSelfScrapOrder";
            this.toolStripMenuItemCreateSelfScrapOrder.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemCreateSelfScrapOrder.Text = "自报废";
            this.toolStripMenuItemCreateSelfScrapOrder.Click += new System.EventHandler(this.toolStripMenuItemCreateSelfScrapOrder_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewScrapOrder, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelSearch, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(647, 465);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // dataGridViewScrapOrder
            // 
            this.dataGridViewScrapOrder.AllowUserToAddRows = false;
            this.dataGridViewScrapOrder.AllowUserToDeleteRows = false;
            this.dataGridViewScrapOrder.AutoGenerateColumns = false;
            this.dataGridViewScrapOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewScrapOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScrapOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scrapOrderIDDataGridViewTextBoxColumn,
            this.scrapDateDataGridViewTextBoxColumn,
            this.ItemName,
            this.Dimensions,
            this.PrescrapQuantity,
            this.ScrapReason,
            this.ScrapQuantity,
            this.Quantity,
            this.RepairingQuantity,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridViewScrapOrder.ContextMenuStrip = this.contextMenuStripScrapOrder;
            this.dataGridViewScrapOrder.DataSource = this.scrapOrderBindingSource;
            this.dataGridViewScrapOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewScrapOrder.Location = new System.Drawing.Point(3, 63);
            this.dataGridViewScrapOrder.Name = "dataGridViewScrapOrder";
            this.dataGridViewScrapOrder.ReadOnly = true;
            this.dataGridViewScrapOrder.RowTemplate.Height = 23;
            this.dataGridViewScrapOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewScrapOrder.Size = new System.Drawing.Size(641, 399);
            this.dataGridViewScrapOrder.TabIndex = 1;
            this.dataGridViewScrapOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewScrapOrder_CellDoubleClick);
            // 
            // scrapOrderBindingSource
            // 
            this.scrapOrderBindingSource.DataSource = typeof(TMS.Model.ScrapOrder);
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
            this.panelSearch.Size = new System.Drawing.Size(641, 54);
            this.panelSearch.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(380, 13);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(231, 15);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(134, 21);
            this.dtEndDate.TabIndex = 2;
            // 
            // dtBeginDate
            // 
            this.dtBeginDate.Location = new System.Drawing.Point(78, 15);
            this.dtBeginDate.Name = "dtBeginDate";
            this.dtBeginDate.Size = new System.Drawing.Size(134, 21);
            this.dtBeginDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(19, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 12);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "日期范围";
            // 
            // scrapOrderIDDataGridViewTextBoxColumn
            // 
            this.scrapOrderIDDataGridViewTextBoxColumn.DataPropertyName = "ScrapOrderID";
            this.scrapOrderIDDataGridViewTextBoxColumn.HeaderText = "序号";
            this.scrapOrderIDDataGridViewTextBoxColumn.Name = "scrapOrderIDDataGridViewTextBoxColumn";
            this.scrapOrderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scrapDateDataGridViewTextBoxColumn
            // 
            this.scrapDateDataGridViewTextBoxColumn.DataPropertyName = "ScrapDate";
            this.scrapDateDataGridViewTextBoxColumn.HeaderText = "报废日期";
            this.scrapDateDataGridViewTextBoxColumn.Name = "scrapDateDataGridViewTextBoxColumn";
            this.scrapDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "名称";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Dimensions
            // 
            this.Dimensions.DataPropertyName = "Dimensions";
            this.Dimensions.HeaderText = "规格";
            this.Dimensions.Name = "Dimensions";
            this.Dimensions.ReadOnly = true;
            // 
            // PrescrapQuantity
            // 
            this.PrescrapQuantity.DataPropertyName = "PrescrapQuantity";
            this.PrescrapQuantity.HeaderText = "预报废数";
            this.PrescrapQuantity.Name = "PrescrapQuantity";
            this.PrescrapQuantity.ReadOnly = true;
            // 
            // ScrapReason
            // 
            this.ScrapReason.DataPropertyName = "ScrapReason";
            this.ScrapReason.HeaderText = "报废原因";
            this.ScrapReason.Name = "ScrapReason";
            this.ScrapReason.ReadOnly = true;
            // 
            // ScrapQuantity
            // 
            this.ScrapQuantity.DataPropertyName = "ScrapQuantity";
            this.ScrapQuantity.HeaderText = "报废数";
            this.ScrapQuantity.Name = "ScrapQuantity";
            this.ScrapQuantity.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "归还数";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // RepairingQuantity
            // 
            this.RepairingQuantity.DataPropertyName = "RepairingQuantity";
            this.RepairingQuantity.HeaderText = "修理数";
            this.RepairingQuantity.Name = "RepairingQuantity";
            this.RepairingQuantity.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewScrapOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 465);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "ViewScrapOrderForm";
            this.Text = "报废单管理";
            this.Load += new System.EventHandler(this.FormLoad);
            this.contextMenuStripScrapOrder.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScrapOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrapOrderBindingSource)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripScrapOrder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBrowseScrapOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCreateScrapOrder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCreateSelfScrapOrder;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewScrapOrder;
        private System.Windows.Forms.BindingSource scrapOrderBindingSource;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtBeginDate;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrapOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrapDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dimensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrescrapQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrapReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrapQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairingQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}