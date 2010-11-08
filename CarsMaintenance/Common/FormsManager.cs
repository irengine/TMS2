using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using CarsMaintenance.Common;

namespace CarsMaintenance
{	
	internal static class FormsManager
	{

		#region : FormsManager - Fields :

		private static Form m_mdiParent;
		private static ToolStrip m_openedWindowToolStrip;

		private static Dictionary<string, BaseForm> m_multipleOpenedForms;

		#endregion

		#region : FormsManager - Methods :

		#region : FormsManager - Private :

		private static string MakeToolBarItemName(BaseForm form)
		{
			return String.Format("{0}.Item", form.Key == null ? form.Name : form.Key);
		}

		private static void AssignParameters(ref BaseForm form, params object[] parameters)
		{
			Type type = form.GetType();
			if (parameters != null)
			{
				for (int i = 0; i < parameters.Length; i += 2)
				{
					PropertyInfo propertyInfo = type.GetProperty(parameters[i].ToString());
					if (propertyInfo != null && propertyInfo.CanWrite)
						propertyInfo.SetValue(form, parameters[i + 1], null);
				}
			}
		}

		private static void AssignEventHandlers(BaseForm form)
		{
			form.FormClosed += new FormClosedEventHandler(formClosed);
			form.Activated += new EventHandler(form_Activated);
			form.Deactivate += new EventHandler(form_Deactivate);
		}

		private static BaseForm FindChild(Type type)
		{
			foreach (BaseForm child in m_mdiParent.MdiChildren)
			{
				if (child.GetType() == type) return child;
			}
			return null;
		}

		private static void ActivateDeactivateForm(object sender, bool flag)
		{
			BaseForm form = sender as BaseForm;
			if (form == null)
				return;

			ToolStripButton item = m_openedWindowToolStrip.Items[MakeToolBarItemName(form)] as ToolStripButton;
			if (item == null)
				return;
			item.Checked = flag;
		}

		private static void UpdateOpenedWindowsToolStrip(BaseForm form, string addedText)
		{
			ToolStripButton item = new ToolStripButton();
			item.Text = form.Text;
			item.DisplayStyle = ToolStripItemDisplayStyle.Image;
			item.ImageTransparentColor = System.Drawing.Color.Magenta;
			item.Name = MakeToolBarItemName(form);
			item.Tag = form;
			item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
			item.Click += new EventHandler(item_Click);
			m_openedWindowToolStrip.Items.Add(item);
		}

		#endregion

		#region : FormsManager - Public :

		public static void Configure(Form mdiParent, ToolStrip openedWindowToolStrip)
		{
			if (mdiParent == null)
				throw new ArgumentNullException("mdiParent");

			if (!mdiParent.IsMdiContainer)
				throw new ArgumentException("mdiParent", "The parameter must be the Form marked as MDI container!");
			m_mdiParent = mdiParent;

			m_openedWindowToolStrip = openedWindowToolStrip;
			m_multipleOpenedForms = new Dictionary<string, BaseForm>();
		}

		/// <summary>
		/// This method opens a form based on its type.
		/// </summary>
		/// <remarks>
		/// NOTES: Opens only forms inherited from <see cref="BaseForm"/> class.
		/// </p>It also will set all properties of the specified form which are specified in parameters.
		/// It will not do this in the case when the form is already loaded.
		/// </p> To open a dialog use OpenDialog method.
		/// </remarks>
		/// <param name="type">Type of the form to be opened.</param>
		/// <param name="parameters">These parameters should follow a specific format which is
		/// <![CDATA[<propertyName1>, <propertyValue1>, <propertyName2>, <propertyValue2><propertyNameN>, <propertyValueN>]]>.
		/// </param>
		/// <returns>True if the form has been opened, otherwise false.</returns>
		public static Boolean OpenForm(Type type, params Object[] parameters)
		{
			if (m_mdiParent == null)
			{
				throw new ArgumentNullException("MdiParent", "FormsManager is not configured. To configure it call its Configure() method.");
			}
			if (!typeof(BaseForm).IsAssignableFrom(type))
			{
				return false;
			}

			BaseForm form;
			if ((form = FindChild(type)) != null)
			{
				form.BringToFront();
			}
			else
			{
				form = (BaseForm)Activator.CreateInstance(type);
				form.MdiParent = m_mdiParent;
				form.WindowState = FormWindowState.Maximized;
				AssignParameters(ref form, parameters);
				UpdateOpenedWindowsToolStrip(form, null);

				AssignEventHandlers(form);
				form.Show();
			}
			return true;
		}

		public static bool OpenMultipleForm(string key, Type type, params object[] parameters)
		{
			if (string.IsNullOrEmpty(key))
			{
				throw new ArgumentOutOfRangeException("key", "Key cannot be null or empty string.");
			}
			if (!typeof(BaseForm).IsAssignableFrom(type))
			{
				return false;
			}

			string validKey = string.Format("{0}_{1}", key, type.Name);
			BaseForm currentForm;
			if (m_multipleOpenedForms.TryGetValue(validKey, out currentForm))
			{
				currentForm.BringToFront();
			}
			else
			{				
				currentForm = (BaseForm)Activator.CreateInstance(type);
				string addedText = " - " + key;
				currentForm.MdiParent = m_mdiParent;
				currentForm.WindowState = FormWindowState.Maximized;
				currentForm.Text += addedText;
				currentForm.Key = validKey;

				AssignParameters(ref currentForm, parameters);
				AssignEventHandlers(currentForm);

				UpdateOpenedWindowsToolStrip(currentForm, addedText);

				currentForm.Show();
				m_multipleOpenedForms.Add(validKey, currentForm);
			}
			return true;
		}

		public static void CloseAllForms()
		{
			foreach (BaseForm child in m_mdiParent.MdiChildren)
			{
				child.Close();
			}
			foreach (KeyValuePair<string, BaseForm> pair in m_multipleOpenedForms)
			{
				pair.Value.Close();
			}
			m_openedWindowToolStrip.Items.Clear();
		}

		#endregion

		#endregion

		#region : FormsManager - Events' Handlers :

		private static void item_Click(object sender, EventArgs e)
		{
			ExecuteActionHelper.ExecuteAction(delegate()
			{
				ToolStripButton item = sender as ToolStripButton;
				if (item == null)
					return;

				BaseForm form = item.Tag as BaseForm;
				if (form == null)
				{
					return;
				}
				form.BringToFront();
			});
		}

		private static void form_Deactivate(object sender, EventArgs e)
		{
			ExecuteActionHelper.ExecuteAction(delegate()
			{
				ActivateDeactivateForm(sender, false);
			});
		}

		private static void form_Activated(object sender, EventArgs e)
		{
			ExecuteActionHelper.ExecuteAction(delegate()
			{
				ActivateDeactivateForm(sender, true);
			});
		}

		private static void formClosed(object sender, FormClosedEventArgs e)
		{
			ExecuteActionHelper.ExecuteAction(delegate()
			{
				BaseForm form = sender as BaseForm;
				if (form == null)
					return;

				// remove tool strip button item.
				ToolStripItem item = m_openedWindowToolStrip.Items[MakeToolBarItemName(form)];
				if (item != null)
				{
					m_openedWindowToolStrip.Items.Remove(item);
				}

				if (form.Key != null)
				{
					// check if it is a multiple opened form and remove it.
					if (m_multipleOpenedForms.ContainsKey(form.Key))
					{
						m_multipleOpenedForms.Remove(form.Key);
					}					
				}
			});
		}

		#endregion

	}
}
