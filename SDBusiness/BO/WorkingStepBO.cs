
using System;
using System.Collections;
using SD.Facade;
using SD.Model;
namespace SD.Business
{

	
	public class WorkingStepBO : BaseBO
	{
		private WorkingStepFacade facade = WorkingStepFacade.Instance;
		protected static WorkingStepBO instance = new WorkingStepBO();

		protected WorkingStepBO()
		{
			this.baseFacade = facade;
		}

		public static WorkingStepBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	