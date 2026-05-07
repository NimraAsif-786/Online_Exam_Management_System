using appProps;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class TrueBLL
	{
		public bool trueInsertBLL(True t)
		{
			TrueDAL obj = new TrueDAL();
			return obj.trueInsertDAL(t);
		}
		public DataTable trueSelectBLL(True t)
		{
			TrueDAL obj = new TrueDAL();
			return obj.trueSelectDAL(t);

		}

		public bool trueUpdateBLL(True t)
		{
			TrueDAL obj = new TrueDAL();
			return obj.trueUpdateDAL(t);
		}
		public bool trueDeleteBLL(True t)
		{
			TrueDAL obj = new TrueDAL();
			return obj.trueDeleteDAL(t);
		}
		public DataTable trueViewAllBLL(True t)
		{
			TrueDAL obj = new TrueDAL();
			return obj.trueViewAllDAL(t);
		}

		/* For student side */

		public DataTable studtrueSelectBLL(True t)
		{
			TrueDAL obj = new TrueDAL();
			return obj.studtrueSelectDAL(t);

		}

		public bool studtrueInsertBLL(True t)
		{
			TrueDAL obj = new TrueDAL();
			return obj.studtrueInsertDAL(t);
		}

		/* For Result */

		TrueDAL obj = new TrueDAL();


		//getting correct answer from db
		public DataTable GetCorrectAnswers(int examid)
		{ return obj.GetCorrectAnswers(examid); }

		//getting student answer from db
		public DataTable GetStudentResponses(int examid, int stdid)
		{
			return obj.GetStudentResponses(examid, stdid);
		}

		/* for calculating obtained marks of MCQs */

		public int CalculateTotalScore(int examid, int stdid)
		{
			DataTable correctAnswers = GetCorrectAnswers(examid);
			DataTable studentResponses = GetStudentResponses(examid, stdid);
			int totalScore = 0;

			foreach (DataRow row in correctAnswers.Rows)
			{
				int qid = (int)row["QID"];
				string correctAnswer = row["CorrectAns"].ToString();
				DataRow[] responseRows = studentResponses.Select("QID = " + qid);

				if (responseRows.Length > 0)
				{
					string studentAnswer = responseRows[0]["CorrectAns"].ToString(); // Corrected column name
					if (studentAnswer == correctAnswer)
					{
						totalScore += 1; // Assuming each correct answer is worth 1 point
					}
				}
			}
			return totalScore;
		}

		/* for calculating total marks of MCQs  */



		public int GetTotalMarks(int examid)
		{
			TrueDAL obj = new TrueDAL();
			DataTable dt = obj.GetTotalMarks(examid);
			if (dt.Rows.Count > 0)
			{
				return Convert.ToInt32(dt.Rows[0]["TotalMarks"]);
			}
			return 0;
		}

		//inserting result in db

		public bool restrueInsertBLL(True t)
		{
			TrueDAL obj = new TrueDAL();
			return obj.restrueInsertDAL(t);
		}
	}
}
