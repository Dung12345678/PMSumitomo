
using System.Collections;
using HP.Model;
namespace HP.Facade
{
	
	public class SonPlanFacade : BaseFacade
	{
		protected static SonPlanFacade instance = new SonPlanFacade(new SonPlanModel());
		protected SonPlanFacade(SonPlanModel model) : base(model)
		{
		}
		public static SonPlanFacade Instance
		{
			get { return instance; }
		}
		protected SonPlanFacade():base() 
		{ 
		} 
	
	}
}
	