using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using CarsMaintenance.Common;
using CarsMaintenance.Common.Validation;
using TMS.Model;

namespace CarsMaintenance.OrderManagement
{
    public partial class CreatePurchaseOrderForm : BaseForm
    {
        public PurchaseOrder CurrentOrder { get; set; }

        public CreatePurchaseOrderForm()
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
                Control = cbSupply,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblSupply.Text)
            });
            _validationManager.Validators.Add(new RequiredValidator()
            {
                Control = cbTool,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblTool.Text)
            });
            _validationManager.Validators.Add(new DecimalValidator()
            {
                Control = txtQuantity,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.DigitalErrorMessage, lblQuantity.Text)
            });
            _validationManager.Validators.Add(new DecimalValidator()
            {
                Control = txtUnitPrice,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.DigitalErrorMessage, lblUnitPrice.Text)
            });
        }

        private void LoadData()
        {
            SystemHelper.BindComboxToSupply(cbSupply);
            SystemHelper.BindComboxToTool(cbTool);

            if (CurrentOrder == null)
                CurrentOrder = new PurchaseOrder();

            txtCode.Text = CurrentOrder.Code;
            dtPurchaseDate.Value = CurrentOrder.PurchaseDate;
            txtQuantity.Text = CurrentOrder.Quantity.ToString();
            txtUnitPrice.Text = CurrentOrder.UnitPrice.ToString();
            txtComment.Text = CurrentOrder.Comment;

            cbSupply.SelectedItem = CurrentOrder.Supply;
            cbTool.SelectedItem = CurrentOrder.Tool;
        }

        private void CreatePurchaseOrderForm_Load(object sender, EventArgs e)
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
                CurrentOrder.PurchaseDate = dtPurchaseDate.Value;

                decimal quantity = 0;
                decimal.TryParse(txtQuantity.Text, out quantity);
                CurrentOrder.Quantity = quantity;
                decimal unitPrice = 0;
                decimal.TryParse(txtUnitPrice.Text, out unitPrice);
                CurrentOrder.UnitPrice = unitPrice;
                CurrentOrder.Comment = txtComment.Text;

                CurrentOrder.Supply = cbSupply.SelectedItem as Supply;
                CurrentOrder.Tool = cbTool.SelectedItem as Tool;

                if (CurrentOrder.EntityKey == null)
                    SystemHelper.TMSContext.AddToPurchaseOrders(CurrentOrder);

                CurrentOrder.SystemUser = SystemHelper.CurrentUser;
                CurrentOrder.LastUpdateTime = System.DateTime.Now;

                ToolInventory inventory = SystemHelper.TMSContext.ToolInventories.FirstOrDefault(ti => ti.ToolID == CurrentOrder.ToolID);
                if (inventory == null)
                    inventory = SystemHelper.TMSContext.ToolInventories.CreateObject();
                inventory.Tool = CurrentOrder.Tool;
                inventory.Supply = CurrentOrder.Supply;
                inventory.LastInboundDate = CurrentOrder.PurchaseDate;
                // fix total count for evaluating unit price
                inventory.UnitPrice = ((inventory.Quantity + inventory.OutQuantity + inventory.RepairingQuantity) * inventory.UnitPrice + CurrentOrder.Quantity * CurrentOrder.UnitPrice) / (inventory.Quantity + inventory.OutQuantity + inventory.RepairingQuantity + CurrentOrder.Quantity);
                inventory.Quantity = inventory.Quantity + CurrentOrder.Quantity;

                if (CurrentOrder.ToolInventoryHistories == null || CurrentOrder.ToolInventoryHistories.Count == 0)
                {
                    ToolInventoryHistory inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
                    inventoryHistory.Account = "1000";
                    inventoryHistory.PurchaseOrder = CurrentOrder;
                    inventoryHistory.ToolInventoryHistoryDate = CurrentOrder.PurchaseDate;
                    inventoryHistory.Supply = CurrentOrder.Supply;
                    inventoryHistory.Tool = CurrentOrder.Tool;
                    inventoryHistory.Quantity = CurrentOrder.Quantity;
                    inventoryHistory.UnitPrice = CurrentOrder.UnitPrice;
                }

                SystemHelper.TMSContext.SaveChanges();

                DialogResult = DialogResult.OK;
            });
        }

        private void cbSupply_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !SystemHelper.ValidateComboxForSupply(cbSupply);
        }

        private void cbTool_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !SystemHelper.ValidateComboxForTool(cbTool);
        }
    }
}
