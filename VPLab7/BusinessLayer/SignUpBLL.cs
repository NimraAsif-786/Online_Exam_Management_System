using appProps;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SignUpBLL
    {
       
        public bool custsignBLL(SignUp S)
        { 
            SignUpDAL obj = new SignUpDAL();
            return obj.custsignDAL(S);
        }
        
        public bool supsignBLL(SignUp S)
        { 
            SignUpDAL obj = new SignUpDAL();
            return obj.supsignDAL(S);
        }
        
        public bool personsignBLL(SignUp S)
        { 
            SignUpDAL obj = new SignUpDAL();
            return obj.personsignDAL(S);
        }
        public bool empsignBLL(SignUp S)
        {
            SignUpDAL obj = new SignUpDAL();
            return obj.empsignDAL(S);
        }
        

    }
}
