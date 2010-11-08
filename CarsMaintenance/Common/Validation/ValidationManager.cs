using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarsMaintenance.Common.Validation
{
	internal sealed class ValidationManager
	{

		#region : ValidationManager - Properties :

		public ErrorProvider Provider { get; set; }
		public List<IValidator> Validators { get; set; }

		#endregion

		#region : ValidationManager - Constructors/Destructor :

		public ValidationManager()
		{
			Validators = new List<IValidator>();
		}

		#endregion

		#region : ValidationManager - Methods :

		public bool Validate()
		{
			if (Provider == null)
			{
				throw new ArgumentNullException("Provider");
			}

			bool result = true, tempResult;
			foreach (var item in Validators)
			{
				tempResult = item.Validate();
				if (tempResult)
				{
					Provider.SetError(item.Control, string.Empty);
				}
				else
				{
					Provider.SetError(item.Control, item.ErrorMessage);
					result = false;
				}
			}
			return result;
		}

		#endregion         
	}
}
