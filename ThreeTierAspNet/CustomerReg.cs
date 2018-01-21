using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThreeTierAspNet
{
    public class CustomerReg
    { 
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public long MobileNo { get; set; }

        public bool Save()
        {
            try
            {
                DAL dal = new DAL();
                dal.RegisterData(Username, Password, Address, MobileNo);
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}