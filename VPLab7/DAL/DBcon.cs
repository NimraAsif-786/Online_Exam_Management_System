using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBcon
    {
        private readonly string connectionString;

        public DBcon()
        {


           connectionString = "Data Source=DESKTOP-0KA3C6H\\SQLEXPRESS;" + "Initial Catalog=ExamMS; Integrated Security=True";
       // connectionString = "Data Source=DESKTOP-0KA3C6H\\SQLEXPRESS;" + " Initial Catalog=VPTass3; Integrated Security=true";
    }

    public object MessageBox { get; private set; }


        // Method to execute non-query commands (INSERT, UPDATE, DELETE)
        public bool UDI(string query)
        {
            bool check;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {                   
                        check = cmd.ExecuteNonQuery() > 0;                                   
                }
            }
            return check;
        } //UDI


        // Method to fetch data (SELECT)

        public DataTable FetchData(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))      // Using the initialized connection string
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);

                    DataSet ds = new DataSet();  //DataTable dt = new DataTable();      
                    adap.Fill(ds);                            //adap.Fill(dt);               
                    return ds.Tables[0];
                }
            }

        }   // FetchData

        public DataTable rdrSearch(string query)  // Search using SqlDataReader
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(sdr);
                    return dt;
                }
            }

        }   // Srch

    }//class
}//namespace




