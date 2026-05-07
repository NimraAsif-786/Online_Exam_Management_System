using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appProps;

namespace DAL
{
    public class InsDAL
    {

        public bool insInsertDAL(Ins I)
        {
            DBcon obj = new DBcon();
            // return true; 

            string query = "INSERT INTO instructor (Name, CNIC,Contact,Address,Department) VALUES  ('" + I.Name + "','" + I.Cnic + "','" + I.Contact + "','" + I.Adrs + "','" + I.Dept + "')";

            return obj.UDI(query);

        }

        public DataTable insSelectDAL(Ins I)
        {
            DBcon obj = new DBcon();
			string query = "SELECT * FROM instructor WHERE ID = " + I.ID + " OR Name = '" + I.Name + "' OR CNIC ='" + I.Cnic + "' OR Contact ='" + I.Contact+ "' OR Address ='" + I.Adrs + "' OR Department='"+ I.Dept +"'";
			//string query = "SELECT * FROM instructor WHERE empID LIKE '%" + E.EmpID + "%' AND empName LIKE '%" + E.EmpName + "%' AND empCell LIKE '%" + E.EmpCell + "%' AND empAdrs LIKE '%" + E.EmpAddress + "%'";

            DataTable dt = obj.FetchData(query);
            return dt;
        }


        public bool insUpdateDAL(Ins I)
        {
            DBcon obj = new DBcon();
            string query = "UPDATE instructor SET Name ='" + I.Name + "', CNIC ='" + I.Cnic + "', Contact = '" + I.Contact + "' , Address ='" + I.Adrs +"' , Department ='" + I.Dept +"' WHERE ID = " + I.ID;

            return obj.UDI(query);
        }
        public bool insDeleteDAL(Ins I)
        {
            DBcon obj = new DBcon();

            string query = "DELETE FROM instructor WHERE ID = " + I.ID;
            return obj.UDI(query);
        }
        public DataTable insViewAllDAL(Ins I)
        {
            DBcon obj = new DBcon();
            string query = "SELECT * FROM instructor ";

            DataTable dt = obj.FetchData(query);
            return dt;
        }

    }
}
