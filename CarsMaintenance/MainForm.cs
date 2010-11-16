using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarsMaintenance.Common;

namespace CarsMaintenance
{
	public partial class MainForm : Form
	{

		#region : MainForm - Constructors/Destructor :

		public MainForm()
		{
			InitializeComponent();
		}

		#endregion

		#region : MainForm - Events' Handlers :

		private void MainForm_Load(object sender, EventArgs e)
		{
			ExecuteActionHelper.ExecuteAction(delegate()
			{
				FormsManager.Configure(this, _openedFormsToolStrip);

				this.Hide();

                using (LoginForm form = new LoginForm())
                {
                    if (form.ShowDialog() != DialogResult.OK)
                    {
                        this.Close();
                    }
                }

				this.Show();
			});
		}

		private void _button_Click(object sender, EventArgs e)
		{
			//ExecuteActionHelper.ExecuteAction(delegate()
			//{
			//    if (sender == _carDetailsButton)
			//    {
			//        FormsManager.OpenForm(typeof(ViewCarsDetailsForm), null);
			//    }
			//});
		}

		private void _maintenanceReportButton_Click(object sender, EventArgs e)
		{
			//ExecuteActionHelper.ExecuteAction(delegate()
			//{
			//    FormsManager.OpenForm(typeof(CarMaintenanceReportForm), null);
			//});

			ExecuteActionHelper.ExecuteAction(delegate()
			{
				FormsManager.OpenForm(typeof(CarsMaintenance.UserManagement.ViewSystemUserForm), null);
			});
		}

		private void _fleetSpotCheckButton_Click(object sender, EventArgs e)
		{
			//ExecuteActionHelper.ExecuteAction(delegate()
			//{
			//    using (CreateCarsFleetSpotChecksMaintenanceForm form = new CreateCarsFleetSpotChecksMaintenanceForm())
			//    {
			//        form.ShowDialog();
			//    }
			//});
		}

		private void _exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion         

		private void toolCategoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExecuteActionHelper.ExecuteAction(delegate()
			{
				FormsManager.OpenForm(typeof(CarsMaintenance.ToolManagement.ViewToolCategoryForm), null);
			});
		}

		private void supplyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExecuteActionHelper.ExecuteAction(delegate()
			{
				FormsManager.OpenForm(typeof(CarsMaintenance.ToolManagement.ViewSupplyForm), null);
			});
		}

		private void toolToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//ExecuteActionHelper.ExecuteAction(delegate()
			//{
			//    FormsManager.OpenForm(typeof(CarsMaintenance.ToolManagement.ViewToolForm), null);
			//});
		}

		private void toolGroupToolStripMenuItem_Click(object sender, EventArgs e)
		{
            //ExecuteActionHelper.ExecuteAction(delegate()
            //{
            //    FormsManager.OpenForm(typeof(CarsMaintenance.ToolManagement.ViewToolGroupForm), null);
            //});
		}

		private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExecuteActionHelper.ExecuteAction(delegate()
			{
				CarsMaintenance.OrderManagement.CreatePurchaseOrderForm form = new OrderManagement.CreatePurchaseOrderForm();
				form.ShowDialog();
			});
		}

		private void outboundOrderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExecuteActionHelper.ExecuteAction(delegate()
			{
				CarsMaintenance.OrderManagement.CreateOutboundOrderForm form = new OrderManagement.CreateOutboundOrderForm();
				form.ShowDialog();
			});
		}

		private void viewToolInventoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExecuteActionHelper.ExecuteAction(delegate()
			{
				FormsManager.OpenForm(typeof(CarsMaintenance.ToolManagement.ViewToolInventoryForm), null);
			});
		}

		private void btnLandingForm_Click(object sender, EventArgs e)
		{
			ExecuteActionHelper.ExecuteAction(delegate()
			{
				FormsManager.OpenForm(typeof(CarsMaintenance.Reports.LandingForm), null);
			});
		}

		private void btnViewToolInventoryForm_Click(object sender, EventArgs e)
		{
			ExecuteActionHelper.ExecuteAction(delegate()
			{
				FormsManager.OpenForm(typeof(CarsMaintenance.ToolManagement.ViewToolInventoryForm), null);
			});

		}

		private void userToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExecuteActionHelper.ExecuteAction(delegate()
			{
				FormsManager.OpenForm(typeof(CarsMaintenance.UserManagement.ViewSystemUserForm), null);
			});
		}

		private void unitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExecuteActionHelper.ExecuteAction(delegate()
			{
				FormsManager.OpenForm(typeof(CarsMaintenance.ToolManagement.ViewUnitForm), null);
			});
		}

		private void BarcodeReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExecuteActionHelper.ExecuteAction(delegate()
			{
				FormsManager.OpenForm(typeof(CarsMaintenance.Reports.BarcodeReport), null);
			});
		}

        private void btnViewOutboundOrderForm_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.OrderManagement.ViewOutboundOrderForm), null);
            });
        }

        private void btnViewScrapOrderForm_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.OrderManagement.ViewScrapOrderForm), null);
            });
        }

        private void btnViewRepairOrderForm_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.OrderManagement.ViewRepairOrderForm), null);
            });
        }

        private void articleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.ToolManagement.ViewArticleForm), null);
            });
        }

        private void outboundOrder2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.OrderManagement.ViewOutboundOrderForm), null);
            });
        }

        private void inboundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.OrderManagement.ViewOutboundOrderForm), null);
            });
        }

        private void scrapOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.OrderManagement.ViewScrapOrderForm), null);
            });
        }

        private void repairOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.OrderManagement.ViewRepairOrderForm), null);
            });
        }

        private void OrderSummaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.Reports.OutboundSummaryReport), null);
            });
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
               // FormsManager.OpenForm(typeof(CarsMaintenance.Reports.ScrapDetailReport), null);
            });
        }

        private void ScrapReportMune_Click(object sender, EventArgs e)
        {
            
        }

        private void ScrapByCategoryMenu_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.Reports.ScrapReport), null);
            });                                                                                                                     
        }

        private void OutToolMenu_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.Reports.OutBoundOrderByUintReport), null);
            });
        }

        private void ScrapByUnitMenu_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.Reports.ScrapByUintReport), null);
            });
        }

        private void ScrapByShipMenu_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.Reports.ScrapByShipReport), null);
            });
        }

        private void ScrapByAbnormality_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.Reports.AbnormityScrapReport), null);
            });
        }

        private void ToolInfoMenu_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.Reports.ToolReport), null);
            });
        }

        private void ScrapByColligateMenu_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.Reports.ColliagteReport), null);
            });
        }

        private void ScrapAdvanceMenu_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.Reports.ToolInfoReport), null);
            });
        }

	}
}
