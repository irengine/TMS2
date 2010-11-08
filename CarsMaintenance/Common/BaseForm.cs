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
		public string Key { get; set; }

		public BaseForm()
		{
			InitializeComponent();
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
