using appProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class mcqDAL
	{
		public bool mcqInsertDAL(mcq m)
		{
			DBcon obj = new DBcon();
			// return true; 

			string query = "INSERT INTO Mcq (EID,QNo, QText,OptionA,OptionB,OptionC,CorrectAns) VALUES  ( " + m.Exid + ", " + m.Quesno + ",'" + m.Questext + "','" + m.Opt1 + "','" + m.Opt2 + "','"+ m.Opt3 +"','"+ m.Ans +"')";

			return obj.UDI(query);

		}

		public DataTable mcqSelectDAL(mcq m)
		{
			DBcon obj = new DBcon();
			string query = "SELECT * FROM Mcq WHERE QID = " + m.Qid+ " OR EID = " + m.Exid + " OR QNo = " + m.Quesno + " OR QText='" + m.Questext +"' OR OptionA ='"+ m.Opt1 +"' OR OptionB ='" + m.Opt2 +"' OR OptionC ='"+ m.Opt3 +"'";

			DataTable dt = obj.FetchData(query);
			return dt;
		}


		public bool mcqUpdateDAL(mcq m)
		{
			DBcon obj = new DBcon();
			string query = "UPDATE Mcq SET EID = " + m.Exid + " , QNo = " + m.Quesno + " , QText = '" + m.Questext + "', OptionA ='" +m.Opt1 +"' , OptionB ='"+m.Opt2 +"' , OptionC ='"+m.Opt3+"'  WHERE  QID =" + m.Qid;

			return obj.UDI(query);
		}
		public bool mcqDeleteDAL(mcq m)
		{
			DBcon obj = new DBcon();

			string query = "DELETE FROM Mcq  WHERE QID = " + m.Qid;
			return obj.UDI(query);
		}

		public DataTable mcqViewAllDAL(mcq m)
		{
			DBcon obj = new DBcon();
			string query = "SELECT * FROM Mcq ";

			DataTable dt = obj.FetchData(query);
			return dt;
		}



		/* For student side */
		public DataTable studmcqSelectDAL(mcq m)
		{
			DBcon obj = new DBcon();
			string query = "SELECT QID,EID,QNo, QText, OptionA, OptionB, OptionC FROM Mcq WHERE EID=" + m.Exid;

			DataTable dt = obj.FetchData(query);
			return dt;
		}

		
		public bool studmcqInsertDAL(mcq m)
		{
			DBcon obj = new DBcon();
			// return true; 

			string query = "INSERT INTO TestMCQ (EID,ID,QID,QNo,CorrectAns) VALUES  ( " + m.Exid + ","+m.Sid+", " + m.Qid + "," + m.Quesno + ",'" + m.Ans + "')";

			return obj.UDI(query);

		}

		/* For Result */


		 DBcon obj = new DBcon();
		/* for calculating obtained marks of MCQs */

		//getting correct answer from db
		public DataTable GetCorrectAnswers(int examid)
		{
			string query = "SELECT QID, CorrectAns FROM Mcq WHERE EID=" + examid;
			DataTable dt = obj.FetchData(query);
			return dt;
		}

		//getting student answer from db
		public DataTable GetStudentResponses(int examid, int stdid)
		{
			string query = "SELECT QID, QNo,CorrectAns FROM TestMCQ WHERE EID=" + examid + " AND ID=" + stdid;
			DataTable dt = obj.FetchData(query);
			return dt;
		}

		/* for calculating total marks of MCQs  */
		public DataTable GetTotalMarks(int examid)
		{
			DBcon obj = new DBcon();
			string query = "SELECT COUNT(QID) AS TotalMarks FROM Mcq WHERE EID=" + examid;
			DataTable dt = obj.FetchData(query);
			return dt;
		}

		// inserting result in db

		public bool resmcqInsertDAL(mcq m)
		{
			DBcon obj = new DBcon();
			// return true; 

			string query = "INSERT INTO Result (EID,ID, Mcqtotm,Mcqobm) VALUES  ( " + m.Exid + ", " + m.Sid + "," + m.Tmarks + "," + m.Obmarks + ")";

			return obj.UDI(query);

		}





	}
}

