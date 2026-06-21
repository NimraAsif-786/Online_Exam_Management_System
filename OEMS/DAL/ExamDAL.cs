using appProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class ExamDAL
	{
		public bool exInsertDAL(Exams E)
		{
			DBcon obj = new DBcon();
			// return true; 

			string query = "INSERT INTO Exams (EID,EName,EDate ,TotalTime,TotalMarks) VALUES  (" + E.ExID + ", '" + E.ExName + "', '" + E.ExDate + "','" + E.ExTime + "','"+E.ExMarks+"')";

			return obj.UDI(query);

		}

		public DataTable exSelectDAL(Exams E)
		{
			DBcon obj = new DBcon();
			string query = "SELECT * FROM Exams WHERE EID = " + E.ExID + " OR EName = '" + E.ExName + "' OR EDate = '" + E.ExDate + "' OR TotalTime = '" + E.ExTime + "' OR TotalMarks = '" + E.ExMarks+"'";
		//	string qry = "SELECT * FROM Salesperson WHERE ID = '" + p.ID + "' OR Name = '" + p.Name + "' OR Age =" + p.Age + " OR Salary =" + p.Salary + " OR Phone ='" + p.Phone + "'";

			DataTable dt = obj.FetchData(query);
			return dt;
		}


		public bool exUpdateDAL(Exams E)
		{
			DBcon obj = new DBcon();
			string query = "UPDATE Exams SET EName ='" + E.ExName + "', EDate ='" + E.ExDate + "', TotalTime = '" + E.ExTime + "', TotalMarks = '"+E.ExMarks+"' WHERE EID = " + E.ExID;

			return obj.UDI(query);
		}
		public bool exDeleteDAL(Exams E)
		{
			DBcon obj = new DBcon();

			string query = "DELETE FROM Exams WHERE EID = " + E.ExID;
			return obj.UDI(query);
		}

		public DataTable exViewAllDAL(Exams E)
		{
			DBcon obj = new DBcon();
			string query = "SELECT * FROM Exams ";

			DataTable dt = obj.FetchData(query);
			return dt;
		}
	}
}
