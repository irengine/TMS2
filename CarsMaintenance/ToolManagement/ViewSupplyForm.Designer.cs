namespace CarsMaintenance.ToolManagement
{
    partial class ViewSupplyForm
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
            this.contextMenuStripSupply = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewSupply = new System.Windows.Forms.DataGridView();
            this.supplyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStripSupply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStripSupply
            // 
            this.contextMenuStripSupply.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripSupply.Name = "contextMenuStripSupply";
            this.contextMenuStripSupply.Size = new System.Drawing.Size(153, 92);
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
            // supplyBindingSource
            // 
            this.supplyBindingSource.DataSource = typeof(TMS.Model.Supply);
            // 
            // dataGridViewSupply
            // 
            this.dataGridViewSupply.AllowUserToAddRows = false;
            this.dataGridViewSupply.AllowUserToDeleteRows = false;
            this.dataGridViewSupply.AutoGenerateColumns = false;
            this.dataGridViewSupply.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSupply.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupply.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplyIDDataGridViewTextBoxColumn,
            this.Code,
            this.nameDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridViewSupply.ContextMenuStrip = this.contextMenuStripSupply;
            this.dataGridViewSupply.DataSource = this.supplyBindingSource;
            this.dataGridViewSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSupply.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSupply.Name = "dataGridViewSupply";
            this.dataGridViewSupply.ReadOnly = true;
            this.dataGridViewSupply.RowTemplate.Height = 23;
            this.dataGridViewSupply.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSupply.Size = new System.Drawing.Size(884, 382);
            this.dataGridViewSupply.TabIndex = 0;
            this.dataGridViewSupply.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupply_CellDoubleClick);
            // 
            // supplyIDDataGridViewTextBoxColumn
            // 
            this.supplyIDDataGridViewTextBoxColumn.DataPropertyName = "SupplyID";
            this.supplyIDDataGridViewTextBoxColumn.FillWeight = 40F;
            this.supplyIDDataGridViewTextBoxColumn.HeaderText = "序号";
            this.supplyIDDataGridViewTextBoxColumn.Name = "supplyIDDataGridViewTextBoxColumn";
            this.supplyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.FillWeight = 60F;
            this.Code.HeaderText = "供应商编码";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.FillWeight = 360F;
            this.commentDataGridViewTextBoxColumn.HeaderText = "备注";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // ViewSupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 382);
            this.Controls.Add(this.dataGridViewSupply);
            this.Name = "ViewSupplyForm";
            this.Text = "供应商管理";
            this.Load += new System.EventHandler(this.ViewSupplyForm_Load);
            this.contextMenuStripSupply.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource supplyBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewSupply;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSupply;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}