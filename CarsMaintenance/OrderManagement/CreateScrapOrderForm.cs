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
    public partial class CreateScrapOrderForm : Form
    {
        //public OutboundOrder ReferenceOrder { get; set; }
        public ScrapOrder CurrentOrder { get; set; }
        public string CurrentMode { get; set; }

        public static string MODE_BROWSE = "BROWSE";
        public static string MODE_CREATE = "CREATE";
        public static string MODE_CREATESELF = "CREATESELF";

        public CreateScrapOrderForm()
        {
            InitializeComponent();
            RegisterControlsForValidation();
        }

        public CreateScrapOrderForm(string Mode)
        {
            CurrentMode = Mode;
            InitializeComponent();
            SetControls();
            RegisterControlsForValidation();
        }

        private void SetControls()
        {
            if (CurrentMode == MODE_CREATESELF)
            {
                dataGridViewDetail.AllowUserToAddRows = true;
                dataGridViewDetail.AllowUserToDeleteRows = true;

                dataGridViewDetail.Columns[1].ReadOnly = false;
                dataGridViewDetail.Columns[2].Visible = false;
                dataGridViewDetail.Columns[5].Visible = false;
                dataGridViewDetail.Columns[6].Visible = false;
            }
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
            // Customer can be null when create self scrap order
            //_validationManager.Validators.Add(new RequiredValidator()
            //{
            //    Control = cbCustomer,
            //    ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblCustomer.Text)
            //});
        }

        private void LoadData()
        {
            SystemHelper.BindComboxToCustomer(cbCustomer);
            SystemHelper.BindComboxToSystemUser(cbSystemUser);

            // Set data object value
            if (CurrentOrder == null)
            {
                CurrentOrder = new ScrapOrder();
                CurrentMode = MODE_CREATESELF;
            }

            if (CurrentMode == MODE_CREATESELF)
            {
                CurrentOrder.Status = 1;
                CurrentOrder.SystemUser = SystemHelper.CurrentUser;
            }

            txtCode.Text = CurrentOrder.Code;
            dtScrapDate.Value = CurrentOrder.ScrapDate;

            cbCustomer.SelectedItem = CurrentOrder.Customer;
            cbSystemUser.SelectedItem = CurrentOrder.SystemUser;

            foreach (ScrapOrderDetail item in CurrentOrder.Items)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                object[] row = { item.ScrapOrderDetailID, item.Tool.Code, item.PrescrapQuantity, item.Tool.Name, item.Tool.Dimensions, item.Quantity, item.RepairingQuantity, item.ScrapQuantity, item.ScrapReason };
                dataGridViewDetail.Rows.Add(row);
            }
        }

        private void EnableForm()
        {
            if (CurrentMode == MODE_BROWSE)
                _saveButton.Enabled = false;
        }

        private void CreateScrapOrderForm_Load(object sender, EventArgs e)
        {
            LoadData();
            EnableForm();
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
                CurrentOrder.ScrapDate = dtScrapDate.Value;

                CurrentOrder.Customer = cbCustomer.SelectedItem as Unit;
                CurrentOrder.SystemUser = cbSystemUser.SelectedItem as SystemUser;

                if (CurrentOrder.EntityKey == null)
                    SystemHelper.TMSContext.AddToScrapOrders(CurrentOrder);

                CurrentOrder.SystemUser = SystemHelper.CurrentUser;
                CurrentOrder.LastUpdateTime = System.DateTime.Now;

                // Iterate all rows
                foreach (DataGridViewRow dgvr in dataGridViewDetail.Rows)
                {
                    if (!dgvr.IsNewRow)
                    {
                        // for scrap detail
                        string code = dgvr.Cells["ItemCode"].Value.ToString();
                        Tool t = SystemHelper.TMSContext.Tools.FirstOrDefault(s => s.Code == code);

                        decimal scrapQuantity = 0;
                        decimal.TryParse(dgvr.Cells["ScrapQuantity"].Value.ToString(), out scrapQuantity);

                        ScrapOrderDetail item;

                        if (dgvr.Cells["ItemID"].Value == null)
                        {
                            item = SystemHelper.TMSContext.ScrapOrderDetails.CreateObject();
                            item.Tool = t;
                            item.UnitPrice = t.ToolInventory.UnitPrice;
                            item.ScrapQuantity = scrapQuantity;
                            item.ScrapReason = dgvr.Cells["ScrapReason"].Value as string;
                            item.ScrapDate = CurrentOrder.LastUpdateTime;

                            CurrentOrder.Items.Add(item);
                        }
                        else
                        {
                            int itemID = 0;
                            int.TryParse(dgvr.Cells["ItemID"].Value.ToString(), out itemID);
                            item = SystemHelper.TMSContext.ScrapOrderDetails.FirstOrDefault(s => s.ScrapOrderDetailID == itemID);
                            item.ScrapQuantity = scrapQuantity;
                            item.ScrapReason = dgvr.Cells["ScrapReason"].Value as string;
                            item.ScrapDate = CurrentOrder.LastUpdateTime;
                        }


                        // for inventory and inventory history
                        ToolInventory inventory = SystemHelper.TMSContext.ToolInventories.FirstOrDefault(ti => ti.ToolID == item.ToolID);
                        inventory.Tool = item.Tool;
                        inventory.ScrapQuantity = inventory.ScrapQuantity + item.ScrapQuantity;

                        ToolInventoryHistory inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
                        inventoryHistory.Customer = CurrentOrder.Customer;
                        inventoryHistory.ToolInventoryHistoryDate = CurrentOrder.ScrapDate;
                        inventoryHistory.Tool = item.Tool;
                        inventoryHistory.Quantity = item.ScrapQuantity;
                        inventoryHistory.UnitPrice = item.UnitPrice;

                        // TODO: add history
                        //inventoryHistory.OutboundOrder = CurrentOrder;
                        //inventoryHistory.OutboundOrderDetail = item;
                        //inventoryHistory.ScrapOrder = CurrentOrder;
                        //inventoryHistory.ScrapOrderDetail = item;
                    }
                }

                CurrentOrder.Status = 1;

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
                case 1:
                    string code = e.FormattedValue.ToString();
                    Tool t = SystemHelper.TMSContext.Tools.FirstOrDefault(s => s.Code == code);
                    if (t == null)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        dataGridViewDetail.Rows[e.RowIndex].Cells["ItemName"].Value = t.Name;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["ItemDimensions"].Value = t.Dimensions;
                    }
                    break;
                    // TODO: add other columns to verify decimal
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
    }
}
