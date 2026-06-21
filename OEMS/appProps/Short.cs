using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProps
{
	public class Short
	{
		private int qid;
		private int exid;
		private int sid;

		private int quesno;
		private string questext;
		private string ans;
		private int tmarks;
		private int obmarks;
		public int Qid { get => qid; set => qid = value; }
		public int Exid { get => exid; set => exid = value; }
		public int Quesno { get => quesno; set => quesno = value; }
		public string Questext { get => questext; set => questext = value; }
		public string Ans { get => ans; set => ans = value; }
		public int Sid { get => sid; set => sid = value; }
		public int Tmarks { get => tmarks; set => tmarks = value; }
		public int Obmarks { get => obmarks; set => obmarks = value; }
	}
}
