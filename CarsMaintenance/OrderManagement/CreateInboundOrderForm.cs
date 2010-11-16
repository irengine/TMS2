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
        public OutboundOrder TransferOrder { get; set; }
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
            SystemHelper.BindComboBoxToScrapReason(dataGridViewDetail.Columns["ScrapReason"] as DataGridViewComboBoxColumn);

            // Set data object value
            if (CurrentOrder.SystemUser == null)
                CurrentOrder.SystemUser = SystemHelper.CurrentUser;

            txtCode.Text = CurrentOrder.Code;
            dtInboundDate.Value = CurrentOrder.InboundDate;

            cbCustomer.SelectedItem = ReferenceOrder.Customer;
            cbSystemUser.SelectedItem = CurrentOrder.SystemUser;

            foreach (OutboundOrderDetail item in ReferenceOrder.Items)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                object[] row = { item.OutboundOrderDetailID, item.Tool.Code, item.Quantity, item.Tool.Name, item.Tool.Dimensions, item.Balance, item.UnitPrice };
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
                if (!ValidateTransferOrder())
                    return;

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

                //CurrentOrder.SystemUser = SystemHelper.CurrentUser;
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
                        item.TransferQuantity = transferQuantity;
                        item.PrescrapQuantity = prescrapQuantity;
                        item.ScrapReason = dgvr.Cells["ScrapReason"].Value as string;

                        referenceItem.Balance -= item.Quantity + item.TransferQuantity + item.PrescrapQuantity;

                        CurrentOrder.Items.Add(item);

                        OrderManager.Return(CurrentOrder, item);

                        // for prescrap order
                        if (item.PrescrapQuantity != 0)
                        {
                            ScrapOrderDetail scrapItem = new ScrapOrderDetail();
                            scrapItem.Tool = item.Tool;
                            scrapItem.OutboundOrderDetail = item.OutboundOrderDetail;
                            scrapItem.ScrapDate = item.InboundDate;
                            scrapItem.PrescrapQuantity = item.PrescrapQuantity;
                            scrapItem.UnitPrice = item.UnitPrice;
                            scrapItem.ScrapReason = item.ScrapReason;

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
                if (TransferOrder != null)
                    FormsManager.OpenForm(typeof(CarsMaintenance.Reports.OutboundOrderReport), new object[] { "ID", TransferOrder.OutboundOrderID });

                DialogResult = DialogResult.OK;
            });
        }

        private void dataGridViewDetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue == null || e.FormattedValue.ToString().Length == 0)
                return;

            // add new column item balance, so column index should be plus 1.
            switch (e.ColumnIndex)
            {
                case 7:
                case 8:
                case 9:
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

         private void TransferOrderDetail(OutboundOrder transferOrder)
        {
            if (transferOrder.Items.Count == 0)
            {
                foreach (DataGridViewRow dgvr in dataGridViewDetail.Rows)
                {
                    if (!dgvr.IsNewRow)
                    {
                        decimal transferQuantity = ConvertToNumber(dgvr.Cells["TransferQuantity"].Value);
                        if (transferQuantity > 0)
                        {
                            OutboundOrderDetail item = new OutboundOrderDetail();

                            decimal unitPrice = ConvertToNumber(dgvr.Cells["ItemUnitPrice"].Value);

                            string code = dgvr.Cells["ItemCode"].Value.ToString();
                            Tool t = SystemHelper.TMSContext.Tools.FirstOrDefault(s => s.Code == code);
                            item.Tool = t;
                            item.Quantity = transferQuantity;
                            item.Balance = transferQuantity;
                            item.UnitPrice = unitPrice;
                            item.OutboundDate = CurrentOrder.InboundDate;

                            transferOrder.Items.Add(item);
                        }
                    }
                }
            }
        }

        // determine if transfer quantity in inbound order is more than 0.
        private bool IsExistsTransferItems()
        {
            foreach (DataGridViewRow dgvr in dataGridViewDetail.Rows)
            {
                if (!dgvr.IsNewRow)
                {
                    decimal transferQuantity = ConvertToNumber(dgvr.Cells["TransferQuantity"].Value);
                    if (transferQuantity > 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool ValidateTransferOrder()
        {
            if (IsExistsTransferItems())
            {
                using (CreateOutboundOrderForm form = new CreateOutboundOrderForm())
                {
                    TransferOrder = new OutboundOrder();
                    TransferOrderDetail(TransferOrder);

                    form.CurrentOrder = TransferOrder;
                    form.CurrentMode = CreateOutboundOrderForm.MODE_TRANSFER;

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        return true;
                    }
                    else
                    {
                        // deep detach outbound order object.
                        List<OutboundOrderDetail> lt = new List<OutboundOrderDetail>();
                        foreach (OutboundOrderDetail item in TransferOrder.Items)
                        {
                            lt.Add(item);
                        }
                        foreach (OutboundOrderDetail item in lt)
                        {
                            SystemHelper.RefreshOrder(item);
                        }
                        TransferOrder.Items.Clear();
                        SystemHelper.RefreshOrder(TransferOrder);
                        TransferOrder = null;
                        return false;
                    }
                }
            }
            else
            {
                return true;
            }
        }

        private void dataGridViewDetail_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dataGridViewDetail.Rows[e.RowIndex];
            e.Cancel = !(IsLessThanBalance(row) && IsIncludeReason(row));
        }

        private bool IsLessThanBalance(DataGridViewRow row)
        {
            // validate row value, quantity + transfer quantity + prescrap quantity <= balance
            decimal balance = ConvertToNumber(row.Cells["ItemBalance"].Value);
            decimal quantity = ConvertToNumber(row.Cells["Quantity"].Value);
            decimal transferQuantity = ConvertToNumber(row.Cells["TransferQuantity"].Value);
            decimal prescrapQuantity = ConvertToNumber(row.Cells["PrescrapQuantity"].Value);

            if (balance >= (quantity + transferQuantity + prescrapQuantity))
            {
                row.ErrorText = "";
                return true;
            }
            else
            {
                row.ErrorText = "归还数、转借数和预报废数大于未归还数.";
                return false;
            }
        }

        private bool IsIncludeReason(DataGridViewRow row)
        {
            decimal prescrapQuantity = ConvertToNumber(row.Cells["PrescrapQuantity"].Value);

            if (prescrapQuantity == 0)
            {
                row.ErrorText = "";
                return true;
            }
            else if (row.Cells["ScrapReason"].Value != null && row.Cells["ScrapReason"].Value.ToString().Length > 0)
            {
                row.ErrorText = "";
                return true;
            }
            else
            {
                row.ErrorText = "缺少报废原因.";
                return false;
            }
        }

        private decimal ConvertToNumber(object o)
        {
            if (o == null || o.ToString().Length == 0)
                return 0;

            decimal i;
            if (decimal.TryParse(o.ToString(), out i))
                return i;
            else
                return 0;
        }

        private void btnReturnAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridViewDetail.Rows)
            {
                if (!dgvr.IsNewRow)
                {
                    decimal balance = ConvertToNumber(dgvr.Cells["ItemBalance"].Value);
                    dgvr.Cells["Quantity"].Value = balance;
                    dgvr.Cells["TransferQuantity"].Value = null;
                    dgvr.Cells["PrescrapQuantity"].Value = null;
                    dgvr.Cells["ScrapReason"].Value = null;
                }
            }
        }

        private void btnTransferAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridViewDetail.Rows)
            {
                if (!dgvr.IsNewRow)
                {
                    decimal balance = ConvertToNumber(dgvr.Cells["ItemBalance"].Value);
                    dgvr.Cells["Quantity"].Value = null;
                    dgvr.Cells["TransferQuantity"].Value = balance;
                    dgvr.Cells["PrescrapQuantity"].Value = null;
                    dgvr.Cells["ScrapReason"].Value = null;
                }
            }
        }
    }
}
