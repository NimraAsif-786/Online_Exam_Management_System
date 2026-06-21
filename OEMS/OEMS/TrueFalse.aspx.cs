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
	public partial class TrueFalse : System.Web.UI.Page
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
			
			lblMessage.Text = "";
			
		}



		protected void btnFinish_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/QuestMain.aspx");

		}

		protected void btnInsert_Click(object sender, EventArgs e)
		{
			True t = new True();

			t.Qid = int.Parse(txtqID.Text);
			
			t.Exid = int.Parse(txtexID.Text);
			t.Quesno = int.Parse(txtqno.Text);
			t.Questext = txtq.Text;
			t.Opt1 = txtopt1.Text;
			t.Opt2 = txtopt2.Text;
			
			t.Ans = txtans.Text;


			TrueBLL obj = new TrueBLL();

			if (obj.trueInsertBLL(t))
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
			True t = new True();

			t.Qid = int.Parse(txtqID.Text);

			t.Exid = int.Parse(txtexID.Text);
			t.Quesno = int.Parse(txtqno.Text);
			t.Questext = txtq.Text;
			t.Opt1 = txtopt1.Text;
			t.Opt2 = txtopt2.Text;

			t.Ans = txtans.Text;


			TrueBLL obj = new TrueBLL();

			if (obj.trueUpdateBLL(t))
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
			True t = new True();

			t.Qid = int.Parse(txtqID.Text);


			TrueBLL obj = new TrueBLL();


			if (obj.trueDeleteBLL(t))
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
			True t = new True();

			if (txtqID.Text != "")
			{
				t.Qid = int.Parse(txtqID.Text);
			}
			else
			{
				t.Qid = -1;
			}

			if (txtexID.Text != "")
			{
				  t.Exid = int.Parse(txtexID.Text);
			}
			else
			{
				t.Exid = -1;
			}

			if (txtqno.Text != "")
			{
				 t.Quesno = int.Parse(txtqno.Text);
			}
			else
			{
				  t.Quesno = -1;
			}
			
			t.Questext = txtq.Text;
			t.Opt1 = txtopt1.Text;
			t.Opt2 = txtopt2.Text;

			t.Ans = txtans.Text;



			TrueBLL obj = new TrueBLL();


			DataTable dt = obj.trueSelectBLL(t);


			if (dt.Rows.Count == 1)     //if only single row matches your search then show data in txtfields
			{
				txtqID.Text = dt.Rows[0]["QID"].ToString();
				txtexID.Text = dt.Rows[0]["EID"].ToString();
				txtqno.Text = dt.Rows[0]["QNo"].ToString();
				txtq.Text = dt.Rows[0]["QText"].ToString();
				txtopt1.Text = dt.Rows[0]["OptionA"].ToString();
				txtopt2.Text = dt.Rows[0]["OptionB"].ToString();
				
				txtans.Text = dt.Rows[0]["CorrectAns"].ToString();

			}
			else if (dt.Rows.Count > 1)    //if search result consist of multiple rows
			{
				datagv.DataSource = dt;
				datagv.DataBind();
			}

			else
			{
				lblMessage.Text = "Not Found";
			}

		}

		protected void btnView_Click(object sender, EventArgs e)
		{
			True t = new True();

			TrueBLL obj = new TrueBLL();

			DataTable dt = obj.trueViewAllBLL(t);

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
			
			txtans.Text = "";

			lblMessage.Text = "";
		}
	}
}