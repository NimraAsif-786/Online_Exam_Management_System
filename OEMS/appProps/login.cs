using System;                                               //Presentation layer
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace appProps
{
    public class login
    {
        private string uName;       //right click uName, click quick action then Encapsulation field:(and use property)
 
        private string uPasssword;

        public int MyProperty { get; set; }           //type prop & press double tab to get this line

        public string UName { get => uName; set => uName = value; }
        public string UPasssword { get => uPasssword; set => uPasssword = value; }
    }
}
