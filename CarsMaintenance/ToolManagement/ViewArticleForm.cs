using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarsMaintenance.Common;
using TMS.Model;

namespace CarsMaintenance.ToolManagement
{
    public partial class ViewArticleForm : BaseForm
    {
        #region Role
        protected override void RoleToSystmeManage()
        {
            for (int i = 0; i < contextMenuStripArticle.Items.Count; i++)
            {
                contextMenuStripArticle.Items[i].Enabled = true;
            }

        }
        protected override void RoleToToolsManage()
        {
            for (int i = 0; i < contextMenuStripArticle.Items.Count; i++)
            {
                contextMenuStripArticle.Items[i].Enabled = true;
            }

        }
        protected override void RoleToToolArticleManage()
        {
            for (int i = 0; i < contextMenuStripArticle.Items.Count; i++)
            {
                contextMenuStripArticle.Items[i].Enabled = true;
            }

        }
        #endregion 

        public ViewArticleForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var query = from s in SystemHelper.TMSContext.Articles
                        orderby s.ArticleID
                        select s;

            dataGridViewArticle.DataSource = query;
        }

        private void ViewArticleForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private Article GetSelectedArticle()
        {
            if (dataGridViewArticle.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择公告!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }
            int id;
            if (!int.TryParse(Convert.ToString(dataGridViewArticle.SelectedRows[0].Cells[0].Value), out id))
            {
                MessageBox.Show("请重新选择公告!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }

            return SystemHelper.TMSContext.Articles.First(u => u.ArticleID == id);
        }

        private void Add()
        {
            using (ManageArticleForm form = new ManageArticleForm())
            {
                form.CurrentArticle = new Article();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void Edit()
        {
            using (ManageArticleForm form = new ManageArticleForm())
            {
                form.CurrentArticle = GetSelectedArticle();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void Delete()
        {
            Article u = GetSelectedArticle();

            if (u != null && MessageBox.Show("请确定是否删除公告?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        
        private void dataGridViewArticle_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Edit);
        }

        #endregion

    }
}
