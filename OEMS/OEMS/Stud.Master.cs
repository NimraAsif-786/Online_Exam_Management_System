using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VPLab7
{
	public partial class Stud : System.Web.UI.MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["name"] == null && Session["accesslevel"] == null)

			{
				//  lbl.Text = "Session Expired";
				Response.Redirect("~/UserLogin.aspx"); // Redirect if session has expired


			}
		}

		protected void btnlogout_Click(object sender, EventArgs e)
		{
			Session.Clear();          // Clear all session variables
			Session.Abandon();        // End the session
			Response.Redirect("~/UserLogin.aspx"); // Redirect to the login page
		}
	}
}