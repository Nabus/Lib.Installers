using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConfigApp
{
	public partial class DatabaseCredentialsDialog : Form
	{
		public string Password { get { return tbPassword.Text; } }
		public string Username { get { return tbUsername.Text; } }

		public DatabaseCredentialsDialog()
		{
			InitializeComponent();
		}

		private void tbPassword_TextChanged(object sender, EventArgs e)
		{
			btnOk.Enabled = IsFormValid();
		}

		private void tbUsername_TextChanged(object sender, EventArgs e)
		{
			btnOk.Enabled = IsFormValid();
		}

		private bool IsFormValid() 
		{
			return Password.Length > 0 && Username.Length > 0;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
