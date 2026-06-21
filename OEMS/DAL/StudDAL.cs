using appProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class StudDAL
    {
        public bool studInsertDAL(Student S)
        {
            DBcon obj = new DBcon();
            // return true; 

            String qry = "INSERT INTO Students(RollNo,Name,Cell,Email) VALUES(" + S.Sroll + ",'" + S.Sname + "','" + S.Scell + "','" + S.Email +  "')";

            return obj.UDI(qry);

        }

        public DataTable studSelectDAL(Student S)
        {
            DBcon obj = new DBcon();
            string qry = "SELECT * FROM Students WHERE ID = " + S.SID + " OR RollNo =" + S.Sroll+ " OR Name ='" + S.Sname + "' OR Cell ='" + S.Scell + "' OR Email ='" + S.Email+ "'";

			DataTable dt = obj.FetchData(qry);
            return dt;
        }


        public bool studUpdateDAL(Student S)
        {
            DBcon obj = new DBcon();
            String qry = "UPDATE Students SET  RollNo=" + S.Sroll + " , Name ='" + S.Sname + "',Cell='" + S.Scell + "' ,Email='" + S.Email + "' WHERE ID=" + S.SID;

			return obj.UDI(qry);
        }
        public bool studDeleteDAL(Student S)
        {
            DBcon obj = new DBcon();

            String qry = "DELETE FROM Students WHERE ID=" + S.SID;
            return obj.UDI(qry);
        }

        public DataTable studViewAllDAL(Student S)
        {
            DBcon obj = new DBcon();
            string qry = "SELECT * FROM Students ";

            DataTable dt = obj.FetchData(qry);
            return dt;
        }
    }
}
