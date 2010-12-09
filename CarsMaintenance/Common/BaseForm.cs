using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TMS.Model;

namespace CarsMaintenance
{
    public partial class BaseForm : Form
    {
        #region Role
        private void initRole()
        {
            if (CarsMaintenance.Common.SystemHelper.CurrentUser == null)
                return;
            string roles = CarsMaintenance.Common.SystemHelper.CurrentUser.Roles;
            if (roles.IndexOf('1') >= 0)
            {
                RoleToSystmeManage();
            }
            if (roles.IndexOf('2') >= 0)
            {
                RoleToToolArticleManage();
            }
            if (roles.IndexOf('3') >= 0)
            {
                RoleToToolsManage();
            }
            if (roles.IndexOf('4') >= 0)
            {
                RoleToToolsConservator();
            }
            if (roles.IndexOf('5') >= 0)
            {
                RoleToToolsOutOrInUser();
            }
            if (roles.IndexOf('6') >= 0)
            {
                RoleToProduceUser();
            }
            if (roles.IndexOf('7') >= 0)
            {
                RoleToManageUser();
            }
        }

        /// <summary>
        /// 管理人员用户
        /// </summary>
        protected virtual void RoleToManageUser()
        {
        }

        /// <summary>
        /// 生产部门用户
        /// </summary>
        protected virtual void RoleToProduceUser()
        {
        }

        /// <summary>
        /// 工具收发工
        /// </summary>
        protected virtual void RoleToToolsOutOrInUser()
        {
        }

        /// <summary>
        /// 工具管理员
        /// </summary>
        protected virtual void RoleToToolsConservator()
        {
        }

        /// <summary>
        /// 工具主任
        /// </summary>
        protected virtual void RoleToToolsManage()
        {
        }
        /// <summary>
        /// 工具工艺主管
        /// </summary>
        protected virtual void RoleToToolArticleManage()
        {
        }

        /// <summary>
        /// 系统管理员
        /// </summary>
        protected virtual void RoleToSystmeManage()
        {
        }

        #endregion

        public string Key { get; set; }

        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            initRole();
        }

        //protected TMSEntities efContext;

        //protected virtual void LoadData()
        //{

        //}

        //private void BaseForm_Load(object sender, EventArgs e)
        //{
        //    efContext = new TMSEntities();
        //    LoadData();
        //}
    }
}
