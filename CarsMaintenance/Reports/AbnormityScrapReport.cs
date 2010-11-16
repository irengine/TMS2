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
    public partial class AbnormityScrapReport : BaseForm
    {
        public AbnormityScrapReport()
        {
            InitializeComponent();
        }

        private void AbnormityScrapReport_Load(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBeginDate.Value.Date;
            DateTime endDate = dtEndDate.Value.Date.AddDays(1);

            this.AbnormityScrapDataSetBindingSource.DataSource = SQLHelper.QueryAbnormityScrapReport(beginDate, endDate);

            this.reportViewer1.RefreshReport();
        }
    }
}
