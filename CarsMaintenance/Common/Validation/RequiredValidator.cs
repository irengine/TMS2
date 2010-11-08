using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarsMaintenance.Common.Validation
{
	internal class RequiredValidator : IValidator
	{
		#region IValidator Members

		public Control Control { get; set; }
		public string ErrorMessage { get; set; }

		public bool Validate()
		{
			if (Control == null)
			{
				throw new ArgumentNullException("Control");
			}
			if (string.IsNullOrEmpty(ErrorMessage))
			{
				throw new ArgumentOutOfRangeException("ErrorMessage", "It can not be null or empty.");
			}
			return (Control.Text.Length != 0);
		}

		#endregion
	}
}
