using DevExpress.CodeParser;
using BMS.Business;
using BMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.util;
using System.Windows.Forms;

namespace BMS
{

	public partial class frmWeightDetailAltax : _Forms
	{
		public WeightModel weightModel=new WeightModel();

		public frmWeightDetailAltax()
		{
			InitializeComponent();
		}
		private void frmProductWorkingDetail_Load(object sender, EventArgs e)
		{
			loadCboProductGroup();
			loadData();

		}
		void loadCboProductGroup()
		{
			DataTable dt = new DataTable();
			dt = TextUtils.Select(string.Format("SELECT ID,ProductGroupCode FROM SumitomoTest.dbo.ProductGroup"));

			cboProductGroup.DataSource = dt;
			cboProductGroup.DisplayMember = "ProductGroupCode";
			cboProductGroup.ValueMember = "ID";
		}

		/// <summary>
		/// Load dữ liệu vào form
		/// </summary>
		void loadData()
		{
			txtPlateWeight.Text = TextUtils.ToString(weightModel.PlateWeight);
			txtJigWeight.Text = TextUtils.ToString(weightModel.JigWeight);
			cboProductGroup.Text = weightModel.ProductGroup;
		}

		/// <summary>
		/// Validate trước khi cất dữ liệu
		/// </summary>
		/// <returns></returns>
		private bool ValidateForm()
		{
			if (cboProductGroup.Text.Trim() == null)
			{
				MessageBox.Show("Xin hãy chọn nhóm sản phẩm.", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			string sql1 = "";
			if (weightModel.ID > 0)
			{
				sql1 = $"SELECT top 1 ID from SumitomoTest.dbo.Weight WHERE ProductGroup = '{cboProductGroup.Text.Trim()}' and ID <>'{weightModel.ID}'";
			}
			else
			{
				sql1 = $"SELECT top 1 ID from SumitomoTest.dbo.Weight WHERE ProductGroup = '{cboProductGroup.Text.Trim()}'";
			}
			int id = TextUtils.ToInt(TextUtils.ExcuteScalar(sql1));
			if (id > 0)
			{
				MessageBox.Show("Trùng nhóm sản phẩm", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			return true;
		}

		/// <summary>
		/// Cất dữ liệu
		/// </summary>
		/// <returns></returns>
		bool saveData()
		{
			if (!ValidateForm())
				return false;


			weightModel.ProductGroup = cboProductGroup.Text.Trim();
			weightModel.JigWeight = TextUtils.ToDecimal(txtJigWeight.Text.Trim());
			weightModel.PlateWeight = TextUtils.ToDecimal(txtPlateWeight.Text.Trim()); ;

			if (weightModel.ID > 0)
			{
				WeightBO.Instance.Update(weightModel);
				return true;

			}
			else
			{
				WeightBO.Instance.Insert(weightModel);
			}
			return true;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{

			if (saveData())
			{
				this.DialogResult = DialogResult.OK;
			}

		}

		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			if (saveData())
			{
				weightModel = new WeightModel();
				loadData();
				cboProductGroup.Focus();
			}
		}
		private void frmWorkingDetail_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSave_Click(null, null);
		}

		private void saveNewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveNew_Click(null, null);
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
	}
}
