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
    public partial class CreateOutboundOrderForm : BaseForm
    {
        public OutboundOrder CurrentOrder { get; set; }
        public string CurrentMode { get; set; }
        public int ItemCount { get; set; }

        public static string MODE_BROWSE = "BROWSE";
        public static string MODE_CREATE = "CREATE";
        public static string MODE_APPEND = "APPEND";
        public static string MODE_TRANSFER = "TRANSFER";

        public CreateOutboundOrderForm()
        {
            InitializeComponent();
            SetControls();
            RegisterControlsForValidation();
        }

        private void SetControls()
        {
            txtBerth.Enabled = true;
            txtMachine.Enabled = true;
            txtShip.Enabled = true;
            txtHatch.Enabled = true;
            txtCargo.Enabled = true;
            txtQuantity.Enabled = true;
            txtProcess.Enabled = true;

            rbDay.Enabled = true;
            rbNight.Enabled = true;
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
                Control = txtJob,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblJob.Text)
            });
            _validationManager.Validators.Add(new RequiredValidator()
            {
                Control = cbJobPosition,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblJobPosition.Text)
            });
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
            SystemHelper.BindComboxToJobPosition(cbJobPosition);
            SystemHelper.BindComboxToJobType(cbJobType);

            // Set data object value
            if (CurrentOrder == null)
            {
                CurrentOrder = new OutboundOrder();
                CurrentMode = MODE_CREATE;
            }

            if (CurrentMode == MODE_CREATE)
            {
                CurrentOrder.Version = 0;
                CurrentOrder.SystemUser = SystemHelper.CurrentUser;
                CurrentOrder.ClassType = GetCurrentClassType();
                ItemCount = 0;
            }
            else if (CurrentMode == MODE_APPEND)
            {
                CurrentOrder.Version ++;
                CurrentOrder.SystemUser = SystemHelper.CurrentUser;
                ItemCount = CurrentOrder.Items.Count;
            }
            else if (CurrentMode == MODE_BROWSE)
            {
                ItemCount = CurrentOrder.Items.Count;
            }
            else if (CurrentMode == MODE_TRANSFER)
            {
                CurrentOrder.Version = 0;
                CurrentOrder.SystemUser = SystemHelper.CurrentUser;
                CurrentOrder.ClassType = GetCurrentClassType();
                ItemCount = CurrentOrder.Items.Count;
            }

            txtCode.Text = CurrentOrder.Code;
            dtOutboundDate.Value = CurrentOrder.OutboundDate;
            txtVersion.Text = CurrentOrder.Version.ToString();
            txtJob.Text = CurrentOrder.Job;
            cbJobPosition.Text = CurrentOrder.JobPosition;
            cbJobType.Text = CurrentOrder.JobType;

            txtBerth.Text = CurrentOrder.Berth;
            txtMachine.Text = CurrentOrder.Machine;
            txtShip.Text = CurrentOrder.Ship;
            txtHatch.Text = CurrentOrder.Hatch;
            txtCargo.Text = CurrentOrder.Cargo;
            txtQuantity.Text = CurrentOrder.Quantity;
            txtProcess.Text = CurrentOrder.Process;

            if (CurrentOrder.ClassType == 1)
            {
                rbDay.Checked = true;
                rbNight.Checked = false;
            }
            else if (CurrentOrder.ClassType == 2)
            {
                rbDay.Checked = false;
                rbNight.Checked = true;
            }


            cbCustomer.SelectedItem = CurrentOrder.Customer;
            cbSystemUser.SelectedItem = CurrentOrder.SystemUser;

            foreach (OutboundOrderDetail item in CurrentOrder.Items)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                object[] row = { item.Tool.Code, item.Quantity, item.Tool.Name, item.Tool.Dimensions };
                dataGridViewDetail.Rows.Add(row);
            }
        }

        private int GetCurrentClassType()
        {
            if (System.DateTime.Now.Hour >= 8 && System.DateTime.Now.Hour < 17)
                return 1;
            else
                return 2;
        }

        private void EnableForm()
        {
            if (CurrentMode == MODE_BROWSE)
                _saveButton.Enabled = false;
        }

        private void CreateOutboundOrderForm_Load(object sender, EventArgs e)
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
                CurrentOrder.OutboundDate = dtOutboundDate.Value;

                int version = 0;
                int.TryParse(txtVersion.Text, out version);
                CurrentOrder.Version = version;

                CurrentOrder.Job = txtJob.Text;
                CurrentOrder.JobPosition = cbJobPosition.Text;
                CurrentOrder.JobType = cbJobType.Text;
                CurrentOrder.Berth = txtBerth.Text;
                CurrentOrder.Machine = txtMachine.Text;
                CurrentOrder.Ship = txtShip.Text;
                CurrentOrder.Hatch = txtHatch.Text;
                CurrentOrder.Cargo = txtCargo.Text;
                CurrentOrder.Quantity = txtQuantity.Text;
                CurrentOrder.Process = txtProcess.Text;

                if (rbDay.Checked)
                    CurrentOrder.ClassType = 1;
                else if (rbNight.Checked)
                    CurrentOrder.ClassType = 2;

                CurrentOrder.Customer = cbCustomer.SelectedItem as Unit;
                CurrentOrder.SystemUser = cbSystemUser.SelectedItem as SystemUser;

                if (CurrentOrder.EntityKey == null)
                    SystemHelper.TMSContext.AddToOutboundOrders(CurrentOrder);

                // Don't set current user because user may change it.
                // CurrentOrder.SystemUser = SystemHelper.CurrentUser;
                CurrentOrder.LastUpdateTime = System.DateTime.Now;

                // Iterate all rows
                foreach (DataGridViewRow dgvr in dataGridViewDetail.Rows)
                {
                    if (!dgvr.IsNewRow && dgvr.Index >= ItemCount)
                    {
                        // for outbound detail
                        decimal quantity = 0;
                        decimal.TryParse(dgvr.Cells["ItemQuantity"].Value.ToString(), out quantity);

                        string code = dgvr.Cells["ItemCode"].Value.ToString();
                        Tool t = SystemHelper.TMSContext.Tools.FirstOrDefault(s => s.Code == code);

                        OutboundOrderDetail item = SystemHelper.TMSContext.OutboundOrderDetails.CreateObject();
                        item.Version = CurrentOrder.Version;
                        item.Tool = t;
                        item.Quantity = quantity;
                        item.Balance = quantity;
                        item.UnitPrice = t.ToolInventory.UnitPrice;
                        item.OutboundDate = CurrentOrder.LastUpdateTime;

                        CurrentOrder.Items.Add(item);

                        OrderManager.Lend(CurrentOrder, item);
                    }
                }

                if (CurrentMode == MODE_TRANSFER)
                {
                    foreach (OutboundOrderDetail item in CurrentOrder.Items)
                    {
                        OrderManager.Lend(CurrentOrder, item);
                    }
                }
                else // if the order is transfer order, do not save order, it would be saved at origin inbound order.
                {
                    SystemHelper.TMSContext.SaveChanges();
                    FormsManager.OpenForm(typeof(CarsMaintenance.Reports.OutboundOrderReport), new object[] { "ID", CurrentOrder.OutboundOrderID });
                }

                DialogResult = DialogResult.OK;
            });
        }

        private void dataGridViewDetail_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < ItemCount)
                dataGridViewDetail.CurrentCell.ReadOnly = true;
        }

        private void dataGridViewDetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue == null || e.FormattedValue.ToString().Length == 0)
                return;

            switch (e.ColumnIndex)
            {
                case 0:
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
                case 1:
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

        private void cbJobType_Validating(object sender, CancelEventArgs e)
        {
            if (cbJobPosition.Text == "船舶" && cbJobType.Text == "")
                e.Cancel = true;
        }
    }
}
