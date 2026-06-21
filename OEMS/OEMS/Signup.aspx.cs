using appProps;
using BusinessLayer;
using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace VPLab7
{
    public partial class Signup : System.Web.UI.Page
    {
        DBcon con = new DBcon();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string userType = Request.QueryString["type"];
                if (!string.IsNullOrEmpty(userType))
                {
                    ViewState["UserType"] = userType;
                  //  lblMessage.Text = "You are signing up as a " + userType;
                }
            }
        }
        public void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "" && ddlStatus.SelectedItem.Text != "")
            {
                SignUp S = new SignUp();
                S.UName = txtUserName.Text;
                S.UPassword = txtPassword.Text;
                S.Status = ddlStatus.SelectedItem.ToString();

                SignUpBLL obj = new SignUpBLL();

                // Retrieve userType from ViewState
                string userType = ViewState["UserType"] as string;

                if (userType == "Instructor")
                {
                    if (obj.custsignBLL(S))
                    {
                        
                        lblMessage.Text = "Signup Successfully";
                    }
                    else
                    {
						lblMessage.ForeColor = System.Drawing.Color.Red;

						lblMessage.Text = "Signup Failed";
                    }

                }//outer if  
                else if (userType == "Student")
                {
                    if (obj.supsignBLL(S))
                    {
                        
                        lblMessage.Text = "Signup Successfully";
                    }
                    else
                    {
						lblMessage.ForeColor = System.Drawing.Color.Red;

						lblMessage.Text = "Signup Failed";
                    }

                } //outer if
                

            }//validation 

            else
            {
				lblMessage.ForeColor = System.Drawing.Color.Red;

				lblMessage.Text = "Please enter valid information.";
            }
            

        }//btnSignup_Click

    }//class
}//namespace




