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
    public partial class ToolInfoReport : BaseForm
    {
        public ToolInfoReport()
        {
            InitializeComponent();
        }

        private void ToolInfoReport_Load(object sender, EventArgs e)
        {
            SystemHelper.BindComboxToJobPosition(cbJobPosition);
            SystemHelper.BindComboxToJobType(cbJobType);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBeginDate.Value.Date;
            DateTime endDate = dtEndDate.Value.Date.AddDays(1);
            string JobPosition = this.cbJobPosition.Text;
            string JobType = this.cbJobType.Text;
            this.ToolInfoDataSetBindingSource.DataSource = SQLHelper.QueryToolInfoReport(beginDate, endDate,JobPosition,JobType);

            this.reportViewer1.RefreshReport();
        }
    }
}
