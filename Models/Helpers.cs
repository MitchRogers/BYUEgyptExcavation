using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace BYUEgyptExcavation.Models
{
    public class Helpers
    {
		public static string GetRDSConnectionString()
		{
			var appConfig = ConfigurationManager.AppSettings;



			string dbname = appConfig["Fag el-Gamous Cemetery"];



			//if (string.IsNullOrEmpty(dbname)) return null;



			string username = appConfig["admin"];
			string password = appConfig["Admin321!"];
			string hostname = appConfig["aa1voqu21n6p7tp.cojcf6npt8v9.us-west-1.rds.amazonaws.com"];
			string port = appConfig["1433"];



			//return "Data Source=" + hostname + ";Initial Catalog=ebdb" + ";User ID=" + username + ";Password=" + password + ";";
			return "Data Source=aa1voqu21n6p7tp.cojcf6npt8v9.us-west-1.rds.amazonaws.com;Initial Catalog=Fag el-Gamous Cemetery;User ID=admin;Password=Admin321!;";
		}
	}
}
