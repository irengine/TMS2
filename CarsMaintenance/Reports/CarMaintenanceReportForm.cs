using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarsMaintenance.BusinessLogic.Managers;
using CarsMaintenance.Common;

namespace CarsMaintenance
{
	public partial class CarMaintenanceReportForm : BaseForm
	{
		public CarMaintenanceReportForm()
		{
			InitializeComponent();
		}

		private void CarMaintenanceReportForm_Load(object sender, EventArgs e)
		{
			ExecuteActionHelper.ExecuteAction(delegate()
			{
				CarMaintenanceManager mgr = new CarMaintenanceManager();
				this.BindingSource.DataSource = mgr.GetAllForReport();
				this.reportViewer1.RefreshReport();
			});
		}
	}
}
