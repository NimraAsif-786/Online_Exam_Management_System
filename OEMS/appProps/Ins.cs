using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProps
{
    public class Ins
    {
        private int iD;     
        private string name ;
        private string cnic ;     
        private string contact;
        private string adrs;
        private string dept;

		public int ID { get => iD; set => iD = value; }
		public string Name { get => name; set => name = value; }
		public string Cnic { get => cnic; set => cnic = value; }
		public string Contact { get => contact; set => contact = value; }
		public string Adrs { get => adrs; set => adrs = value; }
		public string Dept { get => dept; set => dept = value; }
	}
}


