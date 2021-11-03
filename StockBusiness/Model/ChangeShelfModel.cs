
using System;
namespace ST.Model
{
	public class ChangeShelfModel : BaseModel
	{
		private int iD;
		private string shelf;
		private string articleID;
		private DateTime? createDate;
		private bool isGeneral;
		private string paintingColor;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string Shelf
		{
			get { return shelf; }
			set { shelf = value; }
		}
	
		public string ArticleID
		{
			get { return articleID; }
			set { articleID = value; }
		}
	
		public DateTime? CreateDate
		{
			get { return createDate; }
			set { createDate = value; }
		}
	
		public bool IsGeneral
		{
			get { return isGeneral; }
			set { isGeneral = value; }
		}
	
		public string PaintingColor
		{
			get { return paintingColor; }
			set { paintingColor = value; }
		}
	
	}
}
	