using appProps;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VPLab7
{
	public partial class MCQ : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnNext_Click(object sender, EventArgs e)
		{
			txtqno.Text = (int.Parse(txtqno.Text) + 1).ToString();
			txtq.Text = "";
			txtopt1.Text = "";
			txtopt2.Text = "";
			txtopt3.Text = "";
			lblMessage.Text = "";
			
		}



		protected void btnFinish_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/QuestMain.aspx");

		}

		protected void btnInsert_Click(object sender, EventArgs e)
		{
			mcq m = new mcq();

			m.Qid = int.Parse(txtqID.Text);

			m.Exid = int.Parse(txtexID.Text);
			m.Quesno = int.Parse(txtqno.Text);
			m.Questext = txtq.Text;
			m.Opt1 = txtopt1.Text;
			m.Opt2 = txtopt2.Text;
			m.Opt3 = txtopt3.Text;
			m.Ans = txtans.Text;


			mcqBLL obj = new mcqBLL();

			if (obj.mcqInsertBLL(m))
			{
				lblMessage.Text = "Inserted Successfully";
			}
			else
			{
				lblMessage.ForeColor = System.Drawing.Color.Red;

				lblMessage.Text = "Not Inserted";
			}
		}
		protected void btnUpdate_Click(object sender, EventArgs e)
		{
			mcq m = new mcq();

			m.Qid = int.Parse(txtqID.Text);

			m.Exid = int.Parse(txtexID.Text);
			m.Quesno = int.Parse(txtqno.Text);
			m.Questext = txtq.Text;
			m.Opt1 = txtopt1.Text;
			m.Opt2 = txtopt2.Text;
			m.Opt3 = txtopt3.Text;
			m.Ans = txtans.Text;


			mcqBLL obj = new mcqBLL();

			if (obj.mcqUpdateBLL(m))
			{
				lblMessage.Text = "Updated Successfully";
			}
			else
			{
				lblMessage.ForeColor = System.Drawing.Color.Red;

				lblMessage.Text = "Not Updated";
			}

		}
		protected void btnDlt_Click(object sender, EventArgs e)
		{
			mcq m = new mcq();

			m.Qid = int.Parse(txtqID.Text);

			mcqBLL obj = new mcqBLL();

			if (obj.mcqDeleteBLL(m))
			{
				lblMessage.Text = "Deleted Successfully";
			}
			else
			{
				lblMessage.ForeColor = System.Drawing.Color.Red;

				lblMessage.Text = "Not Deleted";
			}
		}
		protected void btnSrch_Click(object sender, EventArgs e)
		{
			mcq m = new mcq();
			
			if (txtqID.Text != "")
			{
				m.Qid = int.Parse(txtqID.Text);
			}
			else
			{
				m.Qid = -1;
			}

			if (txtexID.Text != "")
			{
				m.Exid = int.Parse(txtexID.Text);
			}
			else
			{
				m.Exid = -1;
			}

			if (txtqno.Text != "")
			{
				m.Quesno = int.Parse(txtqno.Text);
			}
			else
			{
				m.Quesno = -1;
			}
			
			m.Questext = txtq.Text;
			m.Opt1 = txtopt1.Text;
			m.Opt2 = txtopt2.Text;
			m.Opt3 = txtopt3.Text;
			m.Ans = txtans.Text;


			mcqBLL obj = new mcqBLL();


			DataTable dt = obj.mcqSelectBLL(m);


			if (dt.Rows.Count == 1)     //if only single row matches your search then show data in txtfields
			{
				txtqID.Text = dt.Rows[0]["QID"].ToString();
				txtexID.Text = dt.Rows[0]["EID"].ToString();
				txtqno.Text = dt.Rows[0]["QNo"].ToString();
				txtq.Text = dt.Rows[0]["QText"].ToString();
				txtopt1.Text = dt.Rows[0]["OptionA"].ToString();
				txtopt2.Text = dt.Rows[0]["OptionB"].ToString();
				txtopt3.Text = dt.Rows[0]["OptionC"].ToString();
				txtans.Text = dt.Rows[0]["CorrectAns"].ToString(); 

			}
			else if (dt.Rows.Count > 1)    //if search result consist of multiple rows
			{
				datagv.DataSource = dt;
				datagv.DataBind();
			}

			else
			{
				lblMessage.ForeColor = System.Drawing.Color.Red;

				lblMessage.Text = "Not Found";
			}

		}
		protected void btnView_Click(object sender, EventArgs e)
		{
			mcq m = new mcq();

			mcqBLL obj = new mcqBLL();

			DataTable dt = obj.mcqViewAllBLL(m);

			if (dt.Rows.Count > 0)    //if search result consist of multiple rows
			{

				datagv.DataSource = dt;
				datagv.DataBind();

			}

			else
			{
				lblMessage.ForeColor = System.Drawing.Color.Red;

				lblMessage.Text = "Not Found";
			}
		}
		protected void btnClear_Click(object sender, EventArgs e)
		{
			//Clear all fields
			txtqID.Text = "";
			txtexID.Text = "";
			txtqno.Text = "";
			txtq.Text = "";
			txtopt1.Text = "";
			txtopt2.Text = "";
			txtopt3.Text = "";
			txtans.Text = "";

			lblMessage.Text = "";
		}
	}

}
