namespace CarsMaintenance.ToolManagement
{
    partial class ViewArticleForm
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
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewArticle = new System.Windows.Forms.DataGridView();
            this.articleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripArticle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticle)).BeginInit();
            this.contextMenuStripArticle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "编辑";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // dataGridViewArticle
            // 
            this.dataGridViewArticle.AllowUserToAddRows = false;
            this.dataGridViewArticle.AllowUserToDeleteRows = false;
            this.dataGridViewArticle.AutoGenerateColumns = false;
            this.dataGridViewArticle.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articleIDDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn});
            this.dataGridViewArticle.ContextMenuStrip = this.contextMenuStripArticle;
            this.dataGridViewArticle.DataSource = this.articleBindingSource;
            this.dataGridViewArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewArticle.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewArticle.Name = "dataGridViewArticle";
            this.dataGridViewArticle.ReadOnly = true;
            this.dataGridViewArticle.RowTemplate.Height = 23;
            this.dataGridViewArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArticle.Size = new System.Drawing.Size(284, 262);
            this.dataGridViewArticle.TabIndex = 1;
            this.dataGridViewArticle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArticle_CellDoubleClick_1);
            // 
            // articleIDDataGridViewTextBoxColumn
            // 
            this.articleIDDataGridViewTextBoxColumn.DataPropertyName = "ArticleID";
            this.articleIDDataGridViewTextBoxColumn.HeaderText = "序号";
            this.articleIDDataGridViewTextBoxColumn.Name = "articleIDDataGridViewTextBoxColumn";
            this.articleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "标题";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStripArticle
            // 
            this.contextMenuStripArticle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripArticle.Name = "contextMenuStripSupply";
            this.contextMenuStripArticle.Size = new System.Drawing.Size(153, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "添加";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "删除";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataSource = typeof(TMS.Model.Article);
            // 
            // ViewArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dataGridViewArticle);
            this.Name = "ViewArticleForm";
            this.Text = "工艺标准管理";
            this.Load += new System.EventHandler(this.ViewArticleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticle)).EndInit();
            this.contextMenuStripArticle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewArticle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripArticle;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource articleBindingSource;
    }
}