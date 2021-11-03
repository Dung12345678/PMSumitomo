using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS.Business;
using IE.Model;
using DevExpress.Utils;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace BMS
{
	public partial class frmExportAssemble : _Forms
	{
		int CboDsLK = 0;
		int CboStep = 0;
		public DateTime DateLR;
		string accessory = "";
		DataTable dtnew = new DataTable();
		DataTable dtLapRap = new DataTable();
		DataTable dtAccessory = new DataTable();
		DataTable dtGrvAccessory = new DataTable();
		int productID = 0;
		int countStepCode; // tổng cổng đoạn
		DataTable dtStepAccessory = new DataTable();
		int CheckHypOrAltax = 0; //Check = 1 Altax , Check = 2 Hyp
		DataTable dtStepAssemble = new DataTable();


		public frmExportAssemble()
		{
			InitializeComponent();
		}
		private void frmExportAssemble_Load(object sender, EventArgs e)
		{
			pnlLapRap.Visible = pnlLinhkienlaprap.Visible = btnExcelAssemble.Visible = false;
		}

		#region Event
		/// <summary>
		/// lấy ra danh sách lắp ráp
		/// </summary>
		void loadLapRap()
		{
			if (CheckHypOrAltax == 2)//Hyp=2
				dtLapRap = LibIE.Select($"SELECT CAST(ROW_NUMBER()OVER(PARTITION BY s.SortOrder ORDER BY s.SortOrder,PD.CreatedDate) as nvarchar(150)) AS RowNum,PD.*, CAST(s.SortOrder as varchar(20)) + ' - ' + PD.ProductStepCode + ' - ' + PD.ProductStepName + N'  -  Người lắp: ' + pD.WorkerCode + ' - ' + PD.Line AS ProductStepInfo, PD.ValueTypeName AS ValueTypeText,PD.RealValue FROM dbo.ProductCheckHistoryDetail PD left join ProductStep s on s.ID = pd.ProductStepID WHERE PD.QRCode = '{txtQRCode.Text}'");
			else if (CheckHypOrAltax == 1) //Altax =1
				dtLapRap = TextUtils.Select($"SELECT CAST(ROW_NUMBER()OVER(PARTITION BY s.SortOrder ORDER BY s.SortOrder,PD.CreatedDate) as nvarchar(150)) AS RowNum,PD.*, CAST(s.SortOrder as varchar(20)) + ' - ' + PD.ProductStepCode + ' - ' + PD.ProductStepName + N'  -  Người lắp: ' + pD.WorkerCode + ' - ' + PD.Line AS ProductStepInfo, PD.ValueTypeName AS ValueTypeText,PD.RealValue FROM dbo.ProductCheckHistoryDetail PD left join ProductStep s on s.ID = pd.ProductStepID WHERE PD.QRCode = '{txtQRCode.Text}'");
			grdLapRap.DataSource = dtLapRap;
		}

		/// <summary>
		/// lấy ra danh sách linh kiện lắp ráp
		/// </summary>
		void loadLinhKienLapRap()
		{
			DataSet ds = TextUtilsHP.GetListDataFromSP("spGetExportComponent", new string[] { "@Code" }, new object[] { accessory });
			dtGrvAccessory = ds.Tables[0];
			dtStepAccessory = ds.Tables[1];
			if (dtGrvAccessory != null && dtGrvAccessory.Rows.Count > 0)
			{
				txtAccessory.Text = TextUtils.ToString(dtGrvAccessory.Rows[0]["OrderMachining"]);
			}
			else
			{
				txtAccessory.Text = "";
			}

			DataRow dr = dtStepAccessory.NewRow();
			dr["ProductStepCode"] = "";
			dr["ID"] = 0;
			dtStepAccessory.Rows.InsertAt(dr, 0);
			cbStepCode.DisplayMember = "ProductStepCode";
			cbStepCode.ValueMember = "ID";
			cbStepCode.DataSource = dtStepAccessory;

		}

		/// <summary>
		/// lấy ra danh sách công đoạn
		/// </summary>
		void loadStepCode()
		{
			//if (productID == 0)
			//{
			//	cbStepCode.Properties.DataSource = "";
			//	return;
			//}
			//dtStepAssemble = LibIE.GetDataTableFromSP("spGetStepCode", new string[] { "@ProductID", "@Check" }, new object[] { productID, CheckHypOrAltax });

			//if (dtStepAssemble.Rows.Count > 0)
			//{
			//	cbStepCode.Properties.DisplayMember = "ProductStepCode";
			//	cbStepCode.Properties.ValueMember = "ID";
			//	cbStepCode.Properties.DataSource = dtStepAssemble;
			//	countStepCode = dtStepAssemble.Rows.Count;
			//}
		}

		/// <summary>
		/// danh sách linh kiện
		/// </summary>
		void loadAccessory()
		{
			dtAccessory = TextUtilsStock.LoadDataFromSP("spGetAccessory", "A", new string[] { "@OrderCode", "@CheckColumn" }, new object[] { txtOrderCode.Text.Trim(), ShowColumn });
			if (dtAccessory == null || dtAccessory.Rows.Count <= 0) return;
			DataRow dr = dtAccessory.NewRow();
			dr["SumColumn"] = "";
			dr["Stt"] = 0;
			dtAccessory.Rows.InsertAt(dr, 0);
			cbAccessory.DisplayMember = "SumColumn";
			cbAccessory.ValueMember = "Stt";
			cbAccessory.DataSource = dtAccessory;
			cbAccessory.SelectedIndex = CboDsLK;
		}
		#endregion

		private bool ValidateForm()
		{
			if (txtQRCode.Text.Trim() == "")
			{
				MessageBox.Show("Vui lòng nhập mã QR-Code!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			if (txtProductCode.Text.Trim() == "")
			{
				MessageBox.Show("Vui lòng kiểm tra mã hàng đang để trống!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			if (txtOrderCode.Text.Trim() == "")
			{
				MessageBox.Show("Vui lòng kiểm tra số order đang để trống!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			if (cbAccessory.Text.Trim() == "")
			{
				MessageBox.Show("Vui lòng kiểm tra danh sách linh kiện đang để trống!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			return true;
		}

		private void txtOrder_TextChanged(object sender, EventArgs e)
		{
			//if (txtOrderCode.Text != "") loadAccessory();
		}

		#region Button Event
		/// <summary>
		/// Click button reset
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnReset_Click(object sender, EventArgs e)
		{
			CheckHypOrAltax = 0;
			txtQRCode.Clear();
			txtProductCode.Clear();
			txtOrderCode.Clear();
			pnlLapRap.Visible = pnlLinhkienlaprap.Visible = btnExcelAssemble.Visible = chkLapRap.Checked = chkLinhKienLapRap.Checked = false;
			cbAccessory.SelectedIndex = -1;
			cbStepCode.DataSource = null;
			for (int i = grvLinhKienLapRap.RowCount - 1; i >= 0; i--)
			{
				grvLinhKienLapRap.DeleteRow(i);
			}
		}

		/// <summary>
		/// Click button xuất file Excel linh kiện lắp ráp
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnExportExcelLinhKien_Click(object sender, EventArgs e)
		{
			if (!ValidateForm()) return;

			string path = "";
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			if (fbd.ShowDialog() == DialogResult.OK)
			{
				path = fbd.SelectedPath;
			}
			else
			{
				return;
			}
			string fileSourceName = "ExportComponent.xlsx";

			string sourcePath = Application.StartupPath + "\\" + fileSourceName;
			string currentPath = path + "\\" + txtQRCode.Text.Trim() + ".xlsx";
			try
			{
				File.Copy(sourcePath, currentPath, true);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Có lỗi khi tạo phiếu!" + Environment.NewLine + ex.Message,
					TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}

			using (WaitDialogForm fWait = new WaitDialogForm("Vui lòng chờ trong giây lát...", "Đang tạo phiếu..."))
			{
				System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
				Excel.Application app = default(Excel.Application);
				Excel.Workbook workBoook = default(Excel.Workbook);
				Excel.Worksheet workSheet = default(Excel.Worksheet);
				try
				{
					app = new Excel.Application();
					app.Workbooks.Open(currentPath);
					workBoook = app.Workbooks[1];
					workSheet = (Excel.Worksheet)workBoook.Worksheets[1];

					workSheet.Cells[3, 2] = txtQRCode.Text.Trim();
					workSheet.Cells[3, 13] = chkLinhKienLapRap.Text.Trim();
					workSheet.Cells[5, 2] = txtProductCode.Text.Trim();
					workSheet.Cells[6, 2] = txtOrderCode.Text.Trim();
					workSheet.Cells[8, 1] = "Linh Kiện";
					for (int i = 2; i < grvLinhKienLapRap.Columns.Count; i++)
					{
						workSheet.Cells[8, i] = TextUtilsHP.ToString(grvLinhKienLapRap.Columns[i].Caption);
					}
					for (int i = grvLinhKienLapRap.RowCount - 1; i >= 0; i--)
					{
						workSheet.Cells[10, 1] = i + 1;
						workSheet.Cells[10, 2] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colPartCode));
						workSheet.Cells[10, 3] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colQRCode));
						workSheet.Cells[10, 4] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colOrder));
						workSheet.Cells[10, 5] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue));
						workSheet.Cells[10, 6] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue1));
						workSheet.Cells[10, 7] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue2));
						workSheet.Cells[10, 8] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue3));
						workSheet.Cells[10, 9] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue4));
						workSheet.Cells[10, 10] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue5));
						workSheet.Cells[10, 11] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue6));
						workSheet.Cells[10, 12] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue7));
						workSheet.Cells[10, 13] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue8));
						workSheet.Cells[10, 14] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue9));
						workSheet.Cells[10, 15] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue10));
						workSheet.Cells[10, 16] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue11));
						workSheet.Cells[10, 17] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue12));
						workSheet.Cells[10, 18] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue13));
						workSheet.Cells[10, 19] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue14));
						workSheet.Cells[10, 20] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue15));
						workSheet.Cells[10, 21] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue16));
						workSheet.Cells[10, 22] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue17));
						workSheet.Cells[10, 24] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue18));
						workSheet.Cells[10, 24] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue19));
						workSheet.Cells[10, 25] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue20));
						workSheet.Cells[10, 26] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue21));
						workSheet.Cells[10, 27] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue22));
						workSheet.Cells[10, 28] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue23));
						workSheet.Cells[10, 29] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue24));
						workSheet.Cells[10, 30] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue25));
						workSheet.Cells[10, 31] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue26));
						workSheet.Cells[10, 32] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue27));
						workSheet.Cells[10, 33] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue28));
						workSheet.Cells[10, 34] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue29));
						workSheet.Cells[10, 35] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue30));
						workSheet.Cells[10, 36] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue31));
						workSheet.Cells[10, 37] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue32));
						workSheet.Cells[10, 38] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue33));
						workSheet.Cells[10, 39] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue34));
						workSheet.Cells[10, 40] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue35));
						workSheet.Cells[10, 41] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue36));
						workSheet.Cells[10, 42] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue37));
						workSheet.Cells[10, 43] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue38));
						workSheet.Cells[10, 44] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue39));
						workSheet.Cells[10, 45] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue40));
						workSheet.Cells[10, 46] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue41));
						workSheet.Cells[10, 47] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue42));
						workSheet.Cells[10, 48] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue43));
						workSheet.Cells[10, 49] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue44));
						workSheet.Cells[10, 50] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue45));
						workSheet.Cells[10, 51] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue46));
						workSheet.Cells[10, 52] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue47));
						workSheet.Cells[10, 53] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue48));
						workSheet.Cells[10, 54] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(i, colRealValue49));
						((Excel.Range)workSheet.Rows[10]).Insert();
					}
					((Excel.Range)workSheet.Rows[9]).Delete();
					((Excel.Range)workSheet.Rows[9]).Delete();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					if (app != null)
					{
						app.ActiveWorkbook.Save();
						app.Workbooks.Close();
						app.Quit();
					}
				}
				Process.Start(currentPath);
			}
		}

		/// <summary>
		/// click button xóa dòng
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			grvLinhKienLapRap.DeleteSelectedRows();
		}

		/// <summary>
		/// CLICK button xuất file excel lắp ráp
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnExportExcelLapRap_Click(object sender, EventArgs e)
		{
			if (grvLapRap.RowCount <= 0) return;
			string filePath = TextUtils.ExportExcelReturnFilePath(grvLapRap, txtQRCode.Text.Trim());
			if (string.IsNullOrEmpty(filePath)) return;

			Excel.Application app = default(Excel.Application);
			Excel.Workbook workBoook = default(Excel.Workbook);
			Excel.Worksheet workSheet = default(Excel.Worksheet);
			try
			{
				app = new Excel.Application();
				app.Workbooks.Open(filePath);
				workBoook = app.Workbooks[1];
				workSheet = (Excel.Worksheet)workBoook.Worksheets[1];
				app.DisplayAlerts = false;
				for (int i = 0; i < 5; i++)
				{
					((Excel.Range)workSheet.Rows[1]).Insert();
				}
				string[] arr = txtQRCode.Text.Split(' ');
				workSheet.Cells[1, 1] = "Order No:";
				workSheet.Cells[1, 2] = txtQRCode.Text;
				workSheet.Cells[2, 1] = "PID No:";
				workSheet.Cells[2, 2] = arr[1];
				DataTable dt = TextUtils.GetDataTableFromSP("spExportQC", new string[] { "@ProductCode" }, new object[] { TextUtils.ToString(arr[1].Trim()) });
				if (dt == null || dt.Rows.Count <= 0) return;
				workSheet.Cells[3, 1] = "Mô Tả";
				workSheet.Cells[3, 2] = dt.Rows[0]["ProductName"];
				workSheet.Cells[4, 1] = "Ngày lắp:";
				workSheet.Cells[4, 2] = "'" + DateLR.ToString("dd/MM/yyyy");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
			finally
			{
				app.ActiveWorkbook.Save();
				app.Workbooks.Close();
				app.Quit();

				Process.Start(filePath);
			}
		}


		/// <summary>
		/// click xuất excel tổng 2 bảng
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnExcelAssemble_Click(object sender, EventArgs e)
		{
			//if (grvLapRap.RowCount <= 0) return;
			//SaveFile();

			if (grvLapRap.RowCount <= 0) return;
			string filePath = TextUtils.ExportExcelReturnFilePath(grvLapRap, txtQRCode.Text);
			if (string.IsNullOrEmpty(filePath)) return;

			Excel.Application app = default(Excel.Application);
			Excel.Workbook workBoook = default(Excel.Workbook);
			Excel.Worksheet workSheet = default(Excel.Worksheet);
			try
			{
				app = new Excel.Application();
				app.Workbooks.Open(filePath);
				workBoook = app.Workbooks[1];
				workSheet = (Excel.Worksheet)workBoook.Worksheets[1];
				app.DisplayAlerts = false;
				for (int i = 0; i < 6; i++)
				{
					((Excel.Range)workSheet.Rows[1]).Insert();
				}
				string[] arr = txtQRCode.Text.Split(' ');
				workSheet.Cells[1, 1] = "QR-Code";
				workSheet.Cells[1, 2] = txtQRCode.Text;
				workSheet.Cells[2, 1] = "PID No:";
				workSheet.Cells[2, 2] = arr[1];
				workSheet.Cells[3, 1] = "KT dữ liệu";
				workSheet.Cells[3, 2] = chkLapRap.Text;
				workSheet.Cells[4, 1] = "DS linh kiện:";
				workSheet.Cells[4, 2] = cbAccessory.Text;
				workSheet.Cells[5, 1] = "Linh kiện";
				workSheet.Cells[5, 2] = txtAccessory.Text;

				int number = grvLapRap.RowCount + 10;
				for (int j = number; j <= number + grvLinhKienLapRap.RowCount; j++)
				{
					int k = j - number - 1;
					// hiển thị dòng đầu header "HLM"
					if (j == number)
					{
						workSheet.Cells[j, 1] = "Linh Kiện";
						workSheet.Cells[j, 2] =TextUtils.ToString(grvLinhKienLapRap.Columns[3].Caption);
						workSheet.Cells[j, 3] = TextUtils.ToString(grvLinhKienLapRap.Columns[3].Caption);
						workSheet.Cells[j, 1].Style.Font.Size = workSheet.Cells[j, 2].Style.Font.Size = workSheet.Cells[j, 3].Style.Font.Size = 16;
						workSheet.Cells[j, 2].Interior.Color = workSheet.Cells[j, 3].Interior.Color = Excel.XlRgbColor.rgbDarkOrange; // màu
						workSheet.Cells[j, 1].Style.HorizontalAlignment = workSheet.Cells[j, 2].Style.HorizontalAlignment = workSheet.Cells[j, 3].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; // căn giữa

						for (int m = 4; m <= 21; m++)
						{
							workSheet.Cells[j, m] = grvLinhKienLapRap.Columns[m].Caption;
							workSheet.Cells[j, m].Style.Font.Size = 16;
							workSheet.Cells[j, m].Interior.Color = Excel.XlRgbColor.rgbYellowGreen; // màu
							workSheet.Cells[j, m].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; // căn giữa
						}
					}
					else
					{
						#region
						workSheet.Cells[j, 1] = k + 1;
						workSheet.Cells[j, 2] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colPartCode));
						workSheet.Cells[j, 3] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colQRCode));
						workSheet.Cells[j, 4] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colOrder));
						//workSheet.Cells[j, 2] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colCodeFull));
						//workSheet.Cells[j, 3] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colCodeShort));
						//workSheet.Cells[j, 3].NumberFormat = "000";
						workSheet.Cells[j, 5] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue));
						workSheet.Cells[j, 6] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue1));
						workSheet.Cells[j, 7] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue2));
						workSheet.Cells[j, 8] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue3));
						workSheet.Cells[j, 9] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue4));
						workSheet.Cells[j, 10] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue5));
						workSheet.Cells[j, 11] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue6));
						workSheet.Cells[j, 12] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue7));
						workSheet.Cells[j, 13] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue8));
						workSheet.Cells[j, 14] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue9));
						workSheet.Cells[j, 15] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue10));
						workSheet.Cells[j, 16] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue11));
						workSheet.Cells[j, 17] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue12));
						workSheet.Cells[j, 18] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue13));
						workSheet.Cells[j, 19] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue14));
						workSheet.Cells[j, 20] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue15));
						workSheet.Cells[j, 21] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue16));
						workSheet.Cells[j, 22] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue17));
						workSheet.Cells[j, 23] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue18));
						workSheet.Cells[j, 24] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue19));
						workSheet.Cells[j, 25] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue20));
						workSheet.Cells[j, 26] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue21));
						workSheet.Cells[j, 27] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue22));
						workSheet.Cells[j, 28] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue23));
						workSheet.Cells[j, 29] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue24));
						workSheet.Cells[j, 30] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue25));
						workSheet.Cells[j, 31] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue26));
						workSheet.Cells[j, 32] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue27));
						workSheet.Cells[j, 33] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue28));
						workSheet.Cells[j, 34] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue29));
						workSheet.Cells[j, 35] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue30));
						workSheet.Cells[j, 36] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue31));
						workSheet.Cells[j, 37] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue32));
						workSheet.Cells[j, 38] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue33));
						workSheet.Cells[j, 39] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue34));
						workSheet.Cells[j, 40] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue35));
						workSheet.Cells[j, 41] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue36));
						workSheet.Cells[j, 42] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue37));
						workSheet.Cells[j, 43] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue38));
						workSheet.Cells[j, 44] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue39));
						workSheet.Cells[j, 45] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue40));
						workSheet.Cells[j, 46] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue41));
						workSheet.Cells[j, 47] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue42));
						workSheet.Cells[j, 48] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue43));
						workSheet.Cells[j, 49] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue44));
						workSheet.Cells[j, 50] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue45));
						workSheet.Cells[j, 51] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue46));
						workSheet.Cells[j, 52] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue47));
						workSheet.Cells[j, 53] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue48));
						workSheet.Cells[j, 54] = TextUtilsHP.ToString(grvLinhKienLapRap.GetRowCellValue(k, colRealValue49));
						#endregion
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
			finally
			{
				app.ActiveWorkbook.Save();
				app.Workbooks.Close();
				app.Quit();

				Process.Start(filePath);
			}
		}
		#endregion
		string ShowColumn;
		/// <summary>
		/// enter textbox QRCode
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtQRCode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				CheckHypOrAltax = 0;
				cbStepCode.Enabled = true;
				if (txtQRCode.Text != "")
				{
					cbAccessory.SelectedIndex = -1;
					txtOrderCode.Text = "";
					txtProductCode.Text = "";
				}
				DataTable dt = TextUtilsStock.GetDataTableFromSP("spGetSTTQC", new string[] { "@QRCode" }, new object[] { txtQRCode.Text.Trim() });
				if (dt != null && dt.Rows.Count > 0)
				{
					CheckHypOrAltax = TextUtils.ToInt(dt.Rows[0]["CheckH"]);
					txtProductCode.Text = TextUtils.ToString(dt.Rows[0]["ProductCode"]);
					txtOrderCode.Text = TextUtils.ToString(dt.Rows[0]["OrderCode"]);
					productID = TextUtils.ToInt(dt.Rows[0]["ProductID"]);
					cbAccessory.Enabled = true;
					ShowColumn = TextUtils.ToString(dt.Rows[0]["STT"]);
				}
				else productID = 0;
				loadAccessory();
				loadStepCode();
				loadLapRap();
			}
		}

		/// <summary>
		/// check  dữ liệu lắp ráp
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void chkLapRap_CheckedChanged(object sender, EventArgs e)
		{
			ShowPanel();
		}

		/// <summary>
		/// check linh kiện lắp ráp
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void chkLinhKienLapRap_CheckedChanged(object sender, EventArgs e)
		{
			ShowPanel();
		}

		/// <summary>
		/// hàm hiển thị panel khi chọn checkbox
		/// </summary>
		void ShowPanel()
		{
			if (chkLapRap.Checked == true && chkLinhKienLapRap.Checked == true)
			{
				pnlLapRap.Visible = pnlLinhkienlaprap.Visible = btnExcelAssemble.Visible = true;
				splitContainer1.Panel1.Show();
				splitContainer1.Panel2.Show();
				btnExportExcelLinhKien.Visible = btnExportExcelLapRap.Visible = false;
			}
			else
			{
				pnlLapRap.Visible = pnlLinhkienlaprap.Visible = btnExcelAssemble.Visible = false;
				btnExportExcelLinhKien.Visible = btnExportExcelLapRap.Visible = true;
			}
			if (chkLapRap.Checked == true)
			{
				pnlLapRap.Visible = true;
				splitContainer1.Panel1Collapsed = false;
				splitContainer1.Panel1.Show();
			}
			else
			{
				splitContainer1.Panel1Collapsed = true;
				splitContainer1.Panel1.Hide();
			}
			if (chkLinhKienLapRap.Checked == true)
			{
				pnlLinhkienlaprap.Visible = true;
				splitContainer1.Panel2Collapsed = false;
				splitContainer1.Panel2.Show();
			}
			else
			{
				splitContainer1.Panel2Collapsed = true;
				splitContainer1.Panel2.Hide();
			}
		}

		//public bool SaveFile()
		//{
		//    try
		//    {
		//        SpreadsheetInfo.SetLicense("ELAP-G41W-CZA2-XNNC");

		//        string filePath = TextUtils.ExportExcelReturnFilePath(grvLapRap, txtQRCode.Text.Trim());
		//        string filePathTemplate = Path.Combine(Application.StartupPath, "Templates") + Path.DirectorySeparatorChar + "Mau.xls";
		//        File.Copy(filePathTemplate, filePath, true);

		//        if (string.IsNullOrEmpty(filePath)) return false;

		//        GemBox.Spreadsheet.ExcelFile spreadsheet = new GemBox.Spreadsheet.ExcelFile();
		//        ExcelFile workbook = ExcelFile.Load(filePath);
		//        ExcelWorksheet worksheet = workbook.Worksheets[0];

		//        int iStart = worksheet.NamedRanges["Start_Table1"].Range.FirstRowIndex;
		//        int iStart2 = worksheet.NamedRanges["Start_Table2"].Range.FirstRowIndex;

		//        worksheet.Cells[2, 2].Value = txtQRCode.Text.Trim();
		//        worksheet.Cells[2, 13].Value = chkLinhKienLapRap.Text.Trim();
		//        worksheet.Cells[4, 2].Value = txtProductCode.Text.Trim();
		//        worksheet.Cells[5, 2].Value = txtOrderCode.Text.Trim();
		//        worksheet.Cells[5, 12].Value = txtAccessory.Text.Trim();

		//        // bảng lắp ráp
		//        //worksheet.Cells[iStart, 1].Value = "TRUONG1";
		//        for (int i = dtLapRap.Rows.Count - 1; i >= 0; i--)
		//        {
		//            worksheet.Cells[iStart + 3, 0].Value = TextUtilsHP.ToString(dtLapRap.Rows[i]["RowNum"]);
		//            worksheet.Cells[iStart + 3, 1].Value = TextUtilsHP.ToString(dtLapRap.Rows[i]["ProductWorkingName"]);
		//            worksheet.Cells[iStart + 3, 7].Value = TextUtilsHP.ToString(dtLapRap.Rows[i]["ValueTypeText"]);
		//            worksheet.Cells[iStart + 3, 10].Value = TextUtilsHP.ToString(dtLapRap.Rows[i]["StandardValue"]);
		//            worksheet.Rows.InsertEmpty(iStart + 3);
		//        }


		//        // bảng danh sách linh kiện
		//        //worksheet.Cells[iStart2 + 2, 1].Value = "TRUONG2";
		//        for (int i = grvLinhKienLapRap.RowCount - 1; i >= 0; i--)
		//        {
		//            worksheet.Cells[iStart2 + 2, 0].Value = i + 1;
		//            worksheet.Cells[iStart2 + 2, 1].Value = TextUtilsHP.ToString(dtnew.Rows[i]["CodeFull"]);
		//            worksheet.Cells[iStart2 + 2, 2].Value = TextUtilsHP.ToString(dtnew.Rows[i]["CodeShort"]);
		//            worksheet.Cells[iStart2 + 2, 3].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue"]);
		//            worksheet.Cells[iStart2 + 2, 4].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue1"]);
		//            worksheet.Cells[iStart2 + 2, 5].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue2"]);
		//            worksheet.Cells[iStart2 + 2, 6].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue3"]);
		//            worksheet.Cells[iStart2 + 2, 7].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue4"]);
		//            worksheet.Cells[iStart2 + 2, 8].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue5"]);
		//            worksheet.Cells[iStart2 + 2, 9].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue6"]);
		//            worksheet.Cells[iStart2 + 2, 10].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue7"]);
		//            worksheet.Cells[iStart2 + 2, 11].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue8"]);
		//            worksheet.Cells[iStart2 + 2, 12].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue9"]);
		//            worksheet.Cells[iStart2 + 2, 13].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue10"]);
		//            worksheet.Cells[iStart2 + 2, 14].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue11"]);
		//            worksheet.Cells[iStart2 + 2, 15].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue12"]);
		//            worksheet.Cells[iStart2 + 2, 16].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue13"]);
		//            worksheet.Cells[iStart2 + 2, 17].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue14"]);
		//            worksheet.Cells[iStart2 + 2, 18].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue15"]);
		//            worksheet.Cells[iStart2 + 2, 19].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue16"]);
		//            worksheet.Cells[iStart2 + 2, 20].Value = TextUtilsHP.ToString(dtnew.Rows[i]["RealValue17"]);
		//            worksheet.Rows.InsertEmpty(iStart2 + 2);
		//        }

		//        workbook.Save(filePath);
		//        Process.Start(filePath);
		//        return true;
		//    }
		//    catch (Exception ex)
		//    {
		//        return false;
		//    }
		//}

		/// <summary>
		/// enter txtAccessory
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtAccessory_KeyDown(object sender, KeyEventArgs e)
		{
			//if (e.KeyCode == Keys.Return)
			//{
			//	DataTable dt = TextUtilsHP.LoadDataFromSP("spGetExportComponent", "A", new string[] { "@Code" }, new object[] { txtAccessory.Text });
			//	dtnew = dt.Clone();
			//	dtnew.Clear();
			//	DataTable dtCurrent = (DataTable)grdLinhKienLapRap.DataSource;
			//	if (dtCurrent != null) dtnew.Merge(dtCurrent);
			//	if (dt != null) dtnew.Merge(dt);
			//	grdLinhKienLapRap.DataSource = dtnew;
			//}
		}

		private void cbAccessory_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (cbAccessory.Text.Trim() == "") return;
				string[] name = cbAccessory.Text.Trim().Split(',');
				if (name.Length > 1)
					accessory = name[name.Length - 2] + name[name.Length - 1];
				else
					accessory = cbAccessory.Text.Trim();
				loadLapRap();
				loadLinhKienLapRap();
				ShowPanel();
				CboDsLK = cbAccessory.SelectedIndex;
				cbStepCode.SelectedIndex = CboStep;
			}
			catch
			{

			}
		}

		private void cbStepCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				ShowPanel();
				//loadLapRap();
				string stepCode = TextUtils.ToString(cbStepCode.Text);
				if (stepCode == "") return;
				DataTable dtnew = dtGrvAccessory.Clone();
				DataTable dtCurrent = (DataTable)grdLinhKienLapRap.DataSource;

				string[] stepCodeSplit = stepCode.Split(',');
				for (int i = 0; i < stepCodeSplit.Count(); i++)
				{
					if (dtGrvAccessory == null || dtGrvAccessory.Rows.Count <= 0) return;
					DataRow[] dr = dtGrvAccessory.Select($"StepCode = '{stepCodeSplit[i].Trim()}'");

					//Tìm kiếm dòng có giống nhau không nếu giống nhau thì add cùng 1 dòng khác nhau thì thêm 1 dòng mới
					if (dr != null && dr.Length > 0 && dr.Count() > 0 && !Lib.ContainDataRowInDataTable(dtCurrent, dr[0]))
					{
						//Thêm dòng mới
						dtnew.Merge(dr.CopyToDataTable());
					}
					else
					{
						//Add cùng 1 dòng

						//Sửa tên cột theo công đoạn

					}
				}
				//Hiển thị dữ liệu linh kiện Dao

				if (dtCurrent != null)
				{
					for (int i = 0; i < grvLinhKienLapRap.RowCount; i++)
					{
						string PartCode = TextUtils.ToString(grvLinhKienLapRap.GetRowCellValue(i, colPartCode));
						if(PartCode==cbAccessory.Text.Trim())
						{

							break;
						}	
					}

					dtCurrent.Merge(dtnew);
					grdLinhKienLapRap.DataSource = dtCurrent;
				}
				else
				{
					grdLinhKienLapRap.DataSource = dtnew;
				}

				List<int> lstColumn = new List<int>();
				for (int i = 0; i < grvLinhKienLapRap.Columns.Count; i++)
				{
					string real = "";
					if (i == 0)
					{
						real = "";
					}
					else
					{
						real = $"{i}";
					}
					string value = TextUtils.ToString(grvLinhKienLapRap.GetRowCellValue(grvLinhKienLapRap.RowCount - 1, "RealValue" + real));
					if (value == "")
					{
						lstColumn.Add(i);
					}
					else
					{
						if (lstColumn.Count > 0)
						{
							if (lstColumn[0] == 0)
							{
								grvLinhKienLapRap.SetRowCellValue(grvLinhKienLapRap.RowCount - 1, "RealValue", value);
							}
							else
							{
								grvLinhKienLapRap.SetRowCellValue(grvLinhKienLapRap.RowCount - 1, "RealValue" + lstColumn[0], value);
							}
							grvLinhKienLapRap.SetRowCellValue(grvLinhKienLapRap.RowCount - 1, "RealValue" + real, "");
							lstColumn.RemoveAt(0);
							lstColumn.Add(i);
						}
					}
				}

				//Add 3 giá trị vào gridview (Mã linh kiện, QRCode, Order)
				grvLinhKienLapRap.SetRowCellValue(grvLinhKienLapRap.RowCount - 1, colPartCode, cbAccessory.Text.Trim());//ds linh kiện
				grvLinhKienLapRap.SetRowCellValue(grvLinhKienLapRap.RowCount - 1, colQRCode, txtQRCode.Text.Trim());//QRCode
				grvLinhKienLapRap.SetRowCellValue(grvLinhKienLapRap.RowCount - 1, colOrder, txtOrderCode.Text.Trim());//OrderCode
				for (int i = 4; i < grvLinhKienLapRap.Columns.Count-4; i++)
				{
					grvLinhKienLapRap.VisibleColumns[i].Caption = stepCodeSplit[0];
				}
				CboStep = cbStepCode.SelectedIndex;
			}
			catch
			{
			}
		}
	}
}
