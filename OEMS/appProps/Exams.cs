using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProps
{
	public class Exams
	{
		private int exID;     //public int empID { get; set; }
		private string exName;
		private string exDate;
		private string exTime;
		private string exMarks;

		public int ExID { get => exID; set => exID = value; }
		public string ExName { get => exName; set => exName = value; }
		public string ExDate { get => exDate; set => exDate = value; }
		public string ExTime { get => exTime; set => exTime = value; }
		public string ExMarks { get => exMarks; set => exMarks = value; }
	}
}
