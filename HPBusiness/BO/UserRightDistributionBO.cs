
using System;
using System.Collections;
using HP.Facade;
using HP.Model;
namespace HP.Business
{

	
	public class UserRightDistributionBO : BaseBO
	{
		private UserRightDistributionFacade facade = UserRightDistributionFacade.Instance;
		protected static UserRightDistributionBO instance = new UserRightDistributionBO();

		protected UserRightDistributionBO()
		{
			this.baseFacade = facade;
		}

		public static UserRightDistributionBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	