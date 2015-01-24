using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using SYSBackup.Lib;

namespace ConfigApp
{
	public partial class SelectDatabaseDialog : Form
	{
		public DatabaseInstanceInfoEntity SelectedEntity { get; set; }

		private List<DatabaseInstanceInfoEntity> databases;

		public SelectDatabaseDialog()
		{
			InitializeComponent();
			RefreshDatabases();
		}

		private void RefreshDatabases()
		{
			databases = GetDatabases();

			dgvLocalDatabases.DataSource = databases.Where(d => d.IsLocal).ToList();
			dgvNetworkDatabases.DataSource = databases.Where(d => !d.IsLocal).ToList();
		}


		private List<DatabaseInstanceInfoEntity> GetDatabases()
		{




			var result = new List<DatabaseInstanceInfoEntity>();

			var view = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
			RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, view );
			RegistryKey key = baseKey.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL");

			try
			{
				//if (key != null)
				{

					result.AddRange(key.GetValueNames().Select(v => new DatabaseInstanceInfoEntity()
					{
						InstanceName = v,
						ServerName = Environment.MachineName
					}));

					key.Close();
					baseKey.Close();
				}
				
				SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;

				
				System.Data.DataTable table = instance.GetDataSources();

				foreach (System.Data.DataRow row in table.Rows)
				{
					
					var item = new DatabaseInstanceInfoEntity();
					try
					{
						item = new DatabaseInstanceInfoEntity()
						{
							InstanceName = (string)row["InstanceName"],
							ServerName = (string)row["ServerName"]
						};

						if (item.ServerName == Environment.MachineName)
						{
							continue;
						}
					}
					catch
					{
						continue;
					}
					result.Add(item);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

			return result;
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			btnRefresh.Enabled = false;
			RefreshDatabases();
			btnRefresh.Enabled = true;
		}

		private void tbSelectedInstance_TextChanged(object sender, EventArgs e)
		{
			btnSubmit.Enabled = tbSelectedInstance.Text.Length > 0;
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			var filename = Program.AppConfigFile;
			var contextName = Program.DatabaseContextName;
			var databaseName = Program.DatabaseName;
			var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);

			var databaseDialog = new ConnectToDatabaseDialog(SelectedEntity.ServerName, SelectedEntity.InstanceName, databaseName);
			databaseDialog.ShowDialog(this);
			if (!databaseDialog.IsSuccess)
			{
				return;
			}

			ConfigManager.ChangeConfig(path, contextName, databaseDialog.ConnectionString);
			MessageBox.Show("Configuration completed!");
			this.Close();
		}


		private void dgvLocalDatabases_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var entity = ((List<DatabaseInstanceInfoEntity>)dgvLocalDatabases.DataSource)[e.RowIndex];
				SetDatabase(entity);
			}
			catch
			{
			}
		}

		private void dgvNetworkDatabases_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var entity = ((List<DatabaseInstanceInfoEntity>)dgvNetworkDatabases.DataSource)[e.RowIndex];
				SetDatabase(entity);
			}
			catch
			{
			}
		}

		private void SetDatabase(DatabaseInstanceInfoEntity entity)
		{
			this.SelectedEntity = entity;
			tbSelectedInstance.Text = entity.ServerName + "\\" + entity.InstanceName;
		}

		private void dgvLocalDatabases_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				dgvLocalDatabases_RowEnter(sender, e);
				btnSubmit_Click(sender, EventArgs.Empty);
			}
		}

		private void dgvNetworkDatabases_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				dgvNetworkDatabases_RowEnter(sender, e);
				btnSubmit_Click(sender, EventArgs.Empty);
			}
		}

		private void dgvNetworkDatabases_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

	}
}
