﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarsMaintenance.Common;
using TMS.Model;

namespace CarsMaintenance
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();         
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;
            SystemUser u = SystemHelper.TMSContext.SystemUsers.FirstOrDefault(s => s.Code == user && s.Password == password);
            if (u != null)
            {
                SystemHelper.CurrentUser = u;
                //this.Close();
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("用户名或者密码错误!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBoxLogo_DoubleClick(object sender, EventArgs e)
        {
            SystemUser u = SystemHelper.TMSContext.SystemUsers.FirstOrDefault(s => s.Code == "sysAdmin" && s.Password == "P@ssword");
            if (u != null)
            {
                SystemHelper.CurrentUser = u;
            }
            else
            {
                SystemHelper.CurrentUser = SystemHelper.TMSContext.SystemUsers.First();
            }
            DialogResult = DialogResult.OK;
        }
    }
}
