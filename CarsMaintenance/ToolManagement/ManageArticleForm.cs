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
    public partial class ManageArticleForm : Form
    {
        public Article CurrentArticle { get; set; }

        public ManageArticleForm()
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
                Control = txtSubject,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblSubject.Text)
            });
            _validationManager.Validators.Add(new RequiredValidator()
            {
                Control = txtContent,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblContent.Text)
            });
        }

        private void LoadData()
        {
            if (CurrentArticle == null)
                CurrentArticle = new Article();

            txtSubject.Text = CurrentArticle.Subject;
            txtContent.Text = CurrentArticle.Content;
        }

        private void ManageArticleForm_Load(object sender, EventArgs e)
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

                CurrentArticle.Subject = txtSubject.Text;
                CurrentArticle.Content = txtContent.Text;

                if (CurrentArticle.EntityKey == null)
                    SystemHelper.TMSContext.AddToArticles(CurrentArticle);

                SystemHelper.TMSContext.SaveChanges();

                DialogResult = DialogResult.OK;
            });
        }
    }
}
