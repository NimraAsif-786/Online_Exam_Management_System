using appProps;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VPLab7
{
	public partial class StudExam : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			labelID.Visible = false;
			txtID.Visible = false;
			btnproceed.Visible = false;
		}
		protected void btnView_Click(object sender, EventArgs e)
		{
			Exams E = new Exams();
			ExamBLL obj = new ExamBLL();

			DataTable dt = obj.exViewAllBLL(E);

			if (dt.Rows.Count > 0) // if search result consists of multiple rows
			{
				datagv.DataSource = dt;
				datagv.DataBind();
			}
			else
			{
				lblMessage.ForeColor = System.Drawing.Color.Red;
				lblMessage.Text = "Not Found";
			}

			labelID.Visible = true;
			txtID.Visible = true;
			btnproceed.Visible = true;

		}//btnView
		

	    protected void btnproceed_Click(object sender, EventArgs e)
		{
			int exid = int.Parse(txtID.Text);
			Response.Redirect("~/StudQuestMain.aspx?examid=" + exid);
		}

	}
}