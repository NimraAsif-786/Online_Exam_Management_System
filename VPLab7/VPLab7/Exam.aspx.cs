using appProps;
using BusinessLayer;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VPLab7
{
	public partial class Exam : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
						
		
		}


		

		protected void btnInsert_Click(object sender, EventArgs e)
		{
			Exams E = new Exams();

			E.ExID = int.Parse(txtID.Text);
			
			E.ExName = txtname.Text;
			E.ExDate = txtdate.Text;
			E.ExTime = txttime.Text;
			E.ExMarks = txttm.Text;

			ExamBLL obj = new ExamBLL();

			if (obj.exInsertBLL(E))
			{
				lblMessage.Text = "Inserted Successfully";
			}
			else
			{
				lblMessage.ForeColor =System.Drawing.Color.Red;
				lblMessage.Text = "Not Inserted";

			}

		}
		

		protected void btnSrch_Click(object sender, EventArgs e)
		{
			Exams E = new Exams();

			if (txtID.Text != "")
			{
				E.ExID = int.Parse(txtID.Text);
			}
			else
			{
				E.ExID = -1;
			}
			E.ExName = txtname.Text;
			E.ExDate = txtdate.Text;
			E.ExTime = txttime.Text;
			E.ExMarks = txttm.Text;

			ExamBLL obj = new ExamBLL();

			DataTable dt = obj.exSelectBLL(E);


			if (dt.Rows.Count == 1)     //if only single row matches your search then show data in txtfields
			{
				txtID.Text = dt.Rows[0]["EID"].ToString();
				txtname.Text = dt.Rows[0]["EName"].ToString();
				txtdate.Text = dt.Rows[0]["EDate"].ToString();
				txttime.Text = dt.Rows[0]["TotalTime"].ToString();

				txttm.Text = dt.Rows[0]["TotalMarks"].ToString();
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
		protected void btnUpdate_Click(object sender, EventArgs e)
		{
			Exams E = new Exams();

			E.ExID = int.Parse(txtID.Text);  //E.EmpID = int.Parse(txtID.Text);
			E.ExName = txtname.Text;
			E.ExDate = txtdate.Text;
			E.ExTime = txttime.Text;
			E.ExMarks = txttm.Text;

			ExamBLL obj = new ExamBLL();

			if (obj.exUpdateBLL(E))
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
			Exams E = new Exams();

			E.ExID = int.Parse(txtID.Text);

			ExamBLL obj = new ExamBLL();

			if (obj.exDeleteBLL(E))
			{
				lblMessage.Text = "Deleted Successfully";
			}
			else
			{
				lblMessage.ForeColor = System.Drawing.Color.Red;

				lblMessage.Text = "Not Deleted";
			}
		}
		protected void btnClear_Click(object sender, EventArgs e)
		{
			txtID.Text = "";
			txtname.Text = "";
			txtdate.Text = "";
			txttime.Text = "";

			txttm.Text = "";
		}
		protected void btnView_Click(object sender, EventArgs e)
		{
			//string source = ViewState["ClickType"] as string;

			//if (source == "view")
			//{
			//	//view all wala code  ///SElect * from table wala code
			//}

			Exams E = new Exams();
			ExamBLL obj = new ExamBLL();

			DataTable dt = obj.exViewAllBLL(E);

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
	}
}