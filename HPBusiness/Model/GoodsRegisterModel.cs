
using System;
namespace HP.Model
{
	public class GoodsRegisterModel : BaseModel
	{
		private int iD;
		private int goodsID;
		private int toolsID;
		private string cD;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public int GoodsID
		{
			get { return goodsID; }
			set { goodsID = value; }
		}
	
		public int ToolsID
		{
			get { return toolsID; }
			set { toolsID = value; }
		}
	
		public string CD
		{
			get { return cD; }
			set { cD = value; }
		}
	
	}
}
	