using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfigApp
{
	public class DatabaseInstanceInfoEntity
	{
		public bool IsLocal { get { return ServerName.Equals(Environment.MachineName); } }
		public string InstanceName { get; set; }
		public string ServerName { get; set; }
	}
}
