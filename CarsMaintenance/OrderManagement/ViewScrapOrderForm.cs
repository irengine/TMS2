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
    public partial class ViewScrapOrderForm : BaseForm
    {
        public ViewScrapOrderForm()
        {
            InitializeComponent();
        }

        protected void LoadData()
        {
            var query = from o in SystemHelper.TMSContext.ScrapOrders
                        join it in SystemHelper.TMSContext.ScrapOrderDetails on o.ScrapOrderID equals it.ScrapOrderID
                        join t in SystemHelper.TMSContext.Tools on it.ToolID equals t.ToolID
                        orderby o.ScrapDate
                        select new
                        {
                            o.ScrapOrderID,
                            o.ScrapDate,
                            ItemName = t.Name,
                            t.Dimensions,
                            it.PrescrapQuantity,
                            it.ScrapReason,
                            it.ScrapQuantity,
                            it.Quantity,
                            it.RepairingQuantity,
                            Status = (o.Status == 0 ? "预报废" : "报废")
                        };

            CarsMaintenance.Common.Sorting.SortableBindingList<object> scrapOrders = new CarsMaintenance.Common.Sorting.SortableBindingList<object>();
            foreach (object o in query)
            {
                scrapOrders.Add(o);
            }

            dataGridViewScrapOrder.DataSource = scrapOrders;
        }

        private void FormLoad(object sender, EventArgs e)
        {
            LoadData();
        }

        private ScrapOrder GetSelectedOrder()
        {
            if (dataGridViewScrapOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择报废单!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }
            int id;
            if (!int.TryParse(Convert.ToString(dataGridViewScrapOrder.SelectedRows[0].Cells[0].Value), out id))
            {
                MessageBox.Show("请重新选择报废单!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }

            return SystemHelper.TMSContext.ScrapOrders.First(u => u.ScrapOrderID == id);
        }

        private void Create()
        {
            using (CreateScrapOrderForm form = new CreateScrapOrderForm())
            {
                form.CurrentOrder = GetSelectedOrder();
                form.CurrentMode = CreateScrapOrderForm.MODE_CREATE;

                if (form.CurrentOrder.Status == 1)
                {
                    MessageBox.Show("已处理，请重新选择报废单!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

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
            using (CreateScrapOrderForm form = new CreateScrapOrderForm())
            {
                form.CurrentOrder = GetSelectedOrder();
                form.CurrentMode = CreateScrapOrderForm.MODE_BROWSE;

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
            using (CreateScrapOrderForm form = new CreateScrapOrderForm(CreateScrapOrderForm.MODE_CREATESELF))
            {
                form.CurrentOrder = new ScrapOrder();
                form.CurrentOrder.Status = 1;
                form.CurrentMode = CreateScrapOrderForm.MODE_CREATESELF;

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

        private void toolStripMenuItemBrowseScrapOrder_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Browse);
        }

        private void toolStripMenuItemCreateScrapOrder_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Create);
        }

        private void toolStripMenuItemCreateSelfScrapOrder_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(CreateSelf);
        }

        private void dataGridViewScrapOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Browse);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBeginDate.Value.Date;
            DateTime endDate = dtEndDate.Value.Date.AddDays(1);
            var query = from o in SystemHelper.TMSContext.ScrapOrders
                        join it in SystemHelper.TMSContext.ScrapOrderDetails on o.ScrapOrderID equals it.ScrapOrderID
                        join t in SystemHelper.TMSContext.Tools on it.ToolID equals t.ToolID
                        where o.ScrapDate >= beginDate && o.ScrapDate <= endDate
                        orderby o.ScrapDate
                        select new {
                            o.ScrapOrderID,
                            o.ScrapDate,
                            ItemName = t.Name,
                            t.Dimensions,
                            it.PrescrapQuantity,
                            it.ScrapReason,
                            it.ScrapQuantity,
                            it.Quantity,
                            it.RepairingQuantity,
                            Status = (o.Status == 0 ? "待报废" : "已报废")
                        };

            dataGridViewScrapOrder.DataSource = query;
        }
    }
}
