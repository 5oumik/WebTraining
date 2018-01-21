using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ThreeTierAspNet
{
    public class conString
    {
        public SqlConnection con;

        public conString()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebDB"].ConnectionString);
        }
    }
}