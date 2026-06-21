using appProps;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace VPLab7
{
	public partial class ShortQ : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnNext_Click(object sender, EventArgs e)
        {
			txtqno.Text = (int.Parse(txtqno.Text) + 1).ToString();
			txtq.Text = "";
			lblMessage.Text = "";
			//Response.Redirect("~/ShortQ.aspx");
		}

		

		protected void btnFinish_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/QuestMain.aspx");

		}

		protected void btnInsert_Click(object sender, EventArgs e)
		{
			Short s = new Short();
			
			s.Qid = int.Parse(txtqID.Text);

			s.Exid = int.Parse(txtexID.Text);
			s.Quesno = int.Parse(txtqno.Text);
			s.Questext = txtq.Text;
			

			ShortBLL obj = new ShortBLL();

			if (obj.shInsertBLL(s))
			{
				lblMessage.Text = "Inserted Successfully";
			}
			else
			{
				lblMessage.Text = "Not Inserted";
			}
		}
		protected void btnUpdate_Click(object sender, EventArgs e)
		{
			Short s = new Short();

			s.Qid = int.Parse(txtqID.Text);

			s.Exid = int.Parse(txtexID.Text);
			s.Quesno = int.Parse(txtqno.Text);
			s.Questext = txtq.Text;


			ShortBLL obj = new ShortBLL();

			if (obj.shUpdateBLL(s))
			{
				lblMessage.Text = "Updated Successfully";
			}
			else
			{
				lblMessage.Text = "Not Updated";
			}

		}
		protected void btnDlt_Click(object sender, EventArgs e)
		{
			Short s = new Short();

			s.Qid = int.Parse(txtqID.Text);

			ShortBLL obj = new ShortBLL();

			if (obj.shDeleteBLL(s))
			{
				lblMessage.Text = "Deleted Successfully";
			}
			else
			{
				lblMessage.Text = "Not Deleted";
			}
		}
		protected void btnSrch_Click(object sender, EventArgs e)
		{
			Short s = new Short();

			if (txtqID.Text != "")
			{
				s.Qid = int.Parse(txtqID.Text);
			}
			else
			{
				s.Qid = -1;
			}

			if (txtexID.Text != "")
			{
				s.Exid = int.Parse(txtexID.Text);
			}
			else
			{
				s.Exid = -1;
			}
			
			if (txtqno.Text != "")
			{
				s.Quesno = int.Parse(txtqno.Text);
			}
			else
			{
				s.Quesno = -1;
			}
			
			s.Questext = txtq.Text;

			ShortBLL obj = new ShortBLL();


			DataTable dt = obj.shSelectBLL(s);


			if (dt.Rows.Count == 1)     //if only single row matches your search then show data in txtfields
			{
				txtqID.Text = dt.Rows[0]["QID"].ToString();
				txtexID.Text = dt.Rows[0]["EID"].ToString();
				txtqno.Text = dt.Rows[0]["QNo"].ToString();
				txtq.Text = dt.Rows[0]["QText"].ToString();

				
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
			Short s = new Short();

			ShortBLL obj = new ShortBLL();

			DataTable dt = obj.shViewAllBLL(s);

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
			lblMessage.Text = "";
		}
	}
}