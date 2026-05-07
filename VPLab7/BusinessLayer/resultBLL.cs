using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using appProps;

namespace BusinessLayer
{
	
	public class resultBLL
	{


		public int GetTotalMarksBLL(result r)
		{
			resultDAL obj = new resultDAL();

			DataTable dt = obj.GetTotalMarks(r); 

			if (dt.Rows.Count > 0) 
			{
				return Convert.ToInt32(dt.Rows[0]["TotalMarks"]);
			} 
			return 0; 
		}
		public int GetObtainedMarksBLL(result r) 
		{
			resultDAL obj = new resultDAL();

			DataTable dt = obj.GetObtainedMarks(r);
			
			if (dt.Rows.Count > 0) 
			{ 
				return Convert.ToInt32(dt.Rows[0]["ObtainedMarks"]);
			} 
			return 0; 
		}

		//inserting final result in db
		public bool insertfresultBLL(result r)
		{
			resultDAL obj = new resultDAL();
			return obj.insertfresultDAL(r);
		}
	}
}
