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
	public class mcqBLL
	{
		public bool mcqInsertBLL(mcq m)
		{
			mcqDAL obj = new mcqDAL();
			return obj.mcqInsertDAL(m);
		}
		public DataTable mcqSelectBLL(mcq m)
		{
			mcqDAL obj = new mcqDAL();
			return obj.mcqSelectDAL(m);

		}
		
		public bool mcqUpdateBLL(mcq m)
		{
			mcqDAL obj = new mcqDAL();
			return obj.mcqUpdateDAL(m);
		}
		public bool mcqDeleteBLL(mcq m)
		{
			mcqDAL obj = new mcqDAL();
			return obj.mcqDeleteDAL(m);
		}
		public DataTable mcqViewAllBLL(mcq m)
		{
			mcqDAL obj = new mcqDAL();
			return obj.mcqViewAllDAL(m);
		}

		/* For Student side*/
		public DataTable studmcqSelectBLL(mcq m)
		{
			mcqDAL obj = new mcqDAL();
			return obj.studmcqSelectDAL(m);

		}

		public bool studmcqInsertBLL(mcq m)
		{
			mcqDAL obj = new mcqDAL();
			return obj.studmcqInsertDAL(m);
		}


		/* For Result */

		mcqDAL obj = new mcqDAL();


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
			mcqDAL obj = new mcqDAL(); 
			DataTable dt = obj.GetTotalMarks(examid); 
			if (dt.Rows.Count > 0) 
			{ 
				return Convert.ToInt32(dt.Rows[0]["TotalMarks"]); 
			} 
			return 0; 
		}

		//inserting result in db

		public bool resmcqInsertBLL(mcq m)
		{
			mcqDAL obj = new mcqDAL();
			return obj.resmcqInsertDAL(m);
		}
	}
}