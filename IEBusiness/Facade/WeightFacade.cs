
using System.Collections;
using IE.Model;
namespace IE.Facade
{
	
	public class WeightFacade : BaseFacade
	{
		protected static WeightFacade instance = new WeightFacade(new WeightModel());
		protected WeightFacade(WeightModel model) : base(model)
		{
		}
		public static WeightFacade Instance
		{
			get { return instance; }
		}
		protected WeightFacade():base() 
		{ 
		} 
	
	}
}
	