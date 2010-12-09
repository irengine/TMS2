namespace CarsMaintenance.ToolManagement
{
    partial class ViewToolInventoryForm
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
            this.contextMenuStripToolInventory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemPurchaseOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewToolInventory = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.cbShowEmpty = new System.Windows.Forms.CheckBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.contextMenuStripToolInventory.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToolInventory)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripToolInventory
            // 
            this.contextMenuStripToolInventory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPurchaseOrder});
            this.contextMenuStripToolInventory.Name = "contextMenuStripToolInventory";
            this.contextMenuStripToolInventory.Size = new System.Drawing.Size(119, 26);
            // 
            // toolStripMenuItemPurchaseOrder
            // 
            this.toolStripMenuItemPurchaseOrder.Enabled = false;
            this.toolStripMenuItemPurchaseOrder.Name = "toolStripMenuItemPurchaseOrder";
            this.toolStripMenuItemPurchaseOrder.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemPurchaseOrder.Text = "采购入库";
            this.toolStripMenuItemPurchaseOrder.Click += new System.EventHandler(this.toolStripMenuItemPurchaseOrder_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewToolInventory, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelSearch, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(750, 470);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // dataGridViewToolInventory
            // 
            this.dataGridViewToolInventory.AllowUserToAddRows = false;
            this.dataGridViewToolInventory.AllowUserToDeleteRows = false;
            this.dataGridViewToolInventory.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewToolInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToolInventory.ContextMenuStrip = this.contextMenuStripToolInventory;
            this.dataGridViewToolInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewToolInventory.Location = new System.Drawing.Point(3, 63);
            this.dataGridViewToolInventory.Name = "dataGridViewToolInventory";
            this.dataGridViewToolInventory.ReadOnly = true;
            this.dataGridViewToolInventory.RowTemplate.Height = 23;
            this.dataGridViewToolInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewToolInventory.Size = new System.Drawing.Size(744, 404);
            this.dataGridViewToolInventory.TabIndex = 1;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.cbShowEmpty);
            this.panelSearch.Controls.Add(this.btnQuery);
            this.panelSearch.Controls.Add(this.cbCategory);
            this.panelSearch.Controls.Add(this.lblCategory);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(3, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(744, 54);
            this.panelSearch.TabIndex = 0;
            // 
            // cbShowEmpty
            // 
            this.cbShowEmpty.AutoSize = true;
            this.cbShowEmpty.Location = new System.Drawing.Point(299, 20);
            this.cbShowEmpty.Name = "cbShowEmpty";
            this.cbShowEmpty.Size = new System.Drawing.Size(84, 16);
            this.cbShowEmpty.TabIndex = 3;
            this.cbShowEmpty.Text = "显示空记录";
            this.cbShowEmpty.UseVisualStyleBackColor = true;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(389, 16);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(100, 18);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(177, 20);
            this.cbCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(19, 21);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 12);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "工属具类别";
            // 
            // ViewToolInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 470);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "ViewToolInventoryForm";
            this.Text = "工属具明细情况";
            this.Load += new System.EventHandler(this.FormLoad);
            this.contextMenuStripToolInventory.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToolInventory)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewToolInventory;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripToolInventory;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPurchaseOrder;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.CheckBox cbShowEmpty;
    }
}