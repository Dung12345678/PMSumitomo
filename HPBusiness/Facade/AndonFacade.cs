
using System.Collections;
using HP.Model;
namespace HP.Facade
{
	
	public class AndonFacade : BaseFacade
	{
		protected static AndonFacade instance = new AndonFacade(new AndonModel());
		protected AndonFacade(AndonModel model) : base(model)
		{
		}
		public static AndonFacade Instance
		{
			get { return instance; }
		}
		protected AndonFacade():base() 
		{ 
		} 
	
	}
}
	