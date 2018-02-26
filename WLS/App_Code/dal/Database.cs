using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
public class Database
{
	
		  public static SqlConnection Connection
        {
            get
            {
                String conStr = WebConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
                return new SqlConnection(conStr);
            }
        }

	
}