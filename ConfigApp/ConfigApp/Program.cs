using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SYSBackup.Lib;

namespace ConfigApp
{
	static class Program
	{
		public static string AppConfigFile { get { return "SYSBackup.Server.Shell.exe.config"; } }
		public static string DatabaseName { get { return "BackupContext"; } }
		public static string DatabaseContextName { get { return "BackupContext"; } }

		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new SelectDatabaseDialog());
		}
	}
}
