namespace CarsMaintenance.UserManagement
{
    partial class ViewSystemUserForm
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
            this.dataGridViewSystemUser = new System.Windows.Forms.DataGridView();
            this.systemUserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripSystemUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSystemUser)).BeginInit();
            this.contextMenuStripSystemUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSystemUser
            // 
            this.dataGridViewSystemUser.AllowUserToAddRows = false;
            this.dataGridViewSystemUser.AllowUserToDeleteRows = false;
            this.dataGridViewSystemUser.AutoGenerateColumns = false;
            this.dataGridViewSystemUser.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewSystemUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSystemUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.systemUserIDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Roles});
            this.dataGridViewSystemUser.ContextMenuStrip = this.contextMenuStripSystemUser;
            this.dataGridViewSystemUser.DataSource = this.systemUserBindingSource;
            this.dataGridViewSystemUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSystemUser.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSystemUser.MultiSelect = false;
            this.dataGridViewSystemUser.Name = "dataGridViewSystemUser";
            this.dataGridViewSystemUser.ReadOnly = true;
            this.dataGridViewSystemUser.RowTemplate.Height = 23;
            this.dataGridViewSystemUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSystemUser.Size = new System.Drawing.Size(284, 262);
            this.dataGridViewSystemUser.TabIndex = 0;
            this.dataGridViewSystemUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSystemUser_CellDoubleClick);
            // 
            // systemUserIDDataGridViewTextBoxColumn
            // 
            this.systemUserIDDataGridViewTextBoxColumn.DataPropertyName = "SystemUserID";
            this.systemUserIDDataGridViewTextBoxColumn.HeaderText = "序号";
            this.systemUserIDDataGridViewTextBoxColumn.Name = "systemUserIDDataGridViewTextBoxColumn";
            this.systemUserIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "用户编码";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Roles
            // 
            this.Roles.DataPropertyName = "Roles";
            this.Roles.HeaderText = "角色";
            this.Roles.Name = "Roles";
            this.Roles.ReadOnly = true;
            // 
            // contextMenuStripSystemUser
            // 
            this.contextMenuStripSystemUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripSystemUser.Name = "contextMenuStripSystemUser";
            this.contextMenuStripSystemUser.Size = new System.Drawing.Size(153, 92);
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
            // systemUserBindingSource
            // 
            this.systemUserBindingSource.DataSource = typeof(TMS.Model.SystemUser);
            // 
            // ViewSystemUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dataGridViewSystemUser);
            this.Font = new System.Drawing.Font("SimSun", 9F);
            this.Name = "ViewSystemUserForm";
            this.Text = "系统用户管理";
            this.Load += new System.EventHandler(this.ViewSystemUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSystemUser)).EndInit();
            this.contextMenuStripSystemUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.systemUserBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSystemUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSystemUser;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemUserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource systemUserBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roles;
    }
}