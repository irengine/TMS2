using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TMS.Model;
using CarsMaintenance.Common;

namespace CarsMaintenance.ToolManagement
{
    public partial class ViewToolCategoryForm : BaseForm
    {
        public ViewToolCategoryForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var query = from c in SystemHelper.TMSContext.ToolCategories
                        where c.ParentCategory == null
                        orderby c.Code
                        select c;
            try
            {
                treeViewToolCategory.BeginUpdate();

                treeViewToolCategory.Nodes.Clear();

                TreeNode parentNode = new TreeNode();
                ToolCategory parentCategory = null;

                foreach (ToolCategory c in query)
                {
                    TreeNode n = new TreeNode(c.Code + "-" + c.Name);

                    treeViewToolCategory.Nodes.Add(n);
                    parentNode = n;
                    parentCategory = c;
                    AddNode(n, c);

                }
                treeViewToolCategory.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNode(TreeNode parentNode, ToolCategory parentCategory)
        {
            foreach (ToolCategory c in parentCategory.ChildCategories)
            {
                TreeNode n = new TreeNode(c.Code + "-" + c.Name);
                parentNode.Nodes.Add(n);

                AddNode(n, c);
            }
        }

        private void ViewToolCategoryForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void treeViewToolCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string categoryCode = GetSelectedCategoryCode();

            var childQuery = from u in SystemHelper.TMSContext.Tools
                             where u.Code.Substring(0,2) == categoryCode && u.Deleted == false
                             orderby u.Code
                             select u;

            dataGridViewTool.DataSource = childQuery;
        }

        private string GetSelectedCategoryCode()
        {
            string categoryCode = treeViewToolCategory.SelectedNode.Text;
            categoryCode = categoryCode.Substring(0, categoryCode.IndexOf('-'));

            return categoryCode;
        }

        private ToolCategory GetSelectedCategory()
        {
            string categoryCode = GetSelectedCategoryCode();

            return SystemHelper.TMSContext.ToolCategories.First(u => u.Code == categoryCode);
        }

        private void Add()
        {
            using (ManageToolCategoryForm form = new ManageToolCategoryForm())
            {
                form.ParentCategory = GetSelectedCategory();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void Edit()
        {
            using (ManageToolCategoryForm form = new ManageToolCategoryForm())
            {
                form.CurrentCategory = GetSelectedCategory();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void Delete()
        {
            ToolCategory u = GetSelectedCategory();

            if (u != null && MessageBox.Show("请确定是否删除工属具类别?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CarsMaintenance.Properties.Settings.Default.DeleteFlag)
                {
                    SystemHelper.TMSContext.DeleteObject(u);
                }
                else
                {
                    u.Deleted = true;
                }
                SystemHelper.TMSContext.SaveChanges();

                LoadData();
            }
        }
        private Tool GetSelectedTool()
        {
            if (dataGridViewTool.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择工属具!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }
            int id;
            if (!int.TryParse(Convert.ToString(dataGridViewTool.SelectedRows[0].Cells[0].Value), out id))
            {
                MessageBox.Show("请重新选择工属具!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }

            return SystemHelper.TMSContext.Tools.First(u => u.ToolID == id);
        }

        private void AddTool()
        {
            using (ManageToolForm form = new ManageToolForm())
            {
                form.CurrentTool = new Tool();
                form.CurrentCategory = GetSelectedCategory();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private ToolCategory GetToolGroupCategory()
        {
            string toolGroupCode = CarsMaintenance.Properties.Settings.Default.ToolGroupCode;

            return SystemHelper.TMSContext.ToolCategories.FirstOrDefault(c => c.Code == toolGroupCode);
        }

        private void AddToolGroup()
        {
            using (ManageToolGroupForm form = new ManageToolGroupForm())
            {
                form.CurrentTool = new Tool();
                form.CurrentCategory = GetToolGroupCategory();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void Edit2()
        {
            ToolCategory tc = GetSelectedCategory();

            if (tc.Code.PadLeft(2) != CarsMaintenance.Properties.Settings.Default.ToolGroupCode)
            {
                using (ManageToolForm form = new ManageToolForm())
                {
                    form.CurrentTool = GetSelectedTool();
                    form.CurrentCategory = GetSelectedCategory();

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        //LoadData();
                    }
                }
            }
            else
            {
                using (ManageToolGroupForm form = new ManageToolGroupForm())
                {
                    form.CurrentTool = GetSelectedTool();
                    form.CurrentCategory = GetSelectedCategory();

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        //LoadData();
                    }
                }
            }
        }

        private void Delete2()
        {
            Tool u = GetSelectedTool();

            if (u != null && MessageBox.Show("请确定是否删除工属具?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CarsMaintenance.Properties.Settings.Default.DeleteFlag)
                {
                    SystemHelper.TMSContext.DeleteObject(u);
                }
                else
                {
                    u.Deleted = true;
                }
                SystemHelper.TMSContext.SaveChanges();

                //LoadData();
            }
        }

        #region menu handle event

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Add);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Edit);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Delete);
        }

        private void dataGridViewTool_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Edit2);
        }

        private void AddToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(AddTool);
        }

        private void AddToolGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(AddToolGroup);
        }

        private void edit2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Edit2);
        }

        private void delete2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Delete2);
        }

        #endregion
    }
}
