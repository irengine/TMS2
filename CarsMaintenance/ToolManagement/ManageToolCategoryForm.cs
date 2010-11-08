using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TMS.Model;
using CarsMaintenance.Common;
using CarsMaintenance.Common.Validation;

namespace CarsMaintenance.ToolManagement
{
    public partial class ManageToolCategoryForm : BaseForm
    {
        public ToolCategory ParentCategory { get; set; }
        public ToolCategory CurrentCategory { get; set; }

        public ManageToolCategoryForm()
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
            if (CurrentCategory == null)
                CurrentCategory = new ToolCategory();
            else
                ParentCategory = CurrentCategory.ParentCategory;

            txtCode.Text = CurrentCategory.Code;
            txtName.Text = CurrentCategory.Name;
            if (ParentCategory != null)
                txtParentCategory.Text = ParentCategory.Code + "-" + ParentCategory.Name;
        }

        private void ManageToolCategoryForm_Load(object sender, EventArgs e)
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

                CurrentCategory.Code = txtCode.Text;
                CurrentCategory.Name = txtName.Text;

                if (CurrentCategory.EntityKey == null)
                {
                    CurrentCategory.ParentCategory = ParentCategory;
                    SystemHelper.TMSContext.AddToToolCategories(CurrentCategory);
                }

                ToolCategory c = new ToolCategory();
                c.Code = txtCode.Text;
                c.Name = txtName.Text;

                SystemHelper.TMSContext.SaveChanges();

                DialogResult = DialogResult.OK;
            });
        }

    }
}
