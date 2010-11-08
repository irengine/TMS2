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

namespace CarsMaintenance.UserManagement
{
    public partial class ManageSystemUserForm : Form
    {
        public SystemUser CurrentSystemUser { get; set; }

        public ManageSystemUserForm()
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
                Control = txtPassword,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblPassword.Text)
            });
        }

        private void LoadData()
        {
            var query = from r in SystemHelper.TMSContext.SystemRoles
                        orderby r.Code
                        select r;

            lbRoles.DataSource = query;
            lbRoles.DisplayMember = "Name";
            lbRoles.ValueMember = "Code";

            if (CurrentSystemUser == null)
                CurrentSystemUser = new SystemUser();

            txtCode.Text = CurrentSystemUser.Code;
            txtName.Text = CurrentSystemUser.Name;
            txtPassword.Text = CurrentSystemUser.Password;
            SetSelectdRoles(CurrentSystemUser.Roles);
        }

        private void ManageSystemUserForm_Load(object sender, EventArgs e)
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

                CurrentSystemUser.Code = txtCode.Text;
                CurrentSystemUser.Name = txtName.Text;
                CurrentSystemUser.Password = txtPassword.Text;
                CurrentSystemUser.Roles = GetSelectedRoles();

                if (CurrentSystemUser.EntityKey == null)
                    SystemHelper.TMSContext.AddToSystemUsers(CurrentSystemUser);

                SystemHelper.TMSContext.SaveChanges();

                DialogResult = DialogResult.OK;
            });
        }

        private string GetSelectedRoles()
        {
            List<string> selectedRoleCodes = new List<string>();
            foreach (SystemRole r in lbRoles.SelectedItems)
            {
                selectedRoleCodes.Add(r.Code);
            }
            
            return String.Join(",", selectedRoleCodes);
        }

        private void SetSelectdRoles(string s)
        {
            lbRoles.ClearSelected();

            if (s == null)
                return;

            string[] selectedRoleCodes = s.Split(new char[]{','}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string c in selectedRoleCodes)
            {
                int i;
                int.TryParse(c, out i);
                lbRoles.SetSelected(i - 1, true);
            }
        }
    }
}
