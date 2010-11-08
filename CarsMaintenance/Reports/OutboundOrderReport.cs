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
    public partial class OutboundOrderReport : BaseForm
    {
        public int ID { get; set; }
        public OutboundOrderReport()
        {
            InitializeComponent();
        }

        private void OutboundOrderReport_Load(object sender, EventArgs e)
        {
            this.OutboundOrderDataSetBindingSource.DataSource = SQLHelper.QueryOutboundOrder(ID);
            this.reportViewer1.RefreshReport();
        }
    }
}
