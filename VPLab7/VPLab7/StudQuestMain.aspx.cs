using appProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VPLab7
{
	public partial class StudQuestMain : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
			if (!IsPostBack)
			{
				if (Request.QueryString["examid"] != null)
				{
					int examid = int.Parse(Request.QueryString["examid"]);
					hiddenExamID.Value = examid.ToString(); // Set the hidden field value
					lblDebug.Text = "Exam ID: " + examid;
				}
				else 
				{ 
					lblDebug.Text = "Exam ID not found in query string."; 
				}
			}

		}


		protected void btnProc_Click(object sender, EventArgs e)
		{
			//int examid = int.Parse(hiddenExamID.Value); // Retrieve the examid from the hidden field
			if (int.TryParse(hiddenExamID.Value, out int examid))
			{

				string type = ddlSQtype.SelectedValue;
				if (type == "MCQ's")
				{

					Response.Redirect("~/StudMCQ.aspx?examid=" + examid);
				}
				else if (type == "True/False")
				{
					Response.Redirect("~/StudTrueFalse.aspx?examid=" + examid);
				}
				else if (type == "Short Questions")
				{
					Response.Redirect("~/StudShortQ.aspx?examid=" + examid);
				}
				else
				{
					lblMessage.ForeColor = System.Drawing.Color.Red;

					lblMessage.Text = "Question type is invalid.";
				}
			}
			else
			{
				lblMessage.ForeColor = System.Drawing.Color.Red; 
				lblMessage.Text = "Invalid Exam ID.";
			}
		}
	}
}