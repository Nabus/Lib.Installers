using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SYSBackup.Lib;

namespace ConfigApp
{
	public partial class ConnectToDatabaseDialog : Form
	{
		public string ConnectionString { get; set; }
		public bool IsSuccess { get; set; }

		private readonly string serverName;
		private readonly string instance;
		private readonly string databaseName;

		private ConnectToDatabaseDialog()
		{
			InitializeComponent();
		}

		public ConnectToDatabaseDialog(string serverName, string instance, string databaseName)
			: this()
		{
			this.serverName = serverName;
			this.instance = instance;
			this.databaseName = databaseName;
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			RunOperation();

		}

		private void RunOperation() 
		{
			btnBack.Enabled = false;
			btnRetry.Enabled = false;
			btnFinish.Enabled = false;

			WriteLog(string.Format(@"Connecting to {0}/{1}", serverName, instance));

			string connectionString = ConfigManager.GenerateDatabaseConnectionString_WindowsLogin(serverName, instance, databaseName);

			connectionString = "";

			if (connectionString.Length == 0)
			{
				WriteLog("Unable to connect under windows login credentials.");
				WriteLog("Requesting sql login credentials");

				var dialog = new DatabaseCredentialsDialog();
				dialog.ShowDialog(this);
				connectionString = ConfigManager.GenerateDatabaseConnectionString_SqlLogin(serverName, instance, databaseName, dialog.Username, dialog.Password);

				if (connectionString.Length == 0) 
				{
					WriteLog("Unable to connect under sql login credentials.");
					WriteLog("Operation failed.");
					btnBack.Enabled = true;
					btnRetry.Enabled = true;

					WriteLog("ServerName:" + serverName);
					WriteLog("Instance:" + databaseName);
					WriteLog("Username:" + dialog.Username);
					WriteLog("Error:" + ConfigManager.LastError ?? "Unknown");
					return;
				}
			}

			WriteLog("Success.");

			ConnectionString = connectionString;
			IsSuccess = true;

			btnBack.Enabled = true;
			btnRetry.Enabled = true;
			btnFinish.Enabled = true;
		}

		private void WriteLog(string text) 
		{
			tbOperationLog.AppendText(text + Environment.NewLine);
		}

		private void btnRetry_Click(object sender, EventArgs e)
		{
			RunOperation();
		}

		private void btnFinish_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			IsSuccess = false;
			ConnectionString = "";
			this.Close();
		}
	}
}