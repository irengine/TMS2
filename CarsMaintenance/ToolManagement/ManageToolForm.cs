using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarsMaintenance.Common;
using CarsMaintenance.Common.Validation;
using TMS.Model;

namespace CarsMaintenance.ToolManagement
{
    public partial class ManageToolForm : BaseForm
    {
        public Tool CurrentTool { get; set; }
        public ToolCategory CurrentCategory { get; set; }

        public ManageToolForm()
        {
            InitializeComponent();
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
            _validationManager.Validators.Add(new ParentCodeValidator()
            {
                Control = txtCode,
                ParentCode = CurrentCategory.Code,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.ParentCodeErrorMessage, lblCode.Text)
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
        }

        private void ManageToolForm_Load(object sender, EventArgs e)
        {
            LoadData();
            RegisterControlsForValidation();
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
    }
}
