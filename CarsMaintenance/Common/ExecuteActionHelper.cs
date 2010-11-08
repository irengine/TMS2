using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace CarsMaintenance.Common
{
	public delegate void ExecuteActionDelegate();

	public static class ExecuteActionHelper
	{       
		public static void ExecuteAction(ExecuteActionDelegate action)
		{
			try
			{
				if (action == null)
				{
					return;
				}
				action.Invoke();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString(), "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
		}
	}
}
