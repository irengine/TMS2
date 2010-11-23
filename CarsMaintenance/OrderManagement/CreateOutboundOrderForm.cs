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

        // this property just determine which rows are origin rows.
        // if Create or Transfer mode, ItemCount equals 0,
        // if Append mode, ItemCount equals original row count
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

        #region register validator for input controls

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
            _validationManager.Validators.Add(new JobTypeValidData()
            {
                Control = cbJobType,
                ControlTo = cbJobPosition,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblJobType.Text)
            });
      
            
        }

        #endregion

        #region load data from database

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
                dataGridViewDetail.Columns["ItemBalance"].Visible = true;
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
                object[] row = { item.Tool.Code, item.Quantity, item.Balance, item.Tool.Name, item.Tool.Dimensions };
                dataGridViewDetail.Rows.Add(row);
            }

            AddEmptyRows();
        }

        private void AddEmptyRows()
        {
            for (int i = 0; i < 50; i++)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                dataGridViewDetail.Rows.Add(dgvr);
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

        #endregion

        #region save data into database

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
                    // ignore row which code cell is empty
                    if (dgvr.Cells["ItemCode"].Value == null || dgvr.Cells["ItemCode"].Value.ToString().Length == 0)
                        continue;

                    // ignore tool group row
                    if (dgvr.Cells["ItemCode"].Value.ToString().StartsWith(CarsMaintenance.Properties.Settings.Default.ToolGroupCode))
                        continue;

                    // deal with new rows only
                    if (!dgvr.IsNewRow && dgvr.Index >= ItemCount)
                    {
                        // for outbound detail
                        decimal quantity = SystemHelper.ConvertToNumber(dgvr.Cells["ItemQuantity"].Value);

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

        #endregion

        #region validate data

        private void cbCustomer_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !SystemHelper.ValidateComboxForCustomer(cbCustomer);
        }

        private void cbSystemUser_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !SystemHelper.ValidateComboxForSystemUser(cbSystemUser);
        }

        private void dataGridViewDetail_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // if it is origin data, set it read only.
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

        private void dataGridViewDetail_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDetail.Rows[e.RowIndex].Cells["ItemCode"].Value != null
                && dataGridViewDetail.Rows[e.RowIndex].Cells["ItemCode"].Value.ToString().StartsWith(CarsMaintenance.Properties.Settings.Default.ToolGroupCode))
            {
                // if enter this cell at second time, do not change anything
                if (dataGridViewDetail.Rows[e.RowIndex].Cells["ItemCode"].Style.BackColor == Color.Red)
                    return;

                // if item is tool group, add tool group detail into data grid.
                dataGridViewDetail.Rows[e.RowIndex].Cells["ItemCode"].Style.BackColor = Color.Red;
                dataGridViewDetail.Rows[e.RowIndex].Cells["ItemQuantity"].Style.BackColor = Color.Red;
                dataGridViewDetail.Rows[e.RowIndex].Cells["ItemName"].Style.BackColor = Color.Red;
                dataGridViewDetail.Rows[e.RowIndex].Cells["ItemDimensions"].Style.BackColor = Color.Red;

                decimal quantity =
                    SystemHelper.ConvertToNumber(dataGridViewDetail.Rows[e.RowIndex].Cells["ItemQuantity"].Value);

                int i = 1;
                string code = dataGridViewDetail.Rows[e.RowIndex].Cells["ItemCode"].Value.ToString();
                Tool t = SystemHelper.TMSContext.Tools.First(s => s.Code == code);

                foreach (ToolGroup tg in t.Groups)
                {
                    int count = i++;
                    dataGridViewDetail.Rows[e.RowIndex + count].Cells["ItemCode"].Value = tg.Tool.Code;
                    dataGridViewDetail.Rows[e.RowIndex + count].Cells["ItemCode"].ReadOnly = true;
                    dataGridViewDetail.Rows[e.RowIndex + count].Cells["ItemCode"].Style.BackColor = Color.Yellow;

                    dataGridViewDetail.Rows[e.RowIndex + count].Cells["ItemQuantity"].Value = tg.Quantity*quantity;
                    dataGridViewDetail.Rows[e.RowIndex + count].Cells["ItemQuantity"].Style.BackColor = Color.Yellow;

                    dataGridViewDetail.Rows[e.RowIndex + count].Cells["ItemName"].Value = tg.Tool.Name;
                    dataGridViewDetail.Rows[e.RowIndex + count].Cells["ItemName"].ReadOnly = true;
                    dataGridViewDetail.Rows[e.RowIndex + count].Cells["ItemName"].Style.BackColor = Color.Yellow;

                    dataGridViewDetail.Rows[e.RowIndex + count].Cells["ItemDimensions"].Value = tg.Tool.Dimensions;
                    dataGridViewDetail.Rows[e.RowIndex + count].Cells["ItemDimensions"].ReadOnly = true;
                    dataGridViewDetail.Rows[e.RowIndex + count].Cells["ItemDimensions"].Style.BackColor = Color.Yellow;
                }
            }
        }

        private void dataGridViewDetail_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridViewDetail.Rows[e.Row.Index].Cells["ItemCode"].Style.BackColor == Color.Red
                && dataGridViewDetail.Rows[e.Row.Index + 1].Cells["ItemCode"].Style.BackColor == Color.Yellow)
            {
                e.Cancel = true;
            }
        }

        private void dataGridViewDetail_KeyDown(object sender, KeyEventArgs e)
        {
            int row = dataGridViewDetail.CurrentCell.RowIndex;
            int col = dataGridViewDetail.CurrentCell.ColumnIndex;
            if (col == 1 || col == 2 || col == 3 || col == 3)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    dataGridViewDetail.CurrentCell = dataGridViewDetail.Rows[row + 1].Cells[0];
                    e.SuppressKeyPress = true;
                }
            }
        }
        #endregion
    }
}
