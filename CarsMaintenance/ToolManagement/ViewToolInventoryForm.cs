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
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Code";
            column.Name = "工属具编码";
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "名称";
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Dimensions";
            column.Name = "规格";
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Quantity";
            column.Name = "数量";
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "OutQuantity";
            column.Name = "外借数";
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PrescrapQuantity";
            column.Name = "预报废数";
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "ScrapQuantity";
            column.Name = "报废数";
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "RepairingQuantity";
            column.Name = "修理数";
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Unit";
            column.Name = "单位";
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "UnitPrice";
            column.Name = "单价";
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Supply";
            column.Name = "供应商";
            dataGridViewToolInventory.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "LastTime";
            column.Name = "最后入库时间";
            dataGridViewToolInventory.Columns.Add(column);
        }

        protected void LoadData()
        {
            var query = from t in SystemHelper.TMSContext.Tools
                        join ti in SystemHelper.TMSContext.ToolInventories on t.ToolID equals ti.ToolID
                        join s in SystemHelper.TMSContext.Supplies on ti.SupplyID equals s.SupplyID
                        where t.Deleted == false
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
    }
}
