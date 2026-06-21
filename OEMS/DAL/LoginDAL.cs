using appProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class LoginDAL
    {
        //public int LoginAccessDAL(login L)
        //{
        //    string qry = "SELECT AccessLevel FROM Users WHERE UserName = '" + L.UName + "' AND UserPassword = '" + L.UPasssword + "'";
        //    DBcon obj = new DBcon();
        //    DataTable dt = obj.FetchData(qry);   //result of query will store in dt.
            
        //   if (dt.Rows.Count > 0)// if (dt != null) //if(dt != null &&  && dt.Rows.Count > 0)
        //    {
        //        int al = int.Parse(dt.Rows[0]["AccessLevel"].ToString());
        //        return al;
        //    } 
                  
        //    else
        //    {
        //        MessageBox.Show("Login Failed");
        //        return 0;
        //    }
        //}//LoginAccess
        
        public int SrchDAL(login L)
        {
            string qry = "SELECT AccessLevel FROM Users WHERE UserName = '" + L.UName + "' AND UserPassword = '" + L.UPasssword + "'";
            DBcon obj = new DBcon();
            DataTable dt = obj.rdrSearch(qry);   //result of query will store in dt.
            
           if (dt.Rows.Count > 0)// if (dt != null) //if(dt != null &&  && dt.Rows.Count > 0)
            {
                int al = int.Parse(dt.Rows[0]["AccessLevel"].ToString());
                return al;
            } 
                  
            else
            {           
                return -1;
            }
        }//LoginAccess


    }
}
