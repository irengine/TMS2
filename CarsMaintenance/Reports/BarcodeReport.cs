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
    public partial class BarcodeReport : BaseForm
    {
        public BarcodeReport()
        {
            InitializeComponent();
        }

        private void BarcodeReport_Load(object sender, EventArgs e)
        {
            var query = from t in SystemHelper.TMSContext.Tools
                        orderby t.Code
                        select t;

            this.ToolBindingSource.DataSource = query;
            this.reportViewerBarcode.RefreshReport();
        }
    }
}
