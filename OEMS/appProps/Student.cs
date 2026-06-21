using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProps
{
    public class Student
    {
      private int sID;
		private int sroll;
		private string sname;
        private string scell;
        private string email;

		public int SID { get => sID; set => sID = value; }
		public int Sroll { get => sroll; set => sroll = value; }
		public string Sname { get => sname; set => sname = value; }
		public string Scell { get => scell; set => scell = value; }
		public string Email { get => email; set => email = value; }
	}
}
