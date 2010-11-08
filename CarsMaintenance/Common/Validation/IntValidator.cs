using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarsMaintenance.Common.Validation
{
	internal class IntValidator : IValidator
	{
		#region IValidator Members

		public Control Control { get; set; }
		public string ErrorMessage { get; set; }

		public bool Validate()
		{
			int value;
			return int.TryParse(Control.Text, out value);
		}

		#endregion
	}
}
