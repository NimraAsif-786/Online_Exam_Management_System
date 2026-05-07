using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using appProps;
using System.Data;

namespace BusinessLayer
{
    public class InsBLL
    {
        
        public bool insInsertBLL(Ins I)
        {
            InsDAL obj = new InsDAL();
            return obj.insInsertDAL(I);
        }
        public DataTable insSelectBLL(Ins I)
        {
            InsDAL obj = new InsDAL();
            return obj.insSelectDAL(I);

        }

        public bool insUpdateBLL(Ins I)
        {
            InsDAL obj = new InsDAL();
            return obj.insUpdateDAL(I);
        }
        public bool insDeleteBLL(Ins I)
        {
            InsDAL obj = new InsDAL();
            return obj.insDeleteDAL(I);
        }
		public DataTable insViewAllBLL(Ins I)
		{
			InsDAL obj = new InsDAL();
			return obj.insViewAllDAL(I);
		}



	}
}
