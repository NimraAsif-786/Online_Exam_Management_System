using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProps
{
	public class result
	{
		private int exid;
		private int sid;
		//private int mcqTM;
		//private int mcqOb;
		//private int trueTM;
		//private int trueOb;
		//private int shTM;
		//private int shOb;
		private int tmarks;
		private int obmarks;

		public int Exid { get => exid; set => exid = value; }
		public int Sid { get => sid; set => sid = value; }
		//public int McqTM { get => mcqTM; set => mcqTM = value; }
		//public int McqOb { get => mcqOb; set => mcqOb = value; }
		//public int TrueTM { get => trueTM; set => trueTM = value; }
		//public int TrueOb { get => trueOb; set => trueOb = value; }
		//public int ShTM { get => shTM; set => shTM = value; }
		//public int ShOb { get => shOb; set => shOb = value; }
		public int Tmarks { get => tmarks; set => tmarks = value; }
		public int Obmarks { get => obmarks; set => obmarks = value; }
	}
}
