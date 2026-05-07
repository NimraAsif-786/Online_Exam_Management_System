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
    public class StudBLL
    {
        public bool studInsertBLL(Student S)
        {
            StudDAL obj = new StudDAL();
            return obj.studInsertDAL(S);
        }
        public DataTable studSelectBLL(Student S)
        {
			StudDAL obj = new StudDAL();
			return obj.studSelectDAL(S);

        }

        public bool studUpdateBLL(Student S)
        {
            StudDAL obj = new StudDAL();
            return obj.studUpdateDAL(S);
        }
        public bool studDeleteBLL(Student S)
        {
            StudDAL obj = new StudDAL();
            return obj.studDeleteDAL(S);
        }
        public DataTable studViewAllBLL(Student S)
        {
            StudDAL obj = new StudDAL();
            return obj.studViewAllDAL(S);
        }



    }
}
