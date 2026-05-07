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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			
			lblname.Visible=false;
			lblcnic.Visible=false;
			lblcontact.Visible=false;
			lbladrs.Visible=false;
			lbldept.Visible=false;

			//lblid.Text = "";
			//int.Parse(txtID.Text);  //E.EmpID = int.Parse(txtID.Text);
			txtname.Visible=false;
			txtcnic.Visible=false;
			txtcontact.Visible=false;
			txtadrs.Visible=false;
			txtdept.Visible=false;

			btnInsert.Visible = false;
			btnUpdate.Visible = false;
			btnDlt.Visible = false;
		}

		protected void btnCreate_Click(object sender, EventArgs e)
		{
			lblid.Visible = false;
			Labelp.Visible = false;
			lblname.Visible = true;
			lblcnic.Visible = true;
			lblcontact.Visible = true;
			lbladrs.Visible = true;
			lbldept.Visible = true;
			
			txtID.Visible = false;
			txtname.Visible = true;
			txtcnic.Visible = true;
			txtcontact.Visible = true;
			txtadrs.Visible = true;
			txtdept.Visible = true;


			btnInsert.Visible = true;
			btnCreate.Visible = false;
			btnSrch.Visible = false;
			btnUpdate.Visible = false;
			btnDlt.Visible = false;

		}

		protected void btnUpdate_Click(object sender, EventArgs e)
        {
			Ins I = new Ins();

            I.ID = int.Parse(txtID.Text);  //E.EmpID = int.Parse(txtID.Text);
			I.Name = txtname.Text;
            I.Cnic = txtcnic.Text;
            I.Contact = txtcontact.Text;
            I.Adrs = txtadrs.Text;
            I.Dept = txtdept.Text;

            InsBLL obj = new InsBLL();

            if (obj.insUpdateBLL(I))
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
			lblname.Visible = true;
			lblcnic.Visible = true;
			lblcontact.Visible = true;
			lbladrs.Visible = true;
			lbldept.Visible = true;

			txtID.Visible = false;
			txtname.Visible = true;
			txtcnic.Visible = true;
			txtcontact.Visible = true;
			txtadrs.Visible = true;
			txtdept.Visible = true;


			btnInsert.Visible = true;
			btnCreate.Visible = false;
			btnSrch.Visible = false;
			btnUpdate.Visible = false;
			btnDlt.Visible = false;
		}  //btnupdate

		protected void btnInsert_Click(object sender, EventArgs e)
		{
			Ins I = new Ins();

			//I.ID = int.Parse(txtID.Text);  //E.EmpID = int.Parse(txtID.Text);
			I.Name = txtname.Text;
			I.Cnic = txtcnic.Text;
			I.Contact = txtcontact.Text;
			I.Adrs = txtadrs.Text;
			I.Dept = txtdept.Text;



			InsBLL obj = new InsBLL();

			if (obj.insInsertBLL(I))
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
			lblname.Visible = true;
			lblcnic.Visible = true;
			lblcontact.Visible = true;
			lbladrs.Visible = true;
			lbldept.Visible = true;

			txtID.Visible = false;
			txtname.Visible = true;
			txtcnic.Visible = true;
			txtcontact.Visible = true;
			txtadrs.Visible = true;
			txtdept.Visible = true;


			btnInsert.Visible = true;
			btnCreate.Visible = false;
			btnSrch.Visible = false;
			btnUpdate.Visible = false;
			btnDlt.Visible = false;

		} // btninsert

		protected void btnDlt_Click(object sender, EventArgs e)
        {
            Ins I = new Ins();

			I.ID = int.Parse(txtID.Text);

			InsBLL obj = new InsBLL();

            if (obj.insDeleteBLL(I))
            {
                lblMessage.Text = "Your Information Deleted Successfully";
            }
            else
            {
				lblMessage.ForeColor = System.Drawing.Color.Red;

				lblMessage.Text = "Error in deleting information.";
            }

        } // btndlt

        protected void btnSrch_Click(object sender, EventArgs e)
        {				
			lblid.Visible = false;
			Labelp.Visible = false;
			lblname.Visible = true;
			lblcnic.Visible = true;
			lblcontact.Visible = true;
			lbladrs.Visible = true;
			lbldept.Visible = true;
		

			txtID.Visible= false;
			txtname.Visible = true;
			txtcnic.Visible = true;
			txtcontact.Visible = true;
			txtadrs.Visible = true;
			txtdept.Visible = true;
			
			btnCreate.Visible = false;
			btnInsert.Visible = false;
			btnSrch.Visible = false;
			btnUpdate.Visible = true;
			btnDlt.Visible = true;

			Ins I = new Ins();

			if (txtID.Text != "")
			{
				I.ID = int.Parse(txtID.Text);
			}
			else
			{
				I.ID = -1;
			}
			I.Name = txtname.Text;
			I.Cnic = txtcnic.Text;
            I.Contact = txtcontact.Text;
			I.Adrs = txtadrs.Text;
			I.Dept = txtdept.Text;

			InsBLL obj = new InsBLL();

			DataTable dt = obj.insSelectBLL(I);


			if (dt.Rows.Count == 1)     //if only single row matches your search then show data in txtfields
			{
				txtID.Text = dt.Rows[0]["ID"].ToString();
				txtname.Text = dt.Rows[0]["Name"].ToString();
				txtcnic.Text = dt.Rows[0]["CNIC"].ToString();
				txtcontact.Text = dt.Rows[0]["Contact"].ToString();
				txtadrs.Text = dt.Rows[0]["Address"].ToString();

				txtdept.Text = dt.Rows[0]["Department"].ToString();
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


		}  //btnslct

		protected void txtID_TextChanged(object sender, EventArgs e)
        {

        }

   //     protected void btnClear_Click(object sender, EventArgs e)
   //     {
   //         txtID.Text = "";
   //         txtname.Text = "";
			//txtcnic.Text = "";
			//txtcontact.Text = "";
			//txtadrs.Text = "";
			//txtdept.Text = "";

   //     }

    //    protected void btnView_Click(object sender, EventArgs e)
    //    {
    //        Ins I = new Ins();
    //        InsBLL obj = new InsBLL();

    //        DataTable dt = obj.insViewAllBLL(I);

    //        if (dt.Rows.Count > 0)    //if search result consist of multiple rows
    //        {

    //            datagv.DataSource = dt;
    //            datagv.DataBind();

    //        }

    //        else
    //        {
				//lblMessage.ForeColor = System.Drawing.Color.Red;

				//lblMessage.Text = "Not Found";
    //        }

    //    }//btnView

    } //class
}//namespace