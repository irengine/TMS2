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
    public partial class ToolReport : BaseForm
    {
        public ToolReport()
        {
            InitializeComponent();
        }

        private void ToolReport_Load(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string Name = this.ToolName.Text;
            string Code = this.ToolCode.Text;

            this.ToolDataSetBindingSource.DataSource = SQLHelper.QueryToolReport(Name, Code);

            this.reportViewer1.RefreshReport();
        }
    }
}
