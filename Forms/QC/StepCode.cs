using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS
{
	public class StepCode
	{
		private string Code;
		private int Column;
		private string StepCode1;

		public string Code1 { get => Code; set => Code = value; }
		public int Column1 { get => Column; set => Column = value; }
		public string StepCode11 { get => this.StepCode1; set => this.StepCode1 = value; }
	}
}
