using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarsMaintenance.Common.Validation
{
    public class GridEmptyVaildator : IValidator
    {
        #region IValidator Members

        public Control Control { get; set; }
        public string ErrorMessage { get; set; }

        public bool Validate()
        {
            DataGridView dgv = Control as DataGridView;
            return dgv.Rows.Count != 0 && dgv.Rows[0].Cells[0].Value != null && dgv.Rows[0].Cells[0].Value.ToString().Length != 0;
        }

        #endregion
    }
}
