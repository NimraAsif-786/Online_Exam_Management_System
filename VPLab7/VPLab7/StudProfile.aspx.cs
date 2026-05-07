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
	public partial class StudProfile : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
						
			lblroll.Visible = false;
			lblname.Visible = false;
			lblcell.Visible = false;
			lblemail.Visible = false;
			
			
			txtroll.Visible = false;
			txtname.Visible = false;
			txtcell.Visible = false;
			txtemail.Visible = false;
			
			btnInsert.Visible = false;
			btnUpdate.Visible = false;
			btnDlt.Visible = false;
		}
		protected void btnCreate_Click(object sender, EventArgs e)
		{
			lblid.Visible = false;
			Labelp.Visible = false;
			lblroll.Visible = true;
			lblname.Visible = true;
			lblcell.Visible = true;
			lblemail.Visible = true;

			txtID.Visible = false;
			txtroll.Visible = true;
			txtname.Visible = true;
		
			txtcell.Visible = true;
			txtemail.Visible = true;
			


			btnInsert.Visible = true;
			btnCreate.Visible = false;
			btnSrch.Visible = false;
			btnUpdate.Visible = false;
			btnDlt.Visible = false;

		}
		protected void btnInsert_Click(object sender, EventArgs e)
		{
			Student S = new Student();

			S.Sroll = int.Parse(txtroll.Text);
			S.Sname = txtname.Text;
			S.Scell = txtcell.Text;
			S.Email= txtemail.Text;


			StudBLL obj = new StudBLL();

			if (obj.studInsertBLL(S))
			{
				lblMessage.Text = "Profile Created Successfully";
			}
			else
			{
				lblMessage.ForeColor = System.Drawing.Color.Red;

				lblMessage.Text = "Error in creating profile.";
			}

			lblid.Visible = false;
			Labelp.Visible = false;
			
			lblroll.Visible = true; 
			lblname.Visible = true;
			lblcell.Visible = true;
			lblemail.Visible = true;

			txtID.Visible = false;
			txtroll.Visible = true;
			txtname.Visible = true;
			txtcell.Visible = true;
			txtemail.Visible = true;
			
			btnInsert.Visible = true;
			btnCreate.Visible = false;
			btnSrch.Visible = false;
			btnUpdate.Visible = false;
			btnDlt.Visible = false;
		}

		protected void btnSrch_Click(object sender, EventArgs e)
		{
			lblid.Visible = false;
			Labelp.Visible = false;
			lblroll.Visible = true;
			lblname.Visible = true;
			lblcell.Visible = true;
			lblemail.Visible = true;

			txtID.Visible = false;
			txtroll.Visible = true;
			txtname.Visible = true;
			txtcell.Visible = true;
			txtemail.Visible = true;

			btnCreate.Visible = false;
			btnInsert.Visible = false;
			btnSrch.Visible = false;
			btnUpdate.Visible = true;
			btnDlt.Visible = true;


			Student S = new Student();

			if (txtID.Text != "")
			{
				S.SID = int.Parse(txtID.Text);
			}
			else
			{
				S.SID = -1;
			}
			
			if (txtroll.Text != "")
			{
				S.Sroll = int.Parse(txtroll.Text);
			}
			else
			{
				S.Sroll = -1;
			}

			
			S.Sname = txtname.Text;
			S.Scell = txtcell.Text;
			S.Email = txtemail.Text;


			StudBLL obj = new StudBLL();

			DataTable dt = obj.studSelectBLL(S);


			if (dt.Rows.Count == 1)     //if only single row matches your search then show data in txtfields
			{
				txtID.Text = dt.Rows[0]["ID"].ToString();
				txtroll.Text = dt.Rows[0]["RollNo"].ToString();
				txtname.Text = dt.Rows[0]["Name"].ToString();
				txtcell.Text = dt.Rows[0]["Cell"].ToString();
				txtemail.Text = dt.Rows[0]["Email"].ToString();

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
			Student S = new Student();

			S.SID = int.Parse(txtID.Text);
			S.Sroll = int.Parse(txtroll.Text);
			S.Sname = txtname.Text;
			S.Scell = txtcell.Text;
			S.Email = txtemail.Text;



			StudBLL obj = new StudBLL();


			if (obj.studUpdateBLL(S))
			{
				lblMessage.Text = "Profile Updated Successfully";
			}
			else
			{
				lblMessage.ForeColor = System.Drawing.Color.Red;

				lblMessage.Text = "Profile is not Updated";
			}

			lblid.Visible = false;
			Labelp.Visible = false;
			lblroll.Visible = true;
			lblname.Visible = true;
			lblcell.Visible = true;
			lblemail.Visible = true;	
			
			txtID.Visible = false;
			txtroll.Visible = true;
			txtname.Visible = true;
			txtcell.Visible = true;
			txtemail.Visible = true;
			
			btnInsert.Visible = true;
			btnCreate.Visible = false;
			btnSrch.Visible = false;
			btnUpdate.Visible = false;
			btnDlt.Visible = false;

		}

		protected void btnDlt_Click(object sender, EventArgs e)
		{
			Student S = new Student();

			S.SID = int.Parse(txtID.Text);    //P.empID = int.Parse(txtID.Text);  

			StudBLL obj = new StudBLL();

			if (obj.studDeleteBLL(S))
			{
				lblMessage.Text = "Your Information Deleted Successfully";
			}
			else
			{
				lblMessage.ForeColor = System.Drawing.Color.Red;

				lblMessage.Text = "Error in deleting information.";
			}
		}

		//protected void btnClear_Click(object sender, EventArgs e)
		//{
		//	txtcid.Text = "";  //E.EmpID = int.Parse(txtID.Text);
		//	txtname.Text = "";
		//	txtcell.Text = "";
		//	txtemail.Text = "";
		//	txtadrs.Text = "";

		//}

		//protected void btnView_Click(object sender, EventArgs e)
		//{
		//	appProps.Student C = new appProps.Student();
		//	StudBLL obj = new StudBLL();

		//	DataTable dt = obj.custViewAllBLL(C);

		//	if (dt.Rows.Count > 0)    //if search result consist of multiple rows
		//	{
		//		datagv.DataSource = dt;
		//		datagv.DataBind();

		//	}

		//	else
		//	{
		//		lblMessage.ForeColor = System.Drawing.Color.Red;

		//		lblMessage.Text = "Not Found";
		//	}
	//	}
	}
}