namespace CarsMaintenance.ToolManagement
{
    partial class ViewToolCategoryForm
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
            this.contextMenuStripToolCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTool = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Add2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTool = new System.Windows.Forms.DataGridView();
            this.toolIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Load2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimensionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeViewToolCategory = new System.Windows.Forms.TreeView();
            this.contextMenuStripToolCategory.SuspendLayout();
            this.contextMenuStripTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTool)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStripToolCategory
            // 
            this.contextMenuStripToolCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripSeparator1,
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripToolCategory.Name = "contextMenuStripToolCategory";
            this.contextMenuStripToolCategory.Size = new System.Drawing.Size(161, 99);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 21);
            this.toolStripTextBox1.Text = "工属具类别";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Enabled = false;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addToolStripMenuItem.Text = "添加";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.editToolStripMenuItem.Text = "编辑";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deleteToolStripMenuItem.Text = "删除";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // contextMenuStripTool
            // 
            this.contextMenuStripTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2,
            this.toolStripSeparator2,
            this.Add2ToolStripMenuItem,
            this.Edit2ToolStripMenuItem,
            this.Delete2ToolStripMenuItem});
            this.contextMenuStripTool.Name = "contextMenuStripToolCategory";
            this.contextMenuStripTool.Size = new System.Drawing.Size(161, 121);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Enabled = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 21);
            this.toolStripTextBox2.Text = "工属具";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // Add2ToolStripMenuItem
            // 
            this.Add2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolToolStripMenuItem,
            this.AddToolGroupToolStripMenuItem});
            this.Add2ToolStripMenuItem.Enabled = false;
            this.Add2ToolStripMenuItem.Name = "Add2ToolStripMenuItem";
            this.Add2ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.Add2ToolStripMenuItem.Text = "添加";
            // 
            // AddToolToolStripMenuItem
            // 
            this.AddToolToolStripMenuItem.Name = "AddToolToolStripMenuItem";
            this.AddToolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AddToolToolStripMenuItem.Text = "工属具";
            this.AddToolToolStripMenuItem.Click += new System.EventHandler(this.AddToolToolStripMenuItem_Click);
            // 
            // AddToolGroupToolStripMenuItem
            // 
            this.AddToolGroupToolStripMenuItem.Name = "AddToolGroupToolStripMenuItem";
            this.AddToolGroupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AddToolGroupToolStripMenuItem.Text = "工属具组合";
            this.AddToolGroupToolStripMenuItem.Click += new System.EventHandler(this.AddToolGroupToolStripMenuItem_Click);
            // 
            // Edit2ToolStripMenuItem
            // 
            this.Edit2ToolStripMenuItem.Enabled = false;
            this.Edit2ToolStripMenuItem.Name = "Edit2ToolStripMenuItem";
            this.Edit2ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.Edit2ToolStripMenuItem.Text = "编辑";
            this.Edit2ToolStripMenuItem.Click += new System.EventHandler(this.edit2ToolStripMenuItem_Click);
            // 
            // Delete2ToolStripMenuItem
            // 
            this.Delete2ToolStripMenuItem.Enabled = false;
            this.Delete2ToolStripMenuItem.Name = "Delete2ToolStripMenuItem";
            this.Delete2ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.Delete2ToolStripMenuItem.Text = "删除";
            this.Delete2ToolStripMenuItem.Click += new System.EventHandler(this.delete2ToolStripMenuItem_Click);
            // 
            // toolBindingSource
            // 
            this.toolBindingSource.DataSource = typeof(TMS.Model.Tool);
            // 
            // dataGridViewTool
            // 
            this.dataGridViewTool.AllowUserToAddRows = false;
            this.dataGridViewTool.AllowUserToDeleteRows = false;
            this.dataGridViewTool.AllowUserToOrderColumns = true;
            this.dataGridViewTool.AutoGenerateColumns = false;
            this.dataGridViewTool.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewTool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTool.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toolIDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Diameter,
            this.Length,
            this.Load2,
            this.dimensionsDataGridViewTextBoxColumn,
            this.RatedQuantity,
            this.unitDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridViewTool.ContextMenuStrip = this.contextMenuStripTool;
            this.dataGridViewTool.DataSource = this.toolBindingSource;
            this.dataGridViewTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTool.Location = new System.Drawing.Point(200, 0);
            this.dataGridViewTool.MultiSelect = false;
            this.dataGridViewTool.Name = "dataGridViewTool";
            this.dataGridViewTool.ReadOnly = true;
            this.dataGridViewTool.RowTemplate.Height = 23;
            this.dataGridViewTool.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTool.Size = new System.Drawing.Size(366, 373);
            this.dataGridViewTool.TabIndex = 1;
            this.dataGridViewTool.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTool_CellDoubleClick);
            // 
            // toolIDDataGridViewTextBoxColumn
            // 
            this.toolIDDataGridViewTextBoxColumn.DataPropertyName = "ToolID";
            this.toolIDDataGridViewTextBoxColumn.HeaderText = "序号";
            this.toolIDDataGridViewTextBoxColumn.Name = "toolIDDataGridViewTextBoxColumn";
            this.toolIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.toolIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "工属具编码";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Diameter
            // 
            this.Diameter.DataPropertyName = "Diameter";
            this.Diameter.HeaderText = "直径";
            this.Diameter.Name = "Diameter";
            this.Diameter.ReadOnly = true;
            this.Diameter.Width = 60;
            // 
            // Length
            // 
            this.Length.DataPropertyName = "Length";
            this.Length.HeaderText = "长度";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            this.Length.Width = 60;
            // 
            // Load2
            // 
            this.Load2.DataPropertyName = "Load2";
            this.Load2.HeaderText = "负载";
            this.Load2.Name = "Load2";
            this.Load2.ReadOnly = true;
            this.Load2.Width = 60;
            // 
            // dimensionsDataGridViewTextBoxColumn
            // 
            this.dimensionsDataGridViewTextBoxColumn.DataPropertyName = "Dimensions";
            this.dimensionsDataGridViewTextBoxColumn.HeaderText = "规格";
            this.dimensionsDataGridViewTextBoxColumn.Name = "dimensionsDataGridViewTextBoxColumn";
            this.dimensionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RatedQuantity
            // 
            this.RatedQuantity.DataPropertyName = "RatedQuantity";
            this.RatedQuantity.HeaderText = "额定数";
            this.RatedQuantity.Name = "RatedQuantity";
            this.RatedQuantity.ReadOnly = true;
            this.RatedQuantity.Width = 80;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "单位";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitDataGridViewTextBoxColumn.Width = 45;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "备注";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Width = 160;
            // 
            // treeViewToolCategory
            // 
            this.treeViewToolCategory.ContextMenuStrip = this.contextMenuStripToolCategory;
            this.treeViewToolCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewToolCategory.Location = new System.Drawing.Point(0, 0);
            this.treeViewToolCategory.Name = "treeViewToolCategory";
            this.treeViewToolCategory.Size = new System.Drawing.Size(200, 373);
            this.treeViewToolCategory.TabIndex = 0;
            this.treeViewToolCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewToolCategory_AfterSelect);
            // 
            // ViewToolCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 373);
            this.Controls.Add(this.dataGridViewTool);
            this.Controls.Add(this.treeViewToolCategory);
            this.Name = "ViewToolCategoryForm";
            this.Text = "工属具管理";
            this.Load += new System.EventHandler(this.ViewToolCategoryForm_Load);
            this.contextMenuStripToolCategory.ResumeLayout(false);
            this.contextMenuStripToolCategory.PerformLayout();
            this.contextMenuStripTool.ResumeLayout(false);
            this.contextMenuStripTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTool)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewToolCategory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripToolCategory;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewTool;
        private System.Windows.Forms.BindingSource toolBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTool;
        private System.Windows.Forms.ToolStripMenuItem Add2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Delete2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem AddToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolGroupToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Load2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimensionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}