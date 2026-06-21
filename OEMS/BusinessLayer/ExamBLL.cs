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
	public class ExamBLL
	{
		public bool exInsertBLL(Exams E)
		{
			ExamDAL obj = new ExamDAL();
			return obj.exInsertDAL(E);
		}
		public DataTable exSelectBLL(Exams E)
		{
			ExamDAL obj = new ExamDAL();
			return obj.exSelectDAL(E);

		}

		public bool exUpdateBLL(Exams E)
		{
			ExamDAL obj = new ExamDAL();
			return obj.exUpdateDAL(E);
		}
		public bool exDeleteBLL(Exams E)
		{
			ExamDAL obj = new ExamDAL();
			return obj.exDeleteDAL(E);
		}
		public DataTable exViewAllBLL(Exams E)
		{
			ExamDAL obj = new ExamDAL();
			return obj.exViewAllDAL(E);
		}

	}
}
