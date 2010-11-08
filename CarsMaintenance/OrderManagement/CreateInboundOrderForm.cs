using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarsMaintenance.Common;
using CarsMaintenance.Common.Validation;
using TMS.Model;

namespace CarsMaintenance.OrderManagement
{
    public partial class CreateInboundOrderForm : BaseForm
    {
        public OutboundOrder ReferenceOrder { get; set; }
        public InboundOrder CurrentOrder { get; set; }

        public CreateInboundOrderForm()
        {
            InitializeComponent();
            RegisterControlsForValidation();
        }
        
        private ValidationManager _validationManager;

        private void RegisterControlsForValidation()
        {
            _validationManager = new ValidationManager()
            {
                Provider = _errorProvider
            };
            // Do not validate code because of auto generation
            //_validationManager.Validators.Add(new RequiredValidator()
            //{
            //    Control = txtCode,
            //    ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblCode.Text)
            //});
            _validationManager.Validators.Add(new RequiredValidator()
            {
                Control = cbCustomer,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblCustomer.Text)
            });
        }

        private void LoadData()
        {
            SystemHelper.BindComboxToCustomer(cbCustomer);
            SystemHelper.BindComboxToSystemUser(cbSystemUser);

            // Set data object value
            if (CurrentOrder == null)
            {
                CurrentOrder = new InboundOrder();
                CurrentOrder.SystemUser = SystemHelper.CurrentUser;
            }

            txtCode.Text = CurrentOrder.Code;
            dtInboundDate.Value = CurrentOrder.InboundDate;

            cbCustomer.SelectedItem = ReferenceOrder.Customer;
            cbSystemUser.SelectedItem = CurrentOrder.SystemUser;

            foreach (OutboundOrderDetail item in ReferenceOrder.Items)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                object[] row = { item.OutboundOrderDetailID, item.Tool.Code, item.Quantity, item.Tool.Name, item.Tool.Dimensions };
                dataGridViewDetail.Rows.Add(row);
            }
        }

        private void CreateInboundOrderForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void _saveButton_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                if (!_validationManager.Validate())
                {
                    return;
                }

                CurrentOrder.Code = txtCode.Text;
                CurrentOrder.InboundDate = dtInboundDate.Value;

                CurrentOrder.Customer = cbCustomer.SelectedItem as Unit;
                CurrentOrder.SystemUser = cbSystemUser.SelectedItem as SystemUser;

                CurrentOrder.OutboundOrder = ReferenceOrder;

                if (CurrentOrder.EntityKey == null)
                    SystemHelper.TMSContext.AddToInboundOrders(CurrentOrder);

                CurrentOrder.SystemUser = SystemHelper.CurrentUser;
                CurrentOrder.LastUpdateTime = System.DateTime.Now;

                ScrapOrder scrapOrder = new ScrapOrder();

                // Iterate all rows
                foreach (DataGridViewRow dgvr in dataGridViewDetail.Rows)
                {
                    if (!dgvr.IsNewRow)
                    {
                        // for inbound detail
                        int itemID = 0;
                        int.TryParse(dgvr.Cells["ItemID"].Value.ToString(), out itemID);
                        OutboundOrderDetail referenceItem = SystemHelper.TMSContext.OutboundOrderDetails.FirstOrDefault(s => s.OutboundOrderDetailID == itemID);

                        decimal quantity = 0;
                        if (dgvr.Cells["Quantity"].Value != null)
                            decimal.TryParse(dgvr.Cells["Quantity"].Value.ToString(), out quantity);

                        decimal prescrapQuantity = 0;
                        if (dgvr.Cells["PrescrapQuantity"].Value != null)
                            decimal.TryParse(dgvr.Cells["PrescrapQuantity"].Value.ToString(), out prescrapQuantity);

                        decimal transferQuantity = 0;
                        if (dgvr.Cells["TransferQuantity"].Value != null)
                            decimal.TryParse(dgvr.Cells["TransferQuantity"].Value.ToString(), out transferQuantity);

                        if (quantity == 0 && prescrapQuantity == 0 && transferQuantity == 0)
                            continue;

                        InboundOrderDetail item = SystemHelper.TMSContext.InboundOrderDetails.CreateObject();
                        item.InboundDate = CurrentOrder.LastUpdateTime;
                        item.OutboundOrderDetail = referenceItem;
                        item.Tool = referenceItem.Tool;
                        item.UnitPrice = referenceItem.UnitPrice;
                        item.Quantity = quantity;
                        item.PrescrapQuantity = prescrapQuantity;
                        item.TransferQuantity = transferQuantity;

                        CurrentOrder.Items.Add(item);

                        // for inventory and inventory history
                        ToolInventory inventory = SystemHelper.TMSContext.ToolInventories.FirstOrDefault(ti => ti.ToolID == item.ToolID);
                        inventory.Tool = item.Tool;
                        inventory.OutQuantity = inventory.OutQuantity - item.Quantity - item.TransferQuantity;

                        ToolInventoryHistory inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
                        inventoryHistory.Customer = CurrentOrder.Customer;
                        inventoryHistory.ToolInventoryHistoryDate = CurrentOrder.InboundDate;
                        inventoryHistory.Tool = item.Tool;
                        inventoryHistory.Quantity = item.Quantity + item.TransferQuantity;
                        inventoryHistory.UnitPrice = item.UnitPrice;
                        inventoryHistory.OutboundOrder = ReferenceOrder;
                        inventoryHistory.OutboundOrderDetail = referenceItem;

                        // for prescrap order
                        if (item.PrescrapQuantity != 0)
                        {
                            ScrapOrderDetail scrapItem = new ScrapOrderDetail();
                            scrapItem.Tool = item.Tool;
                            scrapItem.OutboundOrderDetail = item.OutboundOrderDetail;
                            scrapItem.ScrapDate = item.InboundDate;
                            scrapItem.PrescrapQuantity = item.PrescrapQuantity;
                            scrapItem.UnitPrice = item.UnitPrice;

                            scrapOrder.Items.Add(scrapItem);
                        }
                    }
                }

                if (scrapOrder.Items.Count > 0)
                {
                    scrapOrder.OutboundOrder = CurrentOrder.OutboundOrder;
                    scrapOrder.ScrapDate = CurrentOrder.InboundDate;
                    scrapOrder.Customer = CurrentOrder.Customer;
                    scrapOrder.SystemUser = CurrentOrder.SystemUser;
                    scrapOrder.LastUpdateTime = CurrentOrder.LastUpdateTime;
                    SystemHelper.TMSContext.AddToScrapOrders(scrapOrder);
                }

                SystemHelper.TMSContext.SaveChanges();

                DialogResult = DialogResult.OK;
            });
        }

        private void dataGridViewDetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue == null || e.FormattedValue.ToString().Length == 0)
                return;

            switch (e.ColumnIndex)
            {
                case 5:
                case 6:
                case 7:
                    decimal quantity = 0;
                    if (!decimal.TryParse(e.FormattedValue.ToString(), out quantity))
                        e.Cancel = true;
                    break;

            }
        }

        private void cbCustomer_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !SystemHelper.ValidateComboxForCustomer(cbCustomer);
        }

        private void cbSystemUser_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !SystemHelper.ValidateComboxForSystemUser(cbSystemUser);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            using (CreateOutboundOrderForm form = new CreateOutboundOrderForm())
            {
                form.CurrentOrder = new OutboundOrder();
                form.CurrentMode = CreateOutboundOrderForm.MODE_CREATE;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
    }
}
