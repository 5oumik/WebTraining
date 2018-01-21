using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ThreeTierAspNet
{
    public class DAL
    {
        public bool RegisterData(string Username, string Password, string Address, long MobileNo)
        {
            conString con = new conString();
            con.con.Open();
            try
            {
                string query =  "Insert Into Registration Values('"+Username+"', '"+Password+"', '"+Address+"', "+MobileNo+")";
                SqlCommand command = new SqlCommand(query, con.con);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                con.con.Close();
                con.con.Dispose();
            }
        }
    }
}