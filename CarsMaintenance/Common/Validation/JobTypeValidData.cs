using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarsMaintenance.Common.Validation
{
    public class JobTypeValidData:IValidator
    {
        public Control Control { get; set; }
        public Control ControlTo { get; set; }
        public string ErrorMessage { get; set; }

        public bool Validate()
        {
            if (Control == null || ControlTo == null)
            {
                throw new ArgumentNullException("Control");
            }
            if (string.IsNullOrEmpty(ErrorMessage))
            {
                throw new ArgumentOutOfRangeException("ErrorMessage", "It can not be null or empty.");
            }
            if (ControlTo.Text.Equals("船舶"))
            {
                return (!string.IsNullOrEmpty(Control.Text)); 
            }
            else
            {
                return true;
            }
           
        }
    }
}
