using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Configuration;

namespace CarsMaintenance.ToolManagement
{
    public partial class ViewTechnics : BaseForm
    {
        public ViewTechnics()
        {
            InitializeComponent();
        }

        private void ViewTechnics_Load(object sender, EventArgs e)
        {
            string dirFile = ConfigurationManager.AppSettings["TechnicsPath"].ToString();
            DirectoryInfo dinfo = new DirectoryInfo(dirFile);
            DirectoryInfo[] drivers = dinfo.GetDirectories();
            foreach (DirectoryInfo item in drivers)
            {
                TreeNode root = new TreeNode(item.Name);
                root.Tag = item.Name;
                root.Tag = item.FullName;
                root.ImageIndex = 0;
                root = BindThreeLay(root);
                ExplorerTree.Nodes.Add(root);

            }
        }
        private TreeNode BindThreeLay(TreeNode path)
        {

            try
            {
                DirectoryInfo dinfo = new DirectoryInfo(path.Tag as string);
                DirectoryInfo[] drivers = dinfo.GetDirectories();

                foreach (DirectoryInfo item in drivers)
                {
                    TreeNode tn = new TreeNode(item.Name);
                    tn.Tag = item.FullName;
                    tn.ImageIndex = 0;
                    tn = BindThreeLay(tn);
                    path.Nodes.Add(tn);
                }
                return path;
            }
            catch (Exception) { return null; }//ignore


        }

        private void ExplorerTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes != null)
            {
                foreach (TreeNode item in e.Node.Nodes)
                {
                    BindThreeLay(item);
                }
            }
        }
        private void ExplorerTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.FileList.Items.Clear();
            string[] FileInfo = Directory.GetFiles(e.Node.Tag.ToString());
           
            foreach (string i in FileInfo)
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.Substring(e.Node.Tag.ToString().Length + 1, i.Length - e.Node.Tag.ToString().Length - 1);
                item.Tag = i;
                item.ImageIndex = 0;         
                this.FileList.Items.Add(item);
            }
        }

        private void FileList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (FileList.SelectedIndices.Count > 0)
                {
                    Process openProcess = Process.Start(FileList.SelectedItems[0].Tag.ToString());
                    openProcess.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("请安装PDF阅读工具。");
            }
        }
    }
}
