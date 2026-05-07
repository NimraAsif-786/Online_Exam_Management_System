using appProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class ShortDAL
	{
		public bool shInsertDAL(Short S)
		{
			DBcon obj = new DBcon();
			// return true; 

			string query = "INSERT INTO ShortQ (EID,QNo, QText,Ans) VALUES  ( " + S.Exid + ", " + S.Quesno + ",'" + S.Questext + "', '"+S.Ans  +"')";

			return obj.UDI(query);

		}

		public DataTable shSelectDAL(Short S)
		{
			DBcon obj = new DBcon();
			string query = "SELECT * FROM ShortQ WHERE EID = " + S.Exid+ " OR QNo = " + S.Quesno + " OR QID = "+ S.Qid +" OR QText = '"+ S.Questext +"' OR Ans='"+ S.Ans +"'";

			DataTable dt = obj.FetchData(query);
			return dt;
		}


		public bool shUpdateDAL(Short S)
		{
			DBcon obj = new DBcon();
			string query = "UPDATE ShortQ SET EID = " +S.Exid +" , QNo = " +S.Quesno+" , QText = '" + S.Questext + "' , Ans = '"+S.Ans+"' WHERE  QID =" +S.Qid;

			return obj.UDI(query);
		}
		public bool shDeleteDAL(Short S)
		{
			DBcon obj = new DBcon();

			string query = "DELETE FROM ShortQ  WHERE QID = "+ S.Qid;
			return obj.UDI(query);
		}

		public DataTable shViewAllDAL(Short S)
		{
			DBcon obj = new DBcon();
			string query = "SELECT * FROM ShortQ ";

			DataTable dt = obj.FetchData(query);
			return dt;
		}

		/* For student side */
		public DataTable studshSelectDAL(Short S)
		{
			DBcon obj = new DBcon();
			string query = "SELECT QID,EID,QNo, QText FROM ShortQ WHERE EID = " + S.Exid + " OR QNo = " + S.Quesno + " OR QID = " + S.Qid + " OR QText = '" + S.Questext + "' OR Ans='" + S.Ans + "'";

			DataTable dt = obj.FetchData(query);
			return dt;
		}

		public bool studshInsertDAL(Short S)
		{
			DBcon obj = new DBcon();
			// return true; 

			string query = "INSERT INTO TestShortQ (EID,ID,QID,QNo,Ans) VALUES  ( " + S.Exid + ", "+S.Sid +"," + S.Qid + "," + S.Quesno + ", '" + S.Ans + "')";

			return obj.UDI(query);

		}

		/* For Result */


		DBcon obj = new DBcon();
		/* for calculating obtained marks of MCQs */

		//getting correct answer from db
		public DataTable GetCorrectAnswers(int examid)
		{
			string query = "SELECT QID, Ans FROM ShortQ WHERE EID=" + examid;
			DataTable dt = obj.FetchData(query);
			return dt;
		}

		//getting student answer from db
		public DataTable GetStudentResponses(int examid, int stdid)
		{
			string query = "SELECT QID, QNo,Ans FROM TestShortQ WHERE EID=" + examid + " AND ID=" + stdid;
			DataTable dt = obj.FetchData(query);
			return dt;
		}

		/* for calculating total marks of MCQs  */
		public DataTable GetTotalMarks(int examid)
		{
			DBcon obj = new DBcon();
			string query = "SELECT COUNT(QID)*2  AS TotalMarks FROM ShortQ WHERE EID=" + examid;
			DataTable dt = obj.FetchData(query);
			return dt;
		}

		// inserting result in db

		public bool resshInsertDAL(Short S)
		{
			DBcon obj = new DBcon();
			
			//	string query = "INSERT INTO Result (EID,ID, Mcqtotm,Mcqobm) VALUES  ( " + m.Exid + ", " + m.Sid + "," + m.Tmarks + "," + m.Obmarks + ")";
			string query = "UPDATE Result SET Shtotm = " + S.Tmarks + " , Shobm = " + S.Obmarks + " WHERE  EID =  " + S.Exid + " AND ID = " + S.Sid;
			return obj.UDI(query);

		}



	}
}
