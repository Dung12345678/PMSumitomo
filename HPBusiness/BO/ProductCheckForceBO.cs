
using System;
using System.Collections;
using HP.Facade;
using HP.Model;
namespace HP.Business
{

	
	public class ProductCheckForceBO : BaseBO
	{
		private ProductCheckForceFacade facade = ProductCheckForceFacade.Instance;
		protected static ProductCheckForceBO instance = new ProductCheckForceBO();

		protected ProductCheckForceBO()
		{
			this.baseFacade = facade;
		}

		public static ProductCheckForceBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	