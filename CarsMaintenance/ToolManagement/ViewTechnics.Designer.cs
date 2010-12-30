namespace CarsMaintenance.ToolManagement
{
    partial class ViewTechnics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTechnics));
            this.image2 = new System.Windows.Forms.ImageList(this.components);
            this.image1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FileList = new System.Windows.Forms.ListView();
            this.ExplorerTree = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // image2
            // 
            this.image2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image2.ImageStream")));
            this.image2.TransparentColor = System.Drawing.Color.Transparent;
            this.image2.Images.SetKeyName(0, "2.jpg");
            // 
            // image1
            // 
            this.image1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image1.ImageStream")));
            this.image1.TransparentColor = System.Drawing.Color.Transparent;
            this.image1.Images.SetKeyName(0, "06.png");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.FileList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ExplorerTree, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(735, 451);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FileList
            // 
            this.FileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileList.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileList.GridLines = true;
            this.FileList.LargeImageList = this.image2;
            this.FileList.Location = new System.Drawing.Point(150, 3);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(582, 445);
            this.FileList.SmallImageList = this.image2;
            this.FileList.StateImageList = this.image2;
            this.FileList.TabIndex = 3;
            this.FileList.UseCompatibleStateImageBehavior = false;
            this.FileList.DoubleClick += new System.EventHandler(this.FileList_DoubleClick);
            // 
            // ExplorerTree
            // 
            this.ExplorerTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExplorerTree.ImageIndex = 0;
            this.ExplorerTree.ImageList = this.image1;
            this.ExplorerTree.Location = new System.Drawing.Point(3, 3);
            this.ExplorerTree.Name = "ExplorerTree";
            this.ExplorerTree.SelectedImageIndex = 0;
            this.ExplorerTree.Size = new System.Drawing.Size(141, 445);
            this.ExplorerTree.TabIndex = 2;
            this.ExplorerTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ExplorerTree_NodeMouseClick);
            // 
            // ViewTechnics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 451);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ViewTechnics";
            this.Text = "工艺标准";
            this.Load += new System.EventHandler(this.ViewTechnics_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView FileList;
        private System.Windows.Forms.TreeView ExplorerTree;
        private System.Windows.Forms.ImageList image2;
        private System.Windows.Forms.ImageList image1;
    }
}