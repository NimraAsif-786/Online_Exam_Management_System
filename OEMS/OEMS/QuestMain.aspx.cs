using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VPLab7
{
	public partial class QuestMain : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnProceed_Click(object sender, EventArgs e)
        {
			string type = ddlQtype.SelectedValue;
			if (type == "MCQ's")
			{
				Response.Redirect("~/MCQ.aspx");
			}
			else if (type == "True/False")
			{
				Response.Redirect("~/TrueFalse.aspx");
			}
			else if (type == "Short Questions")
			{
				Response.Redirect("~/ShortQ.aspx");
			}
			else
			{
				lblMessage.ForeColor = System.Drawing.Color.Red;

				lblMessage.Text = "Question type is invalid.";
			}
				
		}
    }
}