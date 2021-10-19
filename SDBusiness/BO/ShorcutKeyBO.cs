
using System;
using System.Collections;



using SD.Facade;
using SD.Model;
namespace SD.Business
{

	
	public class ShorcutKeyBO : BaseBO
	{
		private ShorcutKeyFacade facade = ShorcutKeyFacade.Instance;
		protected static ShorcutKeyBO instance = new ShorcutKeyBO();

		protected ShorcutKeyBO()
		{
			this.baseFacade = facade;
		}

		public static ShorcutKeyBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	