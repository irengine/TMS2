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

namespace CarsMaintenance.ToolManagement
{
    public partial class ViewSupplyForm : BaseForm
    {
        public ViewSupplyForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var query = from s in SystemHelper.TMSContext.Supplies
                        orderby s.Name
                        select s;

            dataGridViewSupply.DataSource = query;
        }

        private void ViewSupplyForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private Supply GetSelectedSupply()
        {
            if (dataGridViewSupply.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择供应商!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }
            int id;
            if (!int.TryParse(Convert.ToString(dataGridViewSupply.SelectedRows[0].Cells[0].Value), out id))
            {
                MessageBox.Show("请重新选择供应商!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }

            return SystemHelper.TMSContext.Supplies.First(u => u.SupplyID == id);
        }

        private void Add()
        {
            using (ManageSupplyForm form = new ManageSupplyForm())
            {
                form.CurrentSupply = new Supply();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void Edit()
        {
            using (ManageSupplyForm form = new ManageSupplyForm())
            {
                form.CurrentSupply = GetSelectedSupply();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void Delete()
        {
            Supply u = GetSelectedSupply();

            if (u != null && MessageBox.Show("请确定是否删除供应商?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void dataGridViewSupply_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Edit);
        }

        #endregion

    }
}
