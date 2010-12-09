namespace CarsMaintenance.ToolManagement
{
    partial class ViewUnitForm
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
            this.treeViewUnit = new System.Windows.Forms.TreeView();
            this.contextMenuStripUnit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewUnit = new System.Windows.Forms.DataGridView();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStripUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewUnit
            // 
            this.treeViewUnit.ContextMenuStrip = this.contextMenuStripUnit;
            this.treeViewUnit.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewUnit.Location = new System.Drawing.Point(0, 0);
            this.treeViewUnit.Name = "treeViewUnit";
            this.treeViewUnit.Size = new System.Drawing.Size(200, 413);
            this.treeViewUnit.TabIndex = 0;
            this.treeViewUnit.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewUnit_AfterSelect);
            // 
            // contextMenuStripUnit
            // 
            this.contextMenuStripUnit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripUnit.Name = "contextMenuStripSystemUser";
            this.contextMenuStripUnit.Size = new System.Drawing.Size(153, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Enabled = false;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "添加";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "编辑";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "删除";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // dataGridViewUnit
            // 
            this.dataGridViewUnit.AllowUserToAddRows = false;
            this.dataGridViewUnit.AllowUserToDeleteRows = false;
            this.dataGridViewUnit.AutoGenerateColumns = false;
            this.dataGridViewUnit.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitIDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Comment});
            this.dataGridViewUnit.DataSource = this.unitBindingSource;
            this.dataGridViewUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUnit.Location = new System.Drawing.Point(200, 0);
            this.dataGridViewUnit.MultiSelect = false;
            this.dataGridViewUnit.Name = "dataGridViewUnit";
            this.dataGridViewUnit.ReadOnly = true;
            this.dataGridViewUnit.RowTemplate.Height = 23;
            this.dataGridViewUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUnit.Size = new System.Drawing.Size(466, 413);
            this.dataGridViewUnit.TabIndex = 1;
            this.dataGridViewUnit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUnit_CellDoubleClick);
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "序号";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "组织编码";
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
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "备注";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(TMS.Model.Unit);
            // 
            // ViewUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 413);
            this.Controls.Add(this.dataGridViewUnit);
            this.Controls.Add(this.treeViewUnit);
            this.Name = "ViewUnitForm";
            this.Text = "组织管理";
            this.Load += new System.EventHandler(this.ViewUnitForm_Load);
            this.contextMenuStripUnit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewUnit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripUnit;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewUnit;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}