
using System.Collections;
using HP.Model;
namespace HP.Facade
{
	
	public class MotorPositionListFacade : BaseFacade
	{
		protected static MotorPositionListFacade instance = new MotorPositionListFacade(new MotorPositionListModel());
		protected MotorPositionListFacade(MotorPositionListModel model) : base(model)
		{
		}
		public static MotorPositionListFacade Instance
		{
			get { return instance; }
		}
		protected MotorPositionListFacade():base() 
		{ 
		} 
	
	}
}
	