using appProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SignUpDAL
    {
        public bool custsignDAL(SignUp S)
        {
            DBcon obj = new DBcon();
            String qry = "INSERT INTO Users(UserName,UserPassword, ActiveStatus,AccessLevel) VALUES('" + S.UName +"','"+S.UPassword+"','"+S.Status + "',"+1+")";
            
            return obj.UDI(qry);
        }
        public bool supsignDAL(SignUp S)
        {
            DBcon obj = new DBcon();
            String qry = "INSERT INTO Users(UserName,UserPassword, ActiveStatus,AccessLevel) VALUES('" + S.UName +"','"+S.UPassword+"','"+S.Status + "',"+2+")";
            
            return obj.UDI(qry);
        }
        public bool personsignDAL(SignUp S)
        {
            DBcon obj = new DBcon();
            String qry = "INSERT INTO Users(UserName,UserPassword, ActiveStatus,AccessLevel) VALUES('" + S.UName +"','"+S.UPassword+"','"+S.Status + "',"+3+")";
            
            return obj.UDI(qry);
        }
        public bool empsignDAL(SignUp S)
        {
            DBcon obj = new DBcon();
            String qry = "INSERT INTO Users(UserName,UserPassword, ActiveStatus,AccessLevel) VALUES('" + S.UName +"','"+S.UPassword+"','"+S.Status + "',"+4+")";
            
            return obj.UDI(qry);
        }
       


    }
}
