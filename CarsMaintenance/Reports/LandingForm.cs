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
            var query = (from o in SystemHelper.TMSContext.Articles
                        orderby o.LastUpdateTime descending
                        where o.IsTop
                        select o).Take(3);

            this.line1.Text = "1.欢迎使用工属具管理应用系统，欢迎提供宝贵意见！";
            this.line2.Text = "2.";
            this.line3.Text = "3.";
            
            int i = 1;
            foreach (Article a in query)
            {
                if (i == 1)
                    this.line1.Text = a.Subject;
                else if (i == 2)
                     this.line2.Text = a.Subject;
                else if (i == 3)
                    this.line3.Text = a.Subject;

                i++;
            }

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

            lblDay1Out.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_DAY1_OUT, DateTime.Now.Day);
            lblDay2Out.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_DAY2_OUT, DateTime.Now.Day);
            lblMonthOut.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_MONTH_OUT, DateTime.Now.Month);
            lblYearOut.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_YEAR_OUT, DateTime.Now.Year);

            lblDayScrap.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_DAY_SCRAP, DateTime.Now.Day);
            lblMonthScrap.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_MONTH_SCRAP, DateTime.Now.Month);
            lblYearScrap.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_YEAR_SCRAP, DateTime.Now.Year);
        }
    }
}
