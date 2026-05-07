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
	public partial class StudMCQ : System.Web.UI.Page
	{
		

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				if (Request.QueryString["examid"] != null)
				{
					int examid;
					if (int.TryParse(Request.QueryString["examid"], out examid))
					{
						hiddenExamID.Value = examid.ToString(); // Set the hidden field value
						lblDebug.Text = "Exam ID: " + examid;
					}
					else
					{
						lblDebug.Text = "Invalid Exam ID format.";
					}
				}
				else
				{
					lblDebug.Text = "Exam ID not found in query string.";
				}
			}

			
		}


		protected void btnStart_Click(object sender, EventArgs e)
		{
			lblMessage.Text = "";
			int examid;

			if (int.TryParse(hiddenExamID.Value, out examid))
			{
				mcq m = new mcq();
				m.Exid = examid;   
				mcqBLL obj = new mcqBLL();


				DataTable dt = obj.studmcqSelectBLL(m);


				if (dt.Rows.Count != 0)     //if only single row matches your search then show data in txtfields
				{
				
					// Store the questions in session
					Session["Questions"] = dt;
					Session["CurrentQuestionIndex"] = 0;
					// Display the first question
					DisplayQuestion(0);

				}

				else
				{
					lblMessage.ForeColor = System.Drawing.Color.Red;

					lblMessage.Text = "Not Found";
				}
			}
			else 
			{
				lblDebug.Text = "Invalid Exam ID in hidden field.";
			}
		}

		protected void btnNext_Click(object sender, EventArgs e)
		{
			txtans.Text = "";
			lblMessage.Text = "";

			DataTable dt = Session["Questions"] as DataTable;
			int currentIndex = (int)Session["CurrentQuestionIndex"];

			if (dt != null && currentIndex < dt.Rows.Count - 1)
			{
				currentIndex++;
				Session["CurrentQuestionIndex"] = currentIndex;
				// Display the next question
				DisplayQuestion(currentIndex);
			}
			else
			{ 
				lblMessage.ForeColor = System.Drawing.Color.Red;
				lblMessage.Text = "No more questions.";
			}
		}

		       //DisplayQuestionfun
		        private void DisplayQuestion(int index) 
				{
					DataTable dt = Session["Questions"] as DataTable;
					if (dt != null && index < dt.Rows.Count)
					{ 
						txtqID.Text = dt.Rows[index]["QID"].ToString();
						txtexID.Text = dt.Rows[index]["EID"].ToString();
						txtqno.Text = dt.Rows[index]["QNo"].ToString();
						txtq.Text = dt.Rows[index]["QText"].ToString();
						txtopt1.Text = dt.Rows[index]["OptionA"].ToString();
						txtopt2.Text = dt.Rows[index]["OptionB"].ToString();
						txtopt3.Text = dt.Rows[index]["OptionC"].ToString(); 
					}
				}
		protected void btnFinish_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/StudQuestMain.aspx");

		}


		protected void btnInsert_Click(object sender, EventArgs e)
		{
			mcq m = new mcq();

			m.Sid = int.Parse(txtsid.Text);
			m.Exid = int.Parse(txtexID.Text);
			m.Qid = int.Parse(txtqID.Text);
			m.Quesno = int.Parse(txtqno.Text);
			m.Ans = txtans.Text;


			mcqBLL obj = new mcqBLL();

			if (obj.studmcqInsertBLL(m))
			{
				lblMessage.Text = "Answer Saved Successfully";
			}
			else
			{
				lblMessage.ForeColor = System.Drawing.Color.Red;

				lblMessage.Text = "Answer Not Saved";
			}

		}

		//For result

		protected void btnCalculateResult_Click(object sender, EventArgs e)
		{
			int examid;
			int stdid;
			
			stdid = int.Parse(txtsid.Text);
			
			if (int.TryParse(hiddenExamID.Value, out examid)) 
			{ 
				mcqBLL obj = new mcqBLL();
				
				int obtainScore = obj.CalculateTotalScore(examid, stdid);
				int totalMarks = obj.GetTotalMarks(examid);

				lblResult.Text = "Total Score: " + obtainScore + " / " + totalMarks;

				////storing result in db table
				mcq m = new mcq();
				
				m.Exid = int.Parse(txtexID.Text);
				m.Sid = int.Parse(txtsid.Text);
				m.Tmarks = totalMarks;
				m.Obmarks = obtainScore;

				if (obj.resmcqInsertBLL(m))
				{
					lblMessage.Text = "Result Saved Successfully";
				}
				else
				{
					lblMessage.ForeColor = System.Drawing.Color.Red;

					lblMessage.Text = "Result Not Saved";
				}

			} 
			else
			{ lblDebug.Text = "Invalid Exam ID in hidden field."; } 


		} 
	}
}