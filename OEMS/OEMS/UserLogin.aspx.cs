using appProps;
using BusinessLayer; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace VPLab7
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {           
            if (txtuname.Text != "" && txtpass.Text != "") // if (txtuname.Text != null && txtpass.Text != null)
            {
                login L = new login();

                L.UName = txtuname.Text;
                L.UPasssword = txtpass.Text;

                LoginBLL obj = new LoginBLL();

                int accessl = obj.SrchBLL(L);

                //Setting session variables
                Session["Username"] = L.UName;     // Store username & accesslevel in session
                Session["Accesslevel"] = accessl;

                Session.Timeout = 4; // session duration in mints
                if (accessl == 0)
                {
                    Response.Redirect("~/AdminMain.aspx");
                }
                else if (accessl == 1)
                {
                    Response.Redirect("~/InstructorHome.aspx");
                }
                else if (accessl == 2)
                {
                    Response.Redirect("~/StudentMain.aspx");
                }
                              
                else
                {
					lblMessage.ForeColor = System.Drawing.Color.Red;

					lblMessage.Text = "Access Denied.";

                }

            
            }//validation
            else
            {
				lblMessage.ForeColor = System.Drawing.Color.Red;

				lblMessage.Text = "Please enter valid information.";
            }
           
           
        }//btnlogin
    }
}