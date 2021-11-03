
using System;
namespace BMS.Model
{
	public partial class WeightModel : BaseModel
	{
		public int ID {get; set;}
		
		public string ProductGroup {get; set;}
		
		public decimal PlateWeight {get; set;}
		
		public decimal JigWeight {get; set;}
		
	}
}
	