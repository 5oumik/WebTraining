using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThreeTierAspNet
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerReg CustReg = new CustomerReg();
                CustReg.Username = txtUserName.Text;
                CustReg.Password = txtPassword.Text;
                CustReg.MobileNo = Convert.ToInt64(txtMobileNo.Text.ToString());
                CustReg.Address = txtAddress.Text;

                bool status = CustReg.Save();

                if(status == true)
                {
                    //ShowAlert("You have successfully registered yourself");
                    Response.Write("You have successfully registered yourself");
                }
                else
                {
                    //ShowAlert("Failed to Register");
                    Response.Write("Failed to Register");
                }
            }
            catch(Exception ex)
            {
                //ShowAlert(ex.Message.ToString());
                Response.Write(ex.Message.ToString());
            }
        }
    }
}