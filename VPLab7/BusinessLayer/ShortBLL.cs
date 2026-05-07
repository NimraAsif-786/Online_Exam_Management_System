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
	public class ShortBLL
	{
		public bool shInsertBLL(Short S)
		{
			ShortDAL obj = new ShortDAL();
			return obj.shInsertDAL(S);
		}
		public DataTable shSelectBLL(Short S)
		{
			ShortDAL obj = new ShortDAL();
			return obj.shSelectDAL(S);

		}

		public bool shUpdateBLL(Short S)
		{
			ShortDAL obj = new ShortDAL();
			return obj.shUpdateDAL(S);
		}
		public bool shDeleteBLL(Short S)
		{
			ShortDAL obj = new ShortDAL();
			return obj.shDeleteDAL(S);
		}
		public DataTable shViewAllBLL(Short S)
		{
			ShortDAL obj = new ShortDAL();
			return obj.shViewAllDAL(S);
		}

		/* For Student side */
		

		public DataTable studshSelectBLL(Short S)
		{
			ShortDAL obj = new ShortDAL();
			return obj.studshSelectDAL(S);

		}

		public bool studshInsertBLL(Short S)
		{
			ShortDAL obj = new ShortDAL();
			return obj.studshInsertDAL(S);
		}

		/* For Result */

		ShortDAL obj = new ShortDAL();


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
				string correctAnswer = row["Ans"].ToString();
				DataRow[] responseRows = studentResponses.Select("QID = " + qid);

				if (responseRows.Length > 0)
				{
					string studentAnswer = responseRows[0]["Ans"].ToString(); // Corrected column name
					if (studentAnswer == correctAnswer)
					{
						totalScore += 2; // Assuming each correct answer is worth 1 point
					}
				}
			}
			return totalScore;
		}

		/* for calculating total marks of MCQs  */

		

		public int GetTotalMarks(int examid) 
		{
			ShortDAL obj = new ShortDAL();
			DataTable dt = obj.GetTotalMarks(examid); 
			if (dt.Rows.Count > 0) 
			{ 
				return Convert.ToInt32(dt.Rows[0]["TotalMarks"]); 
			} 
			return 0; 
		}

		//inserting result in db

		public bool resshInsertBLL(Short S)
		{
			ShortDAL obj = new ShortDAL();
			return obj.resshInsertDAL(S);
		}

	}
}
