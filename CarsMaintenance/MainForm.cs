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

        #region Role
        private void initRole()
        {
            string roles = SystemHelper.CurrentUser.Roles;
            if (roles.IndexOf('1') >= 0)
            {
                this.RoleToSystmeManage();
            }
            if (roles.IndexOf('2') >= 0)
            {
                this.RoleToToolArticleManage();
            }
            if (roles.IndexOf('3') >= 0)
            {
                this.RoleToToolsManage();
            }

            if (roles.IndexOf('4') >= 0)
            {
                this.RoleToToolsConservator();
            }

            if (roles.IndexOf('5') >= 0)
            {
                this.RoleToToolsOutOrInUser();
            }
            if (roles.IndexOf('6') >= 0)
            {
                this.RoleToProduceUser();
            }
            if (roles.IndexOf('7') >= 0)
            {
                this.RoleToManageUser();
            }

        }
        /// <summary>
        /// 管理人员用户
        /// </summary>
        private void RoleToManageUser()
        {
            this.btnLandingForm.Enabled = true;
            this.btnViewToolInventoryForm.Enabled = true;
            this.btnViewOutboundOrderForm.Enabled = true;
            this.btnViewScrapOrderForm.Enabled = true;
            this.btnViewRepairOrderForm.Enabled = true;
            this.articleToolStripMenuItem.Enabled = true;
            for (int i = 0; i < this.reportStripMenuItem.DropDownItems.Count; i++)
            {
                this.reportStripMenuItem.DropDownItems[i].Enabled = true;
            }  
        }

        /// <summary>
        /// 生产部门用户
        /// </summary>
        private void RoleToProduceUser()
        {
            this.btnLandingForm.Enabled = true;
            this.btnViewToolInventoryForm.Enabled = true;
            this.btnViewOutboundOrderForm.Enabled = true;
            this.btnViewScrapOrderForm.Enabled = true;
            this.btnViewRepairOrderForm.Enabled = true;
            this.articleToolStripMenuItem.Enabled = true;
            for (int i = 0; i < this.reportStripMenuItem.DropDownItems.Count; i++)
            {
                this.reportStripMenuItem.DropDownItems[i].Enabled = true;
            }  
        }

        /// <summary>
        /// 工具收发工
        /// </summary>
        private void RoleToToolsOutOrInUser()
        {
            this.btnLandingForm.Enabled = true;
            this.btnViewToolInventoryForm.Enabled = true;
            this.btnViewOutboundOrderForm.Enabled = true;
            this.btnViewScrapOrderForm.Enabled = true;
            this.btnViewRepairOrderForm.Enabled = true;            
            this.articleToolStripMenuItem.Enabled = true;
            for (int i = 0; i < this.reportStripMenuItem.DropDownItems.Count; i++)
            {
                this.reportStripMenuItem.DropDownItems[i].Enabled = true;
            }  
        }
        /// <summary>
        /// 工具管理员
        /// </summary>
        private void RoleToToolsConservator()
        {
            this.btnLandingForm.Enabled = true;
            this.btnViewToolInventoryForm.Enabled = true;
            this.btnViewOutboundOrderForm.Enabled = true;
            this.btnViewScrapOrderForm.Enabled = true;
            this.btnViewRepairOrderForm.Enabled = true;
            this.unitToolStripMenuItem.Enabled = true;
            this.userToolStripMenuItem.Enabled = true;
            for (int i = 0; i < this.businessToolStripMenuItem.DropDownItems.Count; i++)
            {
                this.businessToolStripMenuItem.DropDownItems[i].Enabled = true;
            }

        }
        /// <summary>
        /// 工具主任
        /// </summary>
        private void RoleToToolsManage()
        {
            this.btnLandingForm.Enabled = true;
            this.btnViewOutboundOrderForm.Enabled = true;
            this.btnViewRepairOrderForm.Enabled = true;
            this.btnViewScrapOrderForm.Enabled = true;
            this.btnViewToolInventoryForm.Enabled = true;
            this.businessToolStripMenuItem.Enabled = true;
            this._mainMenuStrip.Enabled = true;
            for (int i = 0; i < this.systemToolStripMenuItem.DropDownItems.Count; i++)
            {
                this.systemToolStripMenuItem.DropDownItems[i].Enabled = true;
            }
            for (int i = 0; i < this._mainMenuStrip.Items.Count; i++)
            {
                this._mainMenuStrip.Items[i].Enabled = true;
            }

            for (int i = 0; i < this.toolsToolStripMenuItem.DropDownItems.Count; i++)
            {
                this.toolsToolStripMenuItem.DropDownItems[i].Enabled = true;
            }

            for (int i = 0; i < this.businessToolStripMenuItem.DropDownItems.Count; i++)
            {
                this.businessToolStripMenuItem.DropDownItems[i].Enabled = true;
            }

            for (int i = 0; i < this.reportStripMenuItem.DropDownItems.Count; i++)
            {
                this.reportStripMenuItem.DropDownItems[i].Enabled = true;
            }     
        }
        /// <summary>
        /// 工具工艺主管
        /// </summary>
        private void RoleToToolArticleManage()
        {
            this.btnLandingForm.Enabled = true;
            this.btnViewOutboundOrderForm.Enabled = true;
            this.btnViewRepairOrderForm.Enabled = true;
            this.btnViewScrapOrderForm.Enabled = true;
            this.btnViewToolInventoryForm.Enabled = true;
            this.businessToolStripMenuItem.Enabled = true;
            this._mainMenuStrip.Enabled = true;
            this.unitToolStripMenuItem.Enabled = true;
            for (int i = 0; i < this._mainMenuStrip.Items.Count; i++)
            {
                this._mainMenuStrip.Items[i].Enabled = true;
            }
      
            for (int i = 0; i < this.toolsToolStripMenuItem.DropDownItems.Count; i++)
            {
                this.toolsToolStripMenuItem.DropDownItems[i].Enabled = true;
            }

            for (int i = 0; i < this.businessToolStripMenuItem.DropDownItems.Count; i++)
            {
                this.businessToolStripMenuItem.DropDownItems[i].Enabled = true;
            }

            for (int i = 0; i < this.reportStripMenuItem.DropDownItems.Count; i++)
            {
                this.reportStripMenuItem.DropDownItems[i].Enabled = true;
            }          
        }

        /// <summary>
        /// 系统维护人员 权限
        /// </summary>
        private void RoleToSystmeManage()
        {
            this.btnLandingForm.Enabled = true;
            this.btnViewOutboundOrderForm.Enabled = true;
            this.btnViewRepairOrderForm.Enabled = true;
            this.btnViewScrapOrderForm.Enabled = true;
            this.btnViewToolInventoryForm.Enabled = true;
            this.businessToolStripMenuItem.Enabled = true;
            this._mainMenuStrip.Enabled = true;
            for (int i = 0; i < this._mainMenuStrip.Items.Count;i++ )
            {
                this._mainMenuStrip.Items[i].Enabled = true;               
            }

            for (int i = 0; i < this.systemToolStripMenuItem.DropDownItems.Count; i++)
            {
                this.systemToolStripMenuItem.DropDownItems[i].Enabled = true;
            }
            for (int i = 0; i < this.toolsToolStripMenuItem.DropDownItems.Count; i++)
            {
                this.toolsToolStripMenuItem.DropDownItems[i].Enabled = true;
            }

            for (int i = 0; i < this.businessToolStripMenuItem.DropDownItems.Count; i++)
            {
                this.businessToolStripMenuItem.DropDownItems[i].Enabled = true;
            }

            for (int i = 0; i < this.reportStripMenuItem.DropDownItems.Count; i++)
            {
                this.reportStripMenuItem.DropDownItems[i].Enabled = true;
            }            
        }
        #endregion 

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
                this.initRole();
				this.Show();

			});
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.Reports.LandingForm), null);
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
				FormsManager.ReloadForm(typeof(CarsMaintenance.Reports.LandingForm), null);
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

        private void bt_Technics_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.ToolManagement.ViewTechnics), null);
            });
        }

	}
}
