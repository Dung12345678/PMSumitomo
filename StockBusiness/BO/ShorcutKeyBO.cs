
using System;
using System.Collections;



using ST.Facade;
using ST.Model;
namespace ST.Business
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
	