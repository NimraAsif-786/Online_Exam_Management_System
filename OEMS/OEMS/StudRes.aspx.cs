using appProps;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VPLab7
{
	public partial class StudRes : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Showresult_Click(object sender, EventArgs e)
        {
			result r = new result();

			if (txtexID.Text != "")
			{
				r.Exid = int.Parse(txtexID.Text);
			}
			else
			{
				lblResult.Text = "Invalid Exam ID.";
			}

			if (txtsid.Text != "")
			{
				r.Sid = int.Parse(txtsid.Text);
			}

			else
			{
				lblResult.Text = "Invalid Student ID.";
			}
			
			resultBLL obj = new resultBLL();

			int total = obj.GetTotalMarksBLL(r);
			int obtain = obj.GetObtainedMarksBLL(r);

			lblResult.Text = "Total Marks: " + total + " |  Obtained Marks: " + obtain;

		

			


		}
	}
}