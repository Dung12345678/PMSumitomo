using BMS.Business;
using BMS.Model;
using ST.Business;
using ST.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
	public partial class frmPartImExHistory : _Forms
	{
		public frmPartImExHistory()
		{
			InitializeComponent();
			dtgvHistory.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
		}
		int prevRow;

		void LoadData()
		{
			int type = 2;
			if (rbAll.Checked)
			{
				type = 2;
			}
			if (rbImport.Checked)
			{
				type = 0;
			}
			if (rbExport.Checked)
			{
				type = 1;
			}

			DateTime timeFrom = dtpFrom.Value;
			DateTime timeTo = dtpTo.Value;
			string keyword = txbSearchHistory.Text;
			DataTable dataTable = TextUtilsStock.LoadDataFromSP("spGetHistoryByDate", "VS", new string[] { "@dateFrom", "@dateTo", "@keyword", "@filter" }, new object[] { timeFrom.ToString("yyyy/MM/dd HH:mm:ss")
										, timeTo.ToString("yyyy/MM/dd HH:mm:ss")
										, keyword
										, type

						   });
			dtgvHistory.DataSource = dataTable;
		}

		private void btnSearchHistory_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void frmPartImExHistory_Load(object sender, EventArgs e)
		{

			LoadData();

		}



		private void btnDelPart_Click(object sender, EventArgs e)
		{
			if (!gvHistory.IsDataRow(gvHistory.FocusedRowHandle))
				return;
			int strID = TextUtilsStock.ToInt(gvHistory.GetFocusedRowCellValue("ID"));
			string str = TextUtilsStock.ToString(gvHistory.GetFocusedRowCellValue("PartCode"));

			try
			{
				if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa lịch sử sản phẩm [{0}] không?", str), TextUtilsStock.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					SONHistoryImExBO.Instance.Delete(strID);
					LoadData();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hệ thống!", TextUtilsStock.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}
		}

		private void btnEditPart_Click(object sender, EventArgs e)
		{
			int id = TextUtilsStock.ToInt(gvHistory.GetFocusedRowCellValue(colID));
			if (id == 0) return;
			SONHistoryImExModel model = (SONHistoryImExModel)SONHistoryImExBO.Instance.FindByPK(id);
			frmAddEditHistory form = new frmAddEditHistory(); // Sua thong tin san pham
			form.model = model;
			if (form.ShowDialog() == DialogResult.OK)
			{
				LoadData();
				//  Tu dong focus lai ve dong vua chon
				gvHistory.FocusedRowHandle = prevRow;
			}
		}

		private void rbAll_CheckedChanged(object sender, EventArgs e)
		{
			LoadData();
		}

		private void dtpFrom_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				btnSearchHistory_Click(null, null);
			}
		}

		private void dtpTo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				btnSearchHistory_Click(null, null);
			}
		}

		private void btnExportExcel_Click(object sender, EventArgs e)
		{
			try
			{
				if (gvHistory.RowCount > 0)
				{
					FolderBrowserDialog od = new FolderBrowserDialog();
					if (od.ShowDialog() == DialogResult.OK)
					{
						TextUtilsStock.ExportExcel(gvHistory, od.SelectedPath, string.Format("DanhSachLichSuNhapXuatSon_{0}", DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void txbSearchHistory_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			btnSearchHistory_Click(null, null);

		}
	}
}
