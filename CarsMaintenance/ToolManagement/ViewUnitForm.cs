using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarsMaintenance.Common;
using TMS.Model;

namespace CarsMaintenance.ToolManagement
{
    public partial class ViewUnitForm : BaseForm
    {
        #region Role
        protected override void RoleToSystmeManage()
        {
            for (int i = 0; i < contextMenuStripUnit.Items.Count; i++)
            {
                contextMenuStripUnit.Items[i].Enabled = true;
            }
        }
        #endregion 

        public ViewUnitForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var parentQuery = from u in SystemHelper.TMSContext.Units
                              where u.ParentUnit == null && u.Deleted==false
                              orderby u.InternalCode
                              select u;
            try
            {
                treeViewUnit.BeginUpdate();

                treeViewUnit.Nodes.Clear();

                TreeNode parentNode = new TreeNode();
                Unit parentUnit = null;

                foreach (Unit u in parentQuery)
                {
                    TreeNode n = new TreeNode(u.Code + "-" + u.Name);

                    treeViewUnit.Nodes.Add(n);
                    parentNode = n;
                    parentUnit = u;
                    AddNode(n, u);
                }
                treeViewUnit.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNode(TreeNode parentNode, Unit parentUnit)
        {
            foreach (Unit u in parentUnit.ChildUnits)
            {
                if (!u.Deleted)
                {
                    TreeNode n = new TreeNode(u.Code + "-" + u.Name);
                    parentNode.Nodes.Add(n);

                    AddNode(n, u);
                }
            }
        }

        private void ViewUnitForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void treeViewUnit_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string unitCode = GetSelectedUnitCode();

            var childQuery = from u in SystemHelper.TMSContext.Units
                             where u.ParentUnit.Code == unitCode && u.Deleted==false
                             orderby u.Code
                             select u;

            dataGridViewUnit.DataSource = childQuery;
        }

        private string GetSelectedUnitCode()
        {
            string unitCode = treeViewUnit.SelectedNode.Text;
            unitCode = unitCode.Substring(0, unitCode.IndexOf('-'));

            return unitCode;
        }

        private Unit GetSelectedUnit()
        {
            string unitCode = GetSelectedUnitCode();

            return SystemHelper.TMSContext.Units.First(u => u.Code == unitCode);
        }

        private void Add()
        {
            using (ManageUnitForm form = new ManageUnitForm())
            {
                form.ParentUnit = GetSelectedUnit();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void Edit()
        {
            using (ManageUnitForm form = new ManageUnitForm())
            {
                form.CurrentUnit = GetSelectedUnit();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void Delete()
        {
            Unit u = GetSelectedUnit();

            if (u != null && MessageBox.Show("请确定是否删除组织?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                var queryUnit = from pus in SystemHelper.TMSContext.Units where pus.ParentUnitID == u.UnitID select pus.UnitID;
                if (queryUnit.ToList().Count > 0)
                {
                    MessageBox.Show("对不起!不能删除该组织，因为该组织还有下级组织！",this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (u.ParentUnit == null)
                {
                    MessageBox.Show("不能删除顶级组织机构!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                                    

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

        private void dataGridViewUnit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Edit);
        }

        #endregion
    }
}
