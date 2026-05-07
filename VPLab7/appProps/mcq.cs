using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProps
{
	public class mcq
	{
		private int qid;
		private int exid;
		private int sid;

		private int quesno;
		private string questext;
		private string opt1;
		private string opt2;
		private string opt3;
		private string ans;
		private int tmarks;
		private int obmarks;
		public int Qid { get => qid; set => qid = value; }
		public int Exid { get => exid; set => exid = value; }
		public int Quesno { get => quesno; set => quesno = value; }
		public string Questext { get => questext; set => questext = value; }
		public string Opt1 { get => opt1; set => opt1 = value; }
		public string Opt2 { get => opt2; set => opt2 = value; }
		public string Opt3 { get => opt3; set => opt3 = value; }
		public string Ans { get => ans; set => ans = value; }
		public int Sid { get => sid; set => sid = value; }
		public int Tmarks { get => tmarks; set => tmarks = value; }
		public int Obmarks { get => obmarks; set => obmarks = value; }
	}
}
