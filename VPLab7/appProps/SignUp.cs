using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProps
{
    public class SignUp
    {
        private string uName;
        private string uPassword;
        private string status;
        //private string accessLevel;
        

       
        public string UName { get => uName; set => uName = value; }
        public string UPassword { get => uPassword; set => uPassword = value; }
        public string Status { get => status; set => status = value; }

        
    }
}
