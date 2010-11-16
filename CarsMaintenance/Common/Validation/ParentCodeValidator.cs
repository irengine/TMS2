using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarsMaintenance.Common.Validation
{
    public class ParentCodeValidator : IValidator
    {
        #region IValidator Members

        public Control Control { get; set; }
        public string ParentCode { get; set; }
        public string ErrorMessage { get; set; }

        public bool Validate()
        {
            TextBox txt = Control as TextBox;
            return txt.Text.StartsWith(ParentCode);
        }

        #endregion
    }
}
