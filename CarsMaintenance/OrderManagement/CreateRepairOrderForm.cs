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
    public partial class CreateRepairOrderForm : Form
    {
        //public OutboundOrder ReferenceOrder { get; set; }
        public RepairOrder CurrentOrder { get; set; }
        public string CurrentMode { get; set; }

        public static string MODE_BROWSE = "BROWSE";
        public static string MODE_CREATE = "CREATE";
        public static string MODE_CREATESELF = "CREATESELF";

        public CreateRepairOrderForm()
        {
            InitializeComponent();
            RegisterControlsForValidation();
        }

        public CreateRepairOrderForm(string Mode)
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
            }
        }

        private void LoadData()
        {
            SystemHelper.BindComboxToCustomer(cbCustomer);
            SystemHelper.BindComboxToSystemUser(cbSystemUser);
            SystemHelper.BindComboBoxToScrapReason(dataGridViewDetail.Columns["ScrapReason"] as DataGridViewComboBoxColumn);

            // Set data object value
            if (CurrentOrder == null)
            {
                CurrentOrder = new RepairOrder();
                CurrentMode = MODE_CREATESELF;
            }

            if (CurrentMode == MODE_CREATESELF)
            {
                CurrentOrder.Status = 1;
                CurrentOrder.SystemUser = SystemHelper.CurrentUser;
            }

            txtCode.Text = CurrentOrder.Code;
            dtRepairDate.Value = CurrentOrder.RepairDate;

            cbCustomer.SelectedItem = CurrentOrder.Customer;
            cbSystemUser.SelectedItem = CurrentOrder.SystemUser;

            foreach (RepairOrderDetail item in CurrentOrder.Items)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                object[] row = { item.RepairOrderDetailID, item.Tool.Code, item.Tool.Name, item.Tool.Dimensions, item.RepairingQuantity, item.Quantity, item.ScrapQuantity, item.ScrapReason };
                dataGridViewDetail.Rows.Add(row);
            }
        }

        private void EnableForm()
        {
            if (CurrentMode == MODE_BROWSE)
                _saveButton.Enabled = false;
        }

        private void CreateRepairOrderForm_Load(object sender, EventArgs e)
        {
            LoadData();
            EnableForm();
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

        private void _saveButton_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                if (!_validationManager.Validate())
                {
                    return;
                }

                CurrentOrder.Code = txtCode.Text;
                CurrentOrder.RepairDate = dtRepairDate.Value;

                CurrentOrder.Customer = cbCustomer.SelectedItem as Unit;
                CurrentOrder.SystemUser = cbSystemUser.SelectedItem as SystemUser;

                if (CurrentOrder.EntityKey == null)
                    SystemHelper.TMSContext.AddToRepairOrders(CurrentOrder);

                //CurrentOrder.SystemUser = SystemHelper.CurrentUser;
                CurrentOrder.LastUpdateTime = System.DateTime.Now;

                // Iterate all rows
                foreach (DataGridViewRow dgvr in dataGridViewDetail.Rows)
                {
                    if (!dgvr.IsNewRow)
                    {
                        // for repair detail
                        string code = dgvr.Cells["ItemCode"].Value.ToString();
                        Tool t = SystemHelper.TMSContext.Tools.FirstOrDefault(s => s.Code == code);

                        decimal repairingQuantity = 0;
                        decimal.TryParse(dgvr.Cells["ItemQuantity"].Value.ToString(), out repairingQuantity);

                        decimal scrapQuantity = 0;
                        decimal.TryParse(dgvr.Cells["ScrapQuantity"].Value.ToString(), out scrapQuantity);

                        decimal quantity = 0;
                        decimal.TryParse(dgvr.Cells["Quantity"].Value.ToString(), out quantity);

                        RepairOrderDetail item;

                        if (dgvr.Cells["ItemID"].Value == null)
                        {
                            item = SystemHelper.TMSContext.RepairOrderDetails.CreateObject();
                            item.Tool = t;
                            item.UnitPrice = t.ToolInventory.UnitPrice;
                            item.RepairingQuantity = repairingQuantity;
                            item.Quantity = quantity;
                            item.ScrapQuantity = scrapQuantity;
                            item.ScrapReason = dgvr.Cells["ScrapReason"].Value as string;
                            item.RepairDate = CurrentOrder.LastUpdateTime;

                            CurrentOrder.Items.Add(item);
                        }
                        else
                        {
                            int itemID = 0;
                            int.TryParse(dgvr.Cells["ItemID"].Value.ToString(), out itemID);
                            item = SystemHelper.TMSContext.RepairOrderDetails.FirstOrDefault(s => s.RepairOrderDetailID == itemID);
                            item.RepairingQuantity = repairingQuantity;
                            item.Quantity = quantity;
                            item.ScrapQuantity = scrapQuantity;
                            item.ScrapReason = dgvr.Cells["ScrapReason"].Value as string;
                            item.RepairDate = CurrentOrder.LastUpdateTime;
                        }

                        // for inventory and inventory history
                        OrderManager.Repair(CurrentOrder, item);
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
                //// TODO: add other columns to verify decimal
                //case 7:
                //    decimal quantity = 0;
                //    if (!decimal.TryParse(e.FormattedValue.ToString(), out quantity))
                //        e.Cancel = true;
                //    break;

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
