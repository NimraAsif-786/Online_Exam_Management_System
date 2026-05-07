using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appProps;

namespace DAL
{
	public class resultDAL
	{
		public DataTable GetTotalMarks(result r) 
		{
			DBcon obj = new DBcon();

			string query = "SELECT Mcqtotm + TFtotm + Shtotm AS TotalMarks FROM Result WHERE EID = " + r.Exid + " AND ID = " + r.Sid;
			return obj.FetchData(query);
		}
		public DataTable GetObtainedMarks(result r) 
		{
			DBcon obj = new DBcon();

			string query = "SELECT Mcqobm + TFobm + Shobm AS ObtainedMarks FROM Result WHERE EID = " + r.Exid + " AND ID = " + r.Sid;
			return obj.FetchData(query); 
		}

		public bool insertfresultDAL(result r)
		{
			DBcon obj = new DBcon();

			string query = "UPDATE Result SET TotalMarks = " + r.Tmarks + ", ObtainMarks = " + r.Obmarks + " WHERE EID = " + r.Exid + " AND ID = " + r.Sid;
			return obj.UDI(query);
		}
	}
}
