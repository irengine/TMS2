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

namespace CarsMaintenance.OrderManagement
{
    public partial class ViewRepairOrderForm : BaseForm
    {
        #region Role
        protected override void RoleToSystmeManage()
        {
            for (int i = 0; i < contextMenuStripRepairOrder.Items.Count; i++)
            {
                contextMenuStripRepairOrder.Items[i].Enabled = true;
            }

        }
        protected override void RoleToToolsManage()
        {
            for (int i = 0; i < contextMenuStripRepairOrder.Items.Count; i++)
            {
                contextMenuStripRepairOrder.Items[i].Enabled = true;
            }

        }
        protected override void RoleToToolArticleManage()
        {
            for (int i = 0; i < contextMenuStripRepairOrder.Items.Count; i++)
            {
                contextMenuStripRepairOrder.Items[i].Enabled = true;
            }

        }
        protected override void RoleToToolsOutOrInUser()
        {
            for (int i = 0; i < contextMenuStripRepairOrder.Items.Count; i++)
            {
                contextMenuStripRepairOrder.Items[i].Enabled = true;
            }
        }
        protected override void RoleToToolsConservator()
        {
            for (int i = 0; i < contextMenuStripRepairOrder.Items.Count; i++)
            {
                contextMenuStripRepairOrder.Items[i].Enabled = true;
            }
        }
        #endregion
        public ViewRepairOrderForm()
        {
            InitializeComponent();
        }

        protected void LoadData()
        {
            var query = from o in SystemHelper.TMSContext.RepairOrders
                        orderby o.RepairDate
                        select new
                        {
                            o.RepairOrderID,
                            o.RepairDate,
                            o.Code,
                            Status = (o.Status == 0 ? "待修理" : "已修理")
                        };

            CarsMaintenance.Common.Sorting.SortableBindingList<object> repairOrders = new CarsMaintenance.Common.Sorting.SortableBindingList<object>();
            foreach (object o in query)
            {
                repairOrders.Add(o);
            }

            dataGridViewRepairOrder.DataSource = repairOrders;
        }

        private void FormLoad(object sender, EventArgs e)
        {
            LoadData();
        }

        private RepairOrder GetSelectedOrder()
        {
            if (dataGridViewRepairOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择修理单!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }
            int id;
            if (!int.TryParse(Convert.ToString(dataGridViewRepairOrder.SelectedRows[0].Cells[0].Value), out id))
            {
                MessageBox.Show("请重新选择修理单!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }

            return SystemHelper.TMSContext.RepairOrders.First(u => u.RepairOrderID == id);
        }

        private void Create()
        {
            using (CreateRepairOrderForm form = new CreateRepairOrderForm())
            {
                form.CurrentOrder = GetSelectedOrder();

                if (form.CurrentOrder.Status == 1)
                {
                    MessageBox.Show("已处理，请重新选择修理单!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                form.CurrentMode = CreateRepairOrderForm.MODE_CREATE;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
                else
                {
                    SystemHelper.RefreshOrder(form.CurrentOrder);
                }
            }
        }

        private void Browse()
        {
            using (CreateRepairOrderForm form = new CreateRepairOrderForm())
            {
                form.CurrentOrder = GetSelectedOrder();
                form.CurrentMode = CreateRepairOrderForm.MODE_BROWSE;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
                else
                {
                    SystemHelper.RefreshOrder(form.CurrentOrder);
                }
            }
        }

        private void CreateSelf()
        {
            using (CreateRepairOrderForm form = new CreateRepairOrderForm(CreateRepairOrderForm.MODE_CREATESELF))
            {
                form.CurrentOrder = new RepairOrder();
                form.CurrentOrder.Status = 1;
                form.CurrentMode = CreateRepairOrderForm.MODE_CREATESELF;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
                else
                {
                    SystemHelper.RefreshOrder(form.CurrentOrder);
                }
            }
        }

        private void toolStripMenuItemCreateRepairOrder_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Create);
        }

        private void toolStripMenuItemCreateSelfRepairOrder_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(CreateSelf);
        }

        private void toolStripMenuItemBrowseRepairOrder_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Browse);
        }

        private void dataGridViewScrapOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Browse);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBeginDate.Value.Date;
            DateTime endDate = dtEndDate.Value.Date.AddDays(1);
            var query = from o in SystemHelper.TMSContext.RepairOrders
                        where o.RepairDate >= beginDate && o.RepairDate <= endDate
                        orderby o.RepairDate
                        select new
                        {
                            o.RepairOrderID,
                            o.RepairDate,
                            o.Code,
                            Status = (o.Status == 0 ? "待修理" : "已修理")
                        };

            dataGridViewRepairOrder.DataSource = query;
        }
    }
}
