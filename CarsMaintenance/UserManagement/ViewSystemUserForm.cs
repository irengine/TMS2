using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarsMaintenance.Common;
using TMS.Model;

namespace CarsMaintenance.UserManagement
{
    public partial class ViewSystemUserForm : BaseForm
    {
        public ViewSystemUserForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var query = from u in SystemHelper.TMSContext.SystemUsers
                        where u.Deleted == false && u.SystemUserID > 100
                        orderby u.SystemUserID
                        select u;

            dataGridViewSystemUser.DataSource = query;
        }

        private void ViewSystemUserForm_Load(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(LoadData);
        }

        private SystemUser GetSelectedSystemUser()
        {
            if (dataGridViewSystemUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择系统用户!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }
            int id;
            if (!int.TryParse(Convert.ToString(dataGridViewSystemUser.SelectedRows[0].Cells[0].Value), out id))
            {
                MessageBox.Show("请重新选择系统用户!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }

            return SystemHelper.TMSContext.SystemUsers.First(u => u.SystemUserID == id);
        }

        private void Add()
        {
            using (ManageSystemUserForm form = new ManageSystemUserForm())
            {
                form.CurrentSystemUser = new SystemUser();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void Edit()
        {
            using (ManageSystemUserForm form = new ManageSystemUserForm())
            {
                form.CurrentSystemUser = GetSelectedSystemUser();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void Delete()
        {
            SystemUser u = GetSelectedSystemUser();

            if (u != null && MessageBox.Show("请确定是否删除系统用户?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CarsMaintenance.Properties.Settings.Default.DeleteFlag)
                {
                    SystemHelper.TMSContext.DeleteObject(u);
                }
                else
                {
                    u.Deleted = true;
                }
                SystemHelper.TMSContext.SaveChanges();

                //LoadData();
            }
        }

        #region menu handle event

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Add);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Edit);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Delete);
        }

        private void dataGridViewSystemUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Edit);
        }

        #endregion
    }
}
