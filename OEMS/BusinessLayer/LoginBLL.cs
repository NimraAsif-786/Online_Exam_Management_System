using appProps;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LoginBLL
    {
        //public int LoginAccessBLL(login L)
        //{
        //    LoginDAL obj = new LoginDAL();
        //    return obj.LoginAccessDAL(L);
        //}
        
        public int SrchBLL(login L)
        {
            LoginDAL obj = new LoginDAL();
            return obj.SrchDAL(L);
        }

        
    }
}
