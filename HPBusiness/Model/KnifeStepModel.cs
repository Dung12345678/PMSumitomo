
using System;
namespace HP.Model
{
	public class KnifeStepModel : BaseModel
	{
		private int iD;
		private int workingStepID;
		private int knifeDetailListID;
		private string productStepCode;
		private string description;
		private int parentID;
		private int sortOrder;
		private string createdBy;
		private DateTime? createdDate;
		private string updatedBy;
		private DateTime? updatedDate;
		private bool isDeleted;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public int WorkingStepID
		{
			get { return workingStepID; }
			set { workingStepID = value; }
		}
	
		public int KnifeDetailListID
		{
			get { return knifeDetailListID; }
			set { knifeDetailListID = value; }
		}
	
		public string ProductStepCode
		{
			get { return productStepCode; }
			set { productStepCode = value; }
		}
	
		public string Description
		{
			get { return description; }
			set { description = value; }
		}
	
		public int ParentID
		{
			get { return parentID; }
			set { parentID = value; }
		}
	
		public int SortOrder
		{
			get { return sortOrder; }
			set { sortOrder = value; }
		}
	
		public string CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}
	
		public DateTime? CreatedDate
		{
			get { return createdDate; }
			set { createdDate = value; }
		}
	
		public string UpdatedBy
		{
			get { return updatedBy; }
			set { updatedBy = value; }
		}
	
		public DateTime? UpdatedDate
		{
			get { return updatedDate; }
			set { updatedDate = value; }
		}
	
		public bool IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
		}
	
	}
}
	