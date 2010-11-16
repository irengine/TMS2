using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarsMaintenance.Common;
using TMS.Model;

namespace CarsMaintenance.Reports
{
    public partial class LandingForm : BaseForm
    {
        public LandingForm()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            this.line1.Text = "1.欢迎使用工属具管理应用系统，欢迎提供宝贵意见！";
            this.line2.Text = "2.";
            this.line3.Text = "3.";

            lblUserName.Text = SystemHelper.CurrentUser.Name;

            string roleNames = "";
            string[] roleCodes = SystemHelper.CurrentUser.Roles.Split(',');
            foreach (string code in roleCodes)
            {
                SystemRole role = SystemHelper.TMSContext.SystemRoles.First(r => r.Code == code);
                roleNames += role.Name;
            }

            lblRoles.Text = roleNames;

            lblTotal.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_TOTAL_RATED);
            lblStock.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_TOTAL_STOCK);
            lblOut.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_TOTAL_OUT);
        }
    }
}
