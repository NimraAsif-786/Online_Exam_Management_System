using appProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class TrueDAL
	{
		public bool trueInsertDAL(True t)
		{
			DBcon obj = new DBcon();
			// return true; 

			string query = "INSERT INTO TruF (EID,QNo, QText,OptionA,OptionB,CorrectAns) VALUES  ( " + t.Exid + ", " + t.Quesno + ",'" + t.Questext + "','" + t.Opt1 + "','" + t.Opt2  + "','" + t.Ans + "')";

			return obj.UDI(query);

		}

		public DataTable trueSelectDAL(True t)
		{
			DBcon obj = new DBcon();
			string query = "SELECT * FROM TruF WHERE QID = " + t.Qid + " OR EID = " + t.Exid + " OR QNo = " + t.Quesno + " OR QText='" + t.Questext + "' OR OptionA ='" + t.Opt1 + "' OR OptionB ='" + t.Opt2  + "'";

			DataTable dt = obj.FetchData(query);
			return dt;
		}


		public bool trueUpdateDAL(True t)
		{
			DBcon obj = new DBcon();
			string query = "UPDATE TruF SET EID = " + t.Exid + " , QNo = " + t.Quesno + " , QText = '" + t.Questext + "', OptionA ='" + t.Opt1 + "' , OptionB ='" + t.Opt2 + "'  WHERE  QID =" + t.Qid;

			return obj.UDI(query);
		}
		public bool trueDeleteDAL(True t)
		{
			DBcon obj = new DBcon();

			string query = "DELETE FROM TruF  WHERE QID = " + t.Qid;
			return obj.UDI(query);
		}

		public DataTable trueViewAllDAL(True t)
		{
			DBcon obj = new DBcon();
			string query = "SELECT * FROM TruF";

			DataTable dt = obj.FetchData(query);
			return dt;
		}

		/*For student side */

		public DataTable studtrueSelectDAL(True t)
		{
			DBcon obj = new DBcon();
			string query = "SELECT QID,EID,QNo, QText, OptionA, OptionB FROM TruF WHERE EID=" + t.Exid;

			DataTable dt = obj.FetchData(query);
			return dt;
		}

		public bool studtrueInsertDAL(True t)
		{
			DBcon obj = new DBcon();
			// return true; 

			string query = "INSERT INTO TestTruF(EID,ID,QID,QNo,CorrectAns) VALUES  ( " + t.Exid + " , " + t.Sid + ", " + t.Qid + "," + t.Quesno + ",'" + t.Ans + "')";

			return obj.UDI(query);

		}

		/* For Result */


		DBcon obj = new DBcon();
		/* for calculating obtained marks of MCQs */

		//getting correct answer from db
		public DataTable GetCorrectAnswers(int examid)
		{
			string query = "SELECT QID, CorrectAns FROM TruF WHERE EID=" + examid;
			DataTable dt = obj.FetchData(query);
			return dt;
		}

		//getting student answer from db
		public DataTable GetStudentResponses(int examid, int stdid)
		{
			string query = "SELECT QID, QNo,CorrectAns FROM TestTruF WHERE EID=" + examid + " AND ID=" + stdid;
			DataTable dt = obj.FetchData(query);
			return dt;
		}

		/* for calculating total marks of MCQs  */
		public DataTable GetTotalMarks(int examid)
		{
			DBcon obj = new DBcon();
			string query = "SELECT COUNT(QID) AS TotalMarks FROM TruF WHERE EID=" + examid;
			DataTable dt = obj.FetchData(query);
			return dt;
		}

		// inserting result in db

		public bool restrueInsertDAL(True t)
		{
			DBcon obj = new DBcon();
			

			//string query = "INSERT INTO Result (EID,ID, Mcqtotm,Mcqobm) VALUES  ( " + m.Exid + ", " + m.Sid + "," + m.Tmarks + "," + m.Obmarks + ")";
			string query = "UPDATE Result SET TFtotm = " + t.Tmarks + " , TFobm = " + t.Obmarks + " WHERE  EID =  " + t.Exid + " AND ID = " + t.Sid;

			return obj.UDI(query);

		}



	}
}
