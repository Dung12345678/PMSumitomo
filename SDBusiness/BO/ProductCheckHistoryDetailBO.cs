
using System;
using System.Collections;
using SD.Facade;
using SD.Model;
namespace SD.Business
{

	
	public class ProductCheckHistoryDetailBO : BaseBO
	{
		private ProductCheckHistoryDetailFacade facade = ProductCheckHistoryDetailFacade.Instance;
		protected static ProductCheckHistoryDetailBO instance = new ProductCheckHistoryDetailBO();

		protected ProductCheckHistoryDetailBO()
		{
			this.baseFacade = facade;
		}

		public static ProductCheckHistoryDetailBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	