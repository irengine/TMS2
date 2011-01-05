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
    public partial class ViewToolInventoryForm : BaseForm
    {

        #region Role
        protected override void RoleToSystmeManage()
        {
            for (int i = 0; i < contextMenuStripToolInventory.Items.Count; i++)
            {
                contextMenuStripToolInventory.Items[i].Enabled = true;
            }
        }
        protected override void RoleToToolsManage()
        {
            for (int i = 0; i < contextMenuStripToolInventory.Items.Count; i++)
            {
                contextMenuStripToolInventory.Items[i].Enabled = true;
            }
        }
        protected override void RoleToToolArticleManage()
        {
            for (int i = 0; i < contextMenuStripToolInventory.Items.Count; i++)
            {
                contextMenuStripToolInventory.Items[i].Enabled = true;
            }
        }
        #endregion 

        public ViewToolInventoryForm()
        {
            InitializeComponent();
            SetupDataGrid();
        }

        private void SetupDataGrid()
        {
            dataGridViewToolInventory.AutoGenerateColumns = false;
            dataGridViewToolInventory.AutoSize = true;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "ToolID";
            column.Name = "序号";
            column.Width = 40;
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Code";
            column.Name = "工属具编码";
            column.Width = 100;
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "名称";
            column.Width = 110;
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Dimensions";
            column.Name = "规格";
            column.Width = 150;
            dataGridViewToolInventory.Columns.Add(column);

            DataGridViewCellStyle dsc=new DataGridViewCellStyle();
            dsc.Format = "n0";
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "RatedQuantity";
            column.Name = "额定数";
            column.Width = 80;
            column.DefaultCellStyle = dsc;
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "DoQuantity";
            column.Name = "可用数";
            column.Width = 80;
            column.DefaultCellStyle = dsc;
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Quantity";
            column.Name = "在库数";
            column.Width = 80;
            column.DefaultCellStyle = dsc;
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "RenewQuantity";
            column.Name = "补充数";
            column.Width = 80;
            column.DefaultCellStyle = dsc;
            dataGridViewToolInventory.Columns.Add(column);          

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "OutQuantity";
            column.Name = "外借数";
            column.Width = 80;
            column.DefaultCellStyle = dsc;
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PrescrapQuantity";
            column.Name = "预报废数";
            column.Width = 60;
            column.DefaultCellStyle = dsc;
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "ScrapQuantity";
            column.Name = "报废数";
            column.Width = 80;
            column.DefaultCellStyle = dsc;
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "RepairingQuantity";
            column.Name = "修理数";
            column.Width = 80;
            column.DefaultCellStyle = dsc;
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Unit";
            column.Name = "单位";
            column.Width = 60;
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "UnitPrice";
            column.Name = "单价";
            column.Width = 60;
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Supply";
            column.Name = "供应商";
            column.Width = 140;
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "LastTime";
            column.Name = "最后入库时间";
            column.Width = 80;
            dataGridViewToolInventory.Columns.Add(column);
        }

        protected void LoadData()
        {
            var query = from t in SystemHelper.TMSContext.Tools
                        join ti in SystemHelper.TMSContext.ToolInventories on t.ToolID equals ti.ToolID
                        join s in SystemHelper.TMSContext.Supplies on ti.SupplyID equals s.SupplyID
                        where t.Deleted == false
                        && (ti.Quantity > 0 || ti.OutQuantity > 0 || ti.PrescrapQuantity > 0 || ti.ScrapQuantity > 0 || ti.RepairingQuantity > 0)
                        orderby t.Code
                        select new
                        {
                            ToolID = t.ToolID,
                            Code = t.Code,
                            Name = t.Name,
                            Dimensions = t.Dimensions,
                            //额定数
                            RatedQuantity=t.RatedQuantity,
                            //可用数
                            DoQuantity=t.RatedQuantity-ti.ScrapQuantity-ti.RepairingQuantity,
                            //补充数
                            RenewQuantity=t.RatedQuantity-(t.RatedQuantity-ti.ScrapQuantity-ti.RepairingQuantity)-ti.RepairingQuantity,

                            Quantity = ti.Quantity,
                            OutQuantity = ti.OutQuantity,
                            PrescrapQuantity = ti.PrescrapQuantity,
                            ScrapQuantity = ti.ScrapQuantity,
                            RepairingQuantity = ti.RepairingQuantity,
                            Unit = t.Unit,
                            UnitPrice = ti.UnitPrice,
                            Supply = s.Name,
                            LastTime = ti.LastInboundDate
                        };

            CarsMaintenance.Common.Sorting.SortableBindingList<object> toolInventories = new CarsMaintenance.Common.Sorting.SortableBindingList<object>();
            foreach (object o in query)
            {
                toolInventories.Add(o);
            }

            dataGridViewToolInventory.DataSource = toolInventories;

            SystemHelper.BindComboxToToolCategory(cbCategory);
        }

        private void FormLoad(object sender, EventArgs e)
        {
            LoadData();
        }

        private void toolStripMenuItemPurchaseOrder_Click(object sender, EventArgs e)
        {
            using (CarsMaintenance.OrderManagement.CreatePurchaseOrderForm form = new CarsMaintenance.OrderManagement.CreatePurchaseOrderForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string categoryCode = cbCategory.SelectedValue as string;
            if (cbShowEmpty.Checked)
            {
                var query = from t in SystemHelper.TMSContext.Tools
                            join ti in SystemHelper.TMSContext.ToolInventories on t.ToolID equals ti.ToolID
                            join s in SystemHelper.TMSContext.Supplies on ti.SupplyID equals s.SupplyID
                            where t.Deleted == false && t.Code.StartsWith(categoryCode)
                            orderby t.Code
                            select new
                            {
                                ToolID = t.ToolID,
                                Code = t.Code,
                                Name = t.Name,
                                Dimensions = t.Dimensions,
                                Quantity = ti.Quantity,
                                OutQuantity = ti.OutQuantity,
                                PrescrapQuantity = ti.PrescrapQuantity,
                                ScrapQuantity = ti.ScrapQuantity,
                                RepairingQuantity = ti.RepairingQuantity,
                                Unit = t.Unit,
                                UnitPrice = ti.UnitPrice,
                                Supply = s.Name,
                                LastTime = ti.LastInboundDate
                            };

                CarsMaintenance.Common.Sorting.SortableBindingList<object> toolInventories = new CarsMaintenance.Common.Sorting.SortableBindingList<object>();
                foreach (object o in query)
                {
                    toolInventories.Add(o);
                }

                dataGridViewToolInventory.DataSource = toolInventories;
            }
            else
            {
                var query = from t in SystemHelper.TMSContext.Tools
                            join ti in SystemHelper.TMSContext.ToolInventories on t.ToolID equals ti.ToolID
                            join s in SystemHelper.TMSContext.Supplies on ti.SupplyID equals s.SupplyID
                            where t.Deleted == false && t.Code.StartsWith(categoryCode)
                            && (ti.Quantity > 0 || ti.OutQuantity > 0 || ti.PrescrapQuantity > 0 || ti.ScrapQuantity > 0 || ti.RepairingQuantity > 0)
                            orderby t.Code
                            select new
                            {
                                ToolID = t.ToolID,
                                Code = t.Code,
                                Name = t.Name,
                                Dimensions = t.Dimensions,
                                Quantity = ti.Quantity,
                                OutQuantity = ti.OutQuantity,
                                PrescrapQuantity = ti.PrescrapQuantity,
                                ScrapQuantity = ti.ScrapQuantity,
                                RepairingQuantity = ti.RepairingQuantity,
                                Unit = t.Unit,
                                UnitPrice = ti.UnitPrice,
                                Supply = s.Name,
                                LastTime = ti.LastInboundDate
                            };

                CarsMaintenance.Common.Sorting.SortableBindingList<object> toolInventories = new CarsMaintenance.Common.Sorting.SortableBindingList<object>();
                foreach (object o in query)
                {
                    toolInventories.Add(o);
                }

                dataGridViewToolInventory.DataSource = toolInventories;
            }
        }
    }
}
