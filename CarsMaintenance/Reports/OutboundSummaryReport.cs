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
    public partial class OutboundSummaryReport : BaseForm
    {
        public OutboundSummaryReport()
        {
            InitializeComponent();
        }

        private void OutboundSummaryReport_Load(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBeginDate.Value.Date;
            DateTime endDate = dtEndDate.Value.Date.AddDays(1);

            this.OutboundSummaryDataSetBindingSource.DataSource = SQLHelper.QueryOutboundSummary(beginDate, endDate);
            this.reportViewer1.RefreshReport();
        }
    }
}
