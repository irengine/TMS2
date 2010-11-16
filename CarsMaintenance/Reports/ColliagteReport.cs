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
    public partial class ColliagteReport : BaseForm
    {
        public ColliagteReport()
        {
            InitializeComponent();
        }

        private void ColliagteReport_Load(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBeginDate.Value.Date;
            DateTime endDate = dtEndDate.Value.Date.AddDays(1);

            this.ColligateJobTypeRow.DataSource = SQLHelper.QueryColligateReport(beginDate, endDate).Tables["ColligateByJobType"];
            this.ColligateJobPosition.DataSource = SQLHelper.QueryColligateReport(beginDate, endDate).Tables["ColligateByJobPosition"];
            this.ColliagteUintNameType.DataSource = SQLHelper.QueryColligateReport(beginDate, endDate).Tables["CooligateByUnitName"];
            this.reportViewer1.RefreshReport();
        }
    }
}
