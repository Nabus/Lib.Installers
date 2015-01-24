using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace SYSBackup.Lib
{
    public class ConfigManager
    {
		public static Exception LastError { get; private set; }

		public static string GenerateDatabaseConnectionString_WindowsLogin(string serverName, string instance, string databaseName) 
		{
			var formatForConnection = "Data Source = {0}; Database={1}; Integrated Security = True;";
			var formatForTestConnection = "Data Source = {0}; Integrated Security = True;";

			var testConnectionString = string.Format(formatForTestConnection, GenerateDataSource(serverName, instance));
			var realConnectionString = string.Format(formatForConnection, GenerateDataSource(serverName, instance), databaseName);

			return IsConnectable(testConnectionString) ? realConnectionString : "";
		}

		public static string GenerateDatabaseConnectionString_SqlLogin(string serverName, string instance, string databaseName, string user, string password) 
		{
			var formatForConnection = "Data Source = {0}; Database={1}; Integrated Security = False; User Id={2}; Password={3};";
			var formatForTestConnection = "Data Source = {0}; Integrated Security = False; User Id={1}; Password={2};";

			var testConnectionString = string.Format(formatForTestConnection, GenerateDataSource(serverName, instance), user, password);
			var realConnectionString = string.Format(formatForConnection, GenerateDataSource(serverName, instance), databaseName, user, password);

			return IsConnectable(testConnectionString) ? realConnectionString : "";
		}

		private static string GenerateDataSource(string serverName, string instance) 
		{
			var sb = new StringBuilder();
			sb.Append(serverName);

			if (!instance.ToLower().Equals("MSSQLSERVER".ToLower()))
			{
				sb.Append("\\");
				sb.Append(instance);
			}

			return sb.ToString();
		}

		private static bool IsConnectable(string sqlConnectionString)
		{
			try
			{
				using (var connection = new SqlConnection(sqlConnectionString))
				{
					connection.Open();
					connection.Close();
				}
			}
			catch(SqlException ex)
			{
				LastError = ex;
				return false;
			}
			return true;
		}
		
		public static void ChangeConfig(string configPath, string contextName, string connectionString) 
		{
			if (!File.Exists(configPath))
			{
				throw new ArgumentException("File " + configPath + " didn't found");
			}

			var document = new XmlDocument();
			document.Load(configPath);

			var connectionStringsNode = document.DocumentElement.SelectSingleNode("connectionStrings");

			for (int i = 0; i < connectionStringsNode.ChildNodes.Count; i++) 
			{
				var node  = connectionStringsNode.ChildNodes.Item(i);
				if (node.Attributes["name"].InnerText == contextName) 
				{
					node.Attributes["connectionString"].InnerText = connectionString;
				}
			}

			document.Save(configPath);
		}

    }

}
