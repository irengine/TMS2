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
    public partial class ManageSupplyForm : BaseForm
    {
        public Supply CurrentSupply { get; set; }

        public ManageSupplyForm()
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
        }

        private void LoadData()
        {
            if (CurrentSupply == null)
                CurrentSupply = new Supply();

            txtCode.Text = CurrentSupply.Code;
            txtName.Text = CurrentSupply.Name;
            txtComment.Text = CurrentSupply.Comment;
        }

        private void ManageSupplyForm_Load(object sender, EventArgs e)
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

                CurrentSupply.Code = txtCode.Text;
                CurrentSupply.Name = txtName.Text;
                CurrentSupply.Comment = txtComment.Text;

                if (CurrentSupply.EntityKey == null)
                    SystemHelper.TMSContext.AddToSupplies(CurrentSupply);

                SystemHelper.TMSContext.SaveChanges();

                DialogResult = DialogResult.OK;
            });
        }
    }
}
