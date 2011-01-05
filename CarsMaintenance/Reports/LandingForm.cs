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
            this.line2.Text = "";
            this.line3.Text = "";
            
            int i = 1;
            foreach (Article a in query)
            {
                if (i == 1)
                    this.line1.Text ="1."+ a.Content;
                else if (i == 2)
                    this.line2.Text = "2." + a.Content;
                else if (i == 3)
                    this.line3.Text = "3." + a.Content;

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
            lbScrap.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_TOTAL_SCRAP);

            lblDay1Out.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_DAY1_OUT, DateTime.Now.Day);
            lblDay2Out.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_DAY2_OUT, DateTime.Now.Day);
            lblMonthOut.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_MONTH_OUT, DateTime.Now.Month);
            lblYearOut.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_YEAR_OUT, DateTime.Now.Year);

            lblDayScrap.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_DAY_SCRAP, DateTime.Now.Day);
            lblMonthScrap.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_MONTH_SCRAP, DateTime.Now.Month);
            lblYearScrap.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_YEAR_SCRAP, DateTime.Now.Year);

            DataSet ds = SQLHelper.QueryLoginFormToTools();
            this.Gv_type.Columns.Clear();
            this.Gv_type.Rows.Clear();
            for (int temp = 0; temp < ds.Tables[0].Rows.Count; temp++)
            {
                this.Gv_type.Columns.Add("name" + temp, ds.Tables[0].Rows[temp]["Name"].ToString());               
            }  
            this.Gv_type.Rows.Add(4);          
            for (int temp = 0; temp < this.Gv_type.Columns.Count; temp++)
            {
                this.Gv_type.Rows[0].Cells[temp].Value = ds.Tables[0].Rows[temp]["RatedQuantity"].ToString().Replace(".00"," ")+" 件";
            }
            for (int temp = 0; temp < this.Gv_type.Columns.Count; temp++)
            {
                this.Gv_type.Rows[1].Cells[temp].Value = ds.Tables[0].Rows[temp]["Quantity"].ToString().Replace(".00", " ") + " 件";
            }
            for (int temp = 0; temp < this.Gv_type.Columns.Count; temp++)
            {
                this.Gv_type.Rows[2].Cells[temp].Value = ds.Tables[0].Rows[temp]["OutQuantity"].ToString().Replace(".00", " ") + " 件";
            }
            for (int temp = 0; temp < this.Gv_type.Columns.Count; temp++)
            {
                this.Gv_type.Rows[3].Cells[temp].Value = ds.Tables[0].Rows[temp]["ScrapQuantity"].ToString().Replace(".00", " ") + " 件";
            }
        }

        private void Currently_Time_Tick(object sender, EventArgs e)
        {
            this.Lb_Date.Text = System.DateTime.Now.Date.ToShortDateString();
            this.Lb_Time.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void LandingForm_Activated(object sender, EventArgs e)
        {
            this.SuspendLayout();
            LoadData();
            this.ResumeLayout();
            
        }
    }
}
