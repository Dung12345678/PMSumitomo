using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IE.Utils;
using IE.Model;
using IE.Business;
using System.Collections;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using System.Reflection;
using System.Threading;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using System.Diagnostics;
using DevExpress.XtraGrid.Localization;
using iTextSharp;
using iTextSharp.text.pdf;
using DevExpress.Utils;
using IOEx;
using Excel = Microsoft.Office.Interop.Excel;

namespace BMS
{
	public partial class frmHistoryCheckHP : _Forms
	{
		string _pathError = Path.Combine(Application.StartupPath, "Errors");
		private string _pathFileConfigUpdateImage = Path.Combine(Application.StartupPath, "DownloadImageKhuon.txt");
		private string _pathFolderLocal;
		private string _pathUpdateServer;
		public string _KnifeDetailCode;
		public string _OrderCode;
		public frmHistoryCheckHP()
		{
			InitializeComponent();
		}

		private void frmHistoryCheck_Load(object sender, EventArgs e)
		{
			dtpFromDate.Value = DateTime.Now;
			dtpEndDate.Value = DateTime.Now;
		}

		void loadData()
		{
			DateTime from = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
			DateTime to = new DateTime(dtpEndDate.Value.Year, dtpEndDate.Value.Month, dtpEndDate.Value.Day, 23, 59, 59);

			DataTable dt = TextUtilsHP.LoadDataFromSP("spLoadCheckHistory", "A"
				, new string[] { "@DateStart", "@DateEnd", "@Text", "@Chk" }
				, new object[] { from, to, txtFindText.Text.Trim(), cboLoai.SelectedIndex });
			grdData.DataSource = dt;
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			loadData();
		}

		private void txtFindText_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnFind_Click(null, null);
			}
		}

		private void grvData_DoubleClick(object sender, EventArgs e)
		{
			if (grvData.RowCount > 0)
			{
				frmHistoryCheckDetailHP frm = new frmHistoryCheckDetailHP();
				frm.Check = cboLoai.SelectedIndex;
				frm.CheckHistoryID = TextUtilsHP.ToInt(grvData.GetFocusedRowCellValue(colID));
				frm.Order = TextUtilsHP.ToString(grvData.GetFocusedRowCellValue(colKnifeCode));
				frm.KnifeCode = TextUtilsHP.ToString(grvData.GetFocusedRowCellValue(colKnifeCode));
				frm.Show();
			}
		}

		private void btnExportExecl_Click(object sender, EventArgs e)
		{
			try
			{
				if (grvData.RowCount > 0)
				{
					FolderBrowserDialog od = new FolderBrowserDialog();
					if (od.ShowDialog() == DialogResult.OK)
					{
						TextUtilsHP.ExportExcel(grvData, od.SelectedPath, string.Format("Danh sách dụng cụ{0}", DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private void xEMẢNHHYPONICTHEOQRCODEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!File.Exists(_pathFileConfigUpdateImage)) return;
			try
			{
				_KnifeDetailCode = TextUtils.ToString(grvData.GetFocusedRowCellValue(colKnifeDetailCode));//Mã hàng
				_OrderCode = TextUtils.ToString(grvData.GetFocusedRowCellValue(colOrderCode));//Order
				string[] lines = File.ReadAllLines(_pathFileConfigUpdateImage);
				if (lines == null) return;
				if (lines.Length < 2) return;
				string[] stringSeparators = new string[] { "||" };
				string[] arr = lines[1].Split(stringSeparators, 4, StringSplitOptions.RemoveEmptyEntries);

				if (arr == null) return;
				if (arr.Length < 4) return;

				_pathFolderLocal = Path.Combine(Application.StartupPath, arr[1].Trim());
				_pathUpdateServer = arr[2].Trim();
				if (!Directory.Exists(_pathError))
				{
					Directory.CreateDirectory(_pathError);
				}
				if (!Directory.Exists(_pathFolderLocal))
				{
					Directory.CreateDirectory(_pathFolderLocal);
				}
				// File lưu Sound
				string path = "";
				FolderBrowserDialog f = new FolderBrowserDialog();
				if (f.ShowDialog() == DialogResult.OK)
				{
					path = f.SelectedPath;
				}
				else
				{
					path = _pathFolderLocal;
				}
				string fileName = $"{_OrderCode}_{_KnifeDetailCode}.jpg";
				DocUtils.DownloadFile(path, fileName, Path.Combine(_pathUpdateServer, fileName));
				Process.Start($"{path}\\{fileName}");
			}
			catch
			{
				MessageBox.Show("Lỗi đường dẫn không tìm thấy ảnh", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
