using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarsMaintenance.Common.Validation
{
	internal interface IValidator
	{
		Control Control { get; set; }
		string ErrorMessage { get; set; }

		bool Validate();
	}
}
