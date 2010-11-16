using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarsMaintenance.Common;

namespace CarsMaintenance.Reports
{
    public partial class ScrapByShipReport : BaseForm
    {
        public ScrapByShipReport()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBeginDate.Value.Date;
            DateTime endDate = dtEndDate.Value.Date.AddDays(1);
            this.ScrapByShipDataSetBindingSource.DataSource = SQLHelper.QueryScrapByShipReport(beginDate, endDate);
            this.reportViewer1.RefreshReport();
        }

        private void ScrapByShipReport_Load(object sender, EventArgs e)
        {
       
        }
    }
}
