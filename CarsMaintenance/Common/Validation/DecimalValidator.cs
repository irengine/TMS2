using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarsMaintenance.Common.Validation
{
	internal class DecimalValidator : IValidator
	{
		#region IValidator Members

		public Control Control { get; set; }

		public string ErrorMessage { get; set; }

		public bool Validate()
		{
			if (Control.Text.Length == 0)
			{
				return true;
			}
			decimal value;
			return decimal.TryParse(Control.Text, out value);
		}

		#endregion
	}
}
