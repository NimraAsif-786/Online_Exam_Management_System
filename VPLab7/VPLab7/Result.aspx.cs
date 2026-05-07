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
	public partial class Result : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnCalculateMarks_Click(object sender, EventArgs e)
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

				// Store total and obtained marks in db table
				
				r.Tmarks = total;
				r.Obmarks = obtain;

				if (obj.insertfresultBLL(r))
				{
					lblMessage.Text = "Result Saved Successfully"; 
				}
				else
				{
					lblMessage.ForeColor = System.Drawing.Color.Red; 
					lblMessage.Text = "Result Not Saved"; 
				}
			
			
		}

	}

}