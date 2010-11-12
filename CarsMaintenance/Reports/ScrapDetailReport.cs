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
    public partial class ScrapDetailReport : BaseForm
    {
        public ScrapDetailReport()
        {
            InitializeComponent();
        }

        private void ScrapDetailReport_Load(object sender, EventArgs e)
        {
            this.ScrapDetailDataSetBindingSource.DataSource = SQLHelper.QueryToolGroup();
            this.reportViewer1.RefreshReport();
        }
    }
}
