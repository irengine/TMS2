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
    public partial class ManageUnitForm : Form
    {
        public Unit CurrentUnit { get; set; }
        public Unit ParentUnit { get; set; }

        public ManageUnitForm()
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
            if (CurrentUnit == null)
                CurrentUnit = new Unit();
            else
                ParentUnit = CurrentUnit.ParentUnit;

            txtCode.Text = CurrentUnit.Code;
            txtName.Text = CurrentUnit.Name;
            txtComment.Text = CurrentUnit.Comment;
            if (ParentUnit != null)
                txtParentUnit.Text = ParentUnit.Code + "-" + ParentUnit.Name;
        }

        private void ManageUnitForm_Load(object sender, EventArgs e)
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

                CurrentUnit.Code = txtCode.Text;
                CurrentUnit.Name = txtName.Text;
                CurrentUnit.Comment = txtComment.Text;

                if (CurrentUnit.EntityKey == null)
                {
                    CurrentUnit.ParentUnit = ParentUnit;
                    SystemHelper.TMSContext.AddToUnits(CurrentUnit);
                }

                CurrentUnit.InternalCode = ParentUnit.InternalCode + "," + CurrentUnit.Code;

                SystemHelper.TMSContext.SaveChanges();

                DialogResult = DialogResult.OK;
            });
        }
    }
}
