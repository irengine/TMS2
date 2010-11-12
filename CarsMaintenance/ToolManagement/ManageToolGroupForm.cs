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

namespace CarsMaintenance.ToolManagement
{
    public partial class ManageToolGroupForm : Form
    {
        public Tool CurrentTool { get; set; }
        public ToolCategory CurrentCategory { get; set; }

        public ManageToolGroupForm()
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
            _validationManager.Validators.Add(new RequiredValidator()
            {
                Control = txtCode,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblCode.Text)
            });
            _validationManager.Validators.Add(new RequiredValidator()
            {
                Control = txtName,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblName.Text)
            });
            _validationManager.Validators.Add(new RequiredValidator()
            {
                Control = txtUnit,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblUnit.Text)
            });
            _validationManager.Validators.Add(new RequiredValidator()
            {
                Control = txtRatedQuantity,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblRatedQuantity.Text)
            });
            _validationManager.Validators.Add(new DecimalValidator()
            {
                Control = txtRatedQuantity,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.DigitalErrorMessage, lblRatedQuantity.Text)
            });
            _validationManager.Validators.Add(new GridEmptyVaildator
            {
                Control = dataGridViewDetail,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.DigitalErrorMessage, "xx")
            });
        }

        private void LoadData()
        {
            var query = from c in SystemHelper.TMSContext.ToolCategories
                        where c.Deleted == false
                        orderby c.Code
                        select c;
            cbCategory.DataSource = query;
            cbCategory.DisplayMember = "Name";

            cbCategory.SelectedItem = CurrentCategory;

            if (CurrentTool == null)
                CurrentTool = new Tool();

            txtCode.Text = CurrentTool.Code;
            txtComment.Text = CurrentTool.Comment;
            txtDescription.Text = CurrentTool.Description;
            txtDiameter.Text = CurrentTool.Diameter;
            txtDimensions.Text = CurrentTool.Dimensions;
            txtLength.Text = CurrentTool.Length;
            txtLoad2.Text = CurrentTool.Load2;
            txtName.Text = CurrentTool.Name;
            txtUnit.Text = CurrentTool.Unit;
            txtRatedQuantity.Text = CurrentTool.RatedQuantity.ToString();

            foreach (ToolGroup item in CurrentTool.Groups)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                object[] row = { item.Tool.Code, item.Quantity, item.Tool.Name, item.Tool.Dimensions };
                dataGridViewDetail.Rows.Add(row);
            }
        }

        private void ManageToolGroupForm_Load(object sender, EventArgs e)
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

                CurrentTool.Code = txtCode.Text.ToUpper();
                CurrentTool.Comment = txtComment.Text;
                CurrentTool.Description = txtDescription.Text;
                CurrentTool.Diameter = txtDiameter.Text;
                CurrentTool.Dimensions = GetDimensions(txtDiameter.Text, txtLength.Text, txtLoad2.Text, txtDescription.Text);
                CurrentTool.Length = txtLength.Text;
                CurrentTool.Load2 = txtLoad2.Text;
                CurrentTool.Name = txtName.Text;
                CurrentTool.Unit = txtUnit.Text;
                decimal ratedQuantity = 0;
                decimal.TryParse(txtRatedQuantity.Text, out ratedQuantity);
                CurrentTool.RatedQuantity = ratedQuantity;

                if (CurrentTool.EntityKey == null)
                {
                    CurrentTool.ToolCategory = CurrentCategory;
                    SystemHelper.TMSContext.AddToTools(CurrentTool);
                }

                // Iterate all rows
                foreach (DataGridViewRow dgvr in dataGridViewDetail.Rows)
                {
                    if (!dgvr.IsNewRow)
                    {
                        // for outbound detail
                        int quantity = 0;
                        int.TryParse(dgvr.Cells["ItemQuantity"].Value.ToString(), out quantity);

                        string code = dgvr.Cells["ItemCode"].Value.ToString();
                        Tool t = SystemHelper.TMSContext.Tools.FirstOrDefault(s => s.Code == code);


                        ToolGroup tg = SystemHelper.TMSContext.ToolGroups.CreateObject();
                        tg.ToolGroupID = CurrentTool.ToolID;
                        tg.Tool = t;
                        tg.Quantity = quantity;
                    }
                }

                SystemHelper.TMSContext.SaveChanges();

                DialogResult = DialogResult.OK;
            });
        }

        private string GetDimensions(string diameter, string length, string load, string description)
        {
            string s = "";

            if (diameter != null && diameter.Length != 0)
                s = "φ" + diameter + "mm";
            if (load != null && load.Length != 0)
                s = load + "T";

            if (length != null && length.Length != 0)
                s = s + "×" + length + "m";

            if (description != null && description.Length != 0)
                s = s + ", " + description;

            return s;
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
                    int quantity = 0;
                    if (!int.TryParse(e.FormattedValue.ToString(), out quantity))
                        e.Cancel = true;
                    break;

            }
        }
    }
}
