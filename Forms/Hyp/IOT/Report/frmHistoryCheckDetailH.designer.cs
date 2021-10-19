﻿namespace BMS
{
    partial class frmHistoryCheckDetailH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoryCheckDetailH));
			this.grdData = new DevExpress.XtraGrid.GridControl();
			this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colPID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
			this.colGroup = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPath = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colInFilm = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.colUpdatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOrderTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTem = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTK = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRealValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colValueTypeText = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRealValue1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnExportExecl = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
			this.SuspendLayout();
			// 
			// grdData
			// 
			this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdData.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grdData.Location = new System.Drawing.Point(2, 2);
			this.grdData.MainView = this.grvData;
			this.grdData.Name = "grdData";
			this.grdData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemMemoEdit1,
            this.repositoryItemCheckEdit2});
			this.grdData.Size = new System.Drawing.Size(1020, 531);
			this.grdData.TabIndex = 4;
			this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
			// 
			// grvData
			// 
			this.grvData.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.FocusedRow.Options.UseBackColor = true;
			this.grvData.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.grvData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.grvData.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.HideSelectionRow.Options.UseBackColor = true;
			this.grvData.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.SelectedRow.Options.UseBackColor = true;
			this.grvData.ColumnPanelRowHeight = 40;
			this.grvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPID,
            this.colSTT,
            this.colCreatedDate,
            this.colGroup,
            this.colID,
            this.colDes,
            this.colPath,
            this.colNote,
            this.colS,
            this.colInFilm,
            this.colUpdatedDate,
            this.colPrice,
            this.colOrderTime,
            this.colTem,
            this.colTK,
            this.colRealValue});
			this.grvData.GridControl = this.grdData;
			this.grvData.GroupCount = 1;
			this.grvData.HorzScrollStep = 5;
			this.grvData.Name = "grvData";
			this.grvData.OptionsBehavior.AutoExpandAllGroups = true;
			this.grvData.OptionsCustomization.AllowRowSizing = true;
			this.grvData.OptionsFind.AlwaysVisible = true;
			this.grvData.OptionsFind.ShowCloseButton = false;
			this.grvData.OptionsSelection.MultiSelect = true;
			this.grvData.OptionsView.ColumnAutoWidth = false;
			this.grvData.OptionsView.RowAutoHeight = true;
			this.grvData.OptionsView.ShowGroupPanel = false;
			this.grvData.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGroup, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// colPID
			// 
			this.colPID.AppearanceCell.Options.UseTextOptions = true;
			this.colPID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colPID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colPID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colPID.AppearanceHeader.Options.UseBackColor = true;
			this.colPID.AppearanceHeader.Options.UseFont = true;
			this.colPID.AppearanceHeader.Options.UseTextOptions = true;
			this.colPID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colPID.Caption = "Giá trị tiêu chuẩn";
			this.colPID.FieldName = "StandardValue";
			this.colPID.Name = "colPID";
			this.colPID.OptionsColumn.AllowEdit = false;
			this.colPID.OptionsColumn.AllowSize = false;
			this.colPID.Visible = true;
			this.colPID.VisibleIndex = 3;
			this.colPID.Width = 124;
			// 
			// colSTT
			// 
			this.colSTT.AppearanceCell.Options.UseTextOptions = true;
			this.colSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSTT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSTT.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colSTT.AppearanceHeader.Options.UseBackColor = true;
			this.colSTT.AppearanceHeader.Options.UseFont = true;
			this.colSTT.AppearanceHeader.Options.UseTextOptions = true;
			this.colSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSTT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colSTT.Caption = "STT";
			this.colSTT.FieldName = "RowNum";
			this.colSTT.Name = "colSTT";
			this.colSTT.OptionsColumn.AllowEdit = false;
			this.colSTT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
			this.colSTT.Visible = true;
			this.colSTT.VisibleIndex = 0;
			this.colSTT.Width = 82;
			// 
			// colCreatedDate
			// 
			this.colCreatedDate.AppearanceCell.Options.UseTextOptions = true;
			this.colCreatedDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colCreatedDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colCreatedDate.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colCreatedDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colCreatedDate.AppearanceHeader.Options.UseBackColor = true;
			this.colCreatedDate.AppearanceHeader.Options.UseFont = true;
			this.colCreatedDate.AppearanceHeader.Options.UseTextOptions = true;
			this.colCreatedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colCreatedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colCreatedDate.Caption = "Ghi chép";
			this.colCreatedDate.ColumnEdit = this.repositoryItemMemoEdit1;
			this.colCreatedDate.FieldName = "ValueTypeText";
			this.colCreatedDate.Name = "colCreatedDate";
			this.colCreatedDate.OptionsColumn.AllowEdit = false;
			this.colCreatedDate.Visible = true;
			this.colCreatedDate.VisibleIndex = 2;
			this.colCreatedDate.Width = 124;
			// 
			// repositoryItemMemoEdit1
			// 
			this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
			this.repositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
			// 
			// colGroup
			// 
			this.colGroup.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colGroup.AppearanceCell.Options.UseFont = true;
			this.colGroup.AppearanceCell.Options.UseTextOptions = true;
			this.colGroup.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colGroup.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colGroup.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colGroup.AppearanceHeader.Options.UseBackColor = true;
			this.colGroup.AppearanceHeader.Options.UseFont = true;
			this.colGroup.AppearanceHeader.Options.UseTextOptions = true;
			this.colGroup.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGroup.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colGroup.Caption = "Công đoạn";
			this.colGroup.FieldName = "ProductStepInfo";
			this.colGroup.Name = "colGroup";
			this.colGroup.OptionsColumn.AllowEdit = false;
			// 
			// colID
			// 
			this.colID.AppearanceCell.Options.UseTextOptions = true;
			this.colID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colID.AppearanceHeader.Options.UseBackColor = true;
			this.colID.AppearanceHeader.Options.UseTextOptions = true;
			this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			// 
			// colDes
			// 
			this.colDes.AppearanceCell.Options.UseTextOptions = true;
			this.colDes.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDes.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colDes.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colDes.AppearanceHeader.Options.UseBackColor = true;
			this.colDes.AppearanceHeader.Options.UseFont = true;
			this.colDes.AppearanceHeader.Options.UseTextOptions = true;
			this.colDes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDes.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDes.Caption = "Mô tả";
			this.colDes.FieldName = "Description";
			this.colDes.Name = "colDes";
			this.colDes.OptionsColumn.AllowEdit = false;
			this.colDes.Width = 141;
			// 
			// colPath
			// 
			this.colPath.AppearanceCell.Options.UseTextOptions = true;
			this.colPath.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPath.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colPath.AppearanceHeader.Options.UseBackColor = true;
			this.colPath.AppearanceHeader.Options.UseTextOptions = true;
			this.colPath.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPath.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colPath.Caption = "Đường dẫn";
			this.colPath.FieldName = "Path";
			this.colPath.Name = "colPath";
			this.colPath.OptionsColumn.AllowEdit = false;
			this.colPath.Width = 104;
			// 
			// colNote
			// 
			this.colNote.AppearanceCell.Options.UseTextOptions = true;
			this.colNote.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colNote.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colNote.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colNote.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colNote.AppearanceHeader.Options.UseBackColor = true;
			this.colNote.AppearanceHeader.Options.UseFont = true;
			this.colNote.AppearanceHeader.Options.UseTextOptions = true;
			this.colNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colNote.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colNote.Caption = "Mục kiểm tra";
			this.colNote.ColumnEdit = this.repositoryItemMemoEdit1;
			this.colNote.FieldName = "ProductWorkingName";
			this.colNote.Name = "colNote";
			this.colNote.OptionsColumn.AllowEdit = false;
			this.colNote.OptionsColumn.AllowSize = false;
			this.colNote.Visible = true;
			this.colNote.VisibleIndex = 1;
			this.colNote.Width = 495;
			// 
			// colS
			// 
			this.colS.AppearanceCell.Options.UseTextOptions = true;
			this.colS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colS.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colS.AppearanceHeader.Options.UseBackColor = true;
			this.colS.AppearanceHeader.Options.UseTextOptions = true;
			this.colS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colS.Caption = "Trạng thái";
			this.colS.FieldName = "Status";
			this.colS.Name = "colS";
			this.colS.OptionsColumn.AllowEdit = false;
			// 
			// colInFilm
			// 
			this.colInFilm.AppearanceCell.Options.UseTextOptions = true;
			this.colInFilm.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colInFilm.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colInFilm.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colInFilm.AppearanceHeader.Options.UseBackColor = true;
			this.colInFilm.AppearanceHeader.Options.UseFont = true;
			this.colInFilm.AppearanceHeader.Options.UseTextOptions = true;
			this.colInFilm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colInFilm.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colInFilm.Caption = "Film in";
			this.colInFilm.ColumnEdit = this.repositoryItemCheckEdit1;
			this.colInFilm.FieldName = "HasFilm";
			this.colInFilm.Name = "colInFilm";
			this.colInFilm.OptionsColumn.AllowEdit = false;
			this.colInFilm.OptionsColumn.AllowSize = false;
			this.colInFilm.Width = 31;
			// 
			// repositoryItemCheckEdit1
			// 
			this.repositoryItemCheckEdit1.AutoHeight = false;
			this.repositoryItemCheckEdit1.Caption = "Check";
			this.repositoryItemCheckEdit1.DisplayValueChecked = "\"1\"";
			this.repositoryItemCheckEdit1.DisplayValueUnchecked = "\"0\"";
			this.repositoryItemCheckEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
			this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
			this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
			// 
			// colUpdatedDate
			// 
			this.colUpdatedDate.AppearanceCell.Options.UseTextOptions = true;
			this.colUpdatedDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colUpdatedDate.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colUpdatedDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colUpdatedDate.AppearanceHeader.Options.UseBackColor = true;
			this.colUpdatedDate.AppearanceHeader.Options.UseFont = true;
			this.colUpdatedDate.AppearanceHeader.Options.UseTextOptions = true;
			this.colUpdatedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colUpdatedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colUpdatedDate.Caption = "Ngày sửa";
			this.colUpdatedDate.FieldName = "UpdatedDate";
			this.colUpdatedDate.Name = "colUpdatedDate";
			this.colUpdatedDate.OptionsColumn.AllowEdit = false;
			// 
			// colPrice
			// 
			this.colPrice.AppearanceCell.Options.UseTextOptions = true;
			this.colPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPrice.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colPrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colPrice.AppearanceHeader.Options.UseBackColor = true;
			this.colPrice.AppearanceHeader.Options.UseFont = true;
			this.colPrice.AppearanceHeader.Options.UseTextOptions = true;
			this.colPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colPrice.Caption = "Giá(VND)";
			this.colPrice.DisplayFormat.FormatString = "n2";
			this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colPrice.FieldName = "Price";
			this.colPrice.Name = "colPrice";
			this.colPrice.OptionsColumn.AllowEdit = false;
			// 
			// colOrderTime
			// 
			this.colOrderTime.AppearanceCell.Options.UseTextOptions = true;
			this.colOrderTime.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colOrderTime.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colOrderTime.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colOrderTime.AppearanceHeader.Options.UseBackColor = true;
			this.colOrderTime.AppearanceHeader.Options.UseFont = true;
			this.colOrderTime.AppearanceHeader.Options.UseTextOptions = true;
			this.colOrderTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colOrderTime.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colOrderTime.Caption = "Thời gian đặt hàng(ngày)";
			this.colOrderTime.DisplayFormat.FormatString = "n2";
			this.colOrderTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colOrderTime.FieldName = "OrderTime";
			this.colOrderTime.Name = "colOrderTime";
			this.colOrderTime.OptionsColumn.AllowEdit = false;
			// 
			// colTem
			// 
			this.colTem.AppearanceCell.Options.UseTextOptions = true;
			this.colTem.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colTem.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colTem.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colTem.AppearanceHeader.Options.UseBackColor = true;
			this.colTem.AppearanceHeader.Options.UseFont = true;
			this.colTem.AppearanceHeader.Options.UseTextOptions = true;
			this.colTem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colTem.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colTem.Caption = "Tem";
			this.colTem.ColumnEdit = this.repositoryItemCheckEdit1;
			this.colTem.FieldName = "HasTem";
			this.colTem.Name = "colTem";
			this.colTem.OptionsColumn.AllowEdit = false;
			this.colTem.OptionsColumn.AllowSize = false;
			this.colTem.Width = 38;
			// 
			// colTK
			// 
			this.colTK.AppearanceCell.Options.UseTextOptions = true;
			this.colTK.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colTK.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colTK.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colTK.AppearanceHeader.Options.UseBackColor = true;
			this.colTK.AppearanceHeader.Options.UseFont = true;
			this.colTK.AppearanceHeader.Options.UseTextOptions = true;
			this.colTK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colTK.Caption = "TK";
			this.colTK.ColumnEdit = this.repositoryItemCheckEdit1;
			this.colTK.FieldName = "HasTK";
			this.colTK.Name = "colTK";
			this.colTK.OptionsColumn.AllowEdit = false;
			this.colTK.OptionsColumn.AllowSize = false;
			this.colTK.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
			this.colTK.Width = 35;
			// 
			// colRealValue
			// 
			this.colRealValue.AppearanceCell.Options.UseTextOptions = true;
			this.colRealValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colRealValue.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colRealValue.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colRealValue.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colRealValue.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colRealValue.AppearanceHeader.Options.UseBackColor = true;
			this.colRealValue.AppearanceHeader.Options.UseFont = true;
			this.colRealValue.AppearanceHeader.Options.UseTextOptions = true;
			this.colRealValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colRealValue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colRealValue.Caption = "Giá trị thực tế";
			this.colRealValue.FieldName = "RealValue";
			this.colRealValue.Name = "colRealValue";
			this.colRealValue.OptionsColumn.AllowEdit = false;
			this.colRealValue.Visible = true;
			this.colRealValue.VisibleIndex = 4;
			this.colRealValue.Width = 124;
			// 
			// repositoryItemCheckEdit2
			// 
			this.repositoryItemCheckEdit2.AutoHeight = false;
			this.repositoryItemCheckEdit2.Caption = "Check";
			this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
			this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
			// 
			// gridColumn1
			// 
			this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.gridColumn1.AppearanceHeader.Options.UseFont = true;
			this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
			this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.gridColumn1.Caption = "Giá trị tiêu chuẩn";
			this.gridColumn1.FieldName = "StandardValue";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.OptionsColumn.AllowEdit = false;
			this.gridColumn1.OptionsColumn.AllowFocus = false;
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 1;
			this.gridColumn1.Width = 100;
			// 
			// colValueTypeText
			// 
			this.colValueTypeText.AppearanceCell.Options.UseTextOptions = true;
			this.colValueTypeText.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colValueTypeText.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colValueTypeText.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colValueTypeText.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colValueTypeText.AppearanceHeader.Options.UseFont = true;
			this.colValueTypeText.Caption = "Ghi chép";
			this.colValueTypeText.FieldName = "ValueTypeText";
			this.colValueTypeText.Name = "colValueTypeText";
			this.colValueTypeText.OptionsColumn.AllowEdit = false;
			this.colValueTypeText.OptionsColumn.AllowFocus = false;
			this.colValueTypeText.Visible = true;
			this.colValueTypeText.VisibleIndex = 2;
			this.colValueTypeText.Width = 70;
			// 
			// colRealValue1
			// 
			this.colRealValue1.AppearanceCell.Options.UseTextOptions = true;
			this.colRealValue1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colRealValue1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colRealValue1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colRealValue1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.colRealValue1.AppearanceHeader.Options.UseFont = true;
			this.colRealValue1.AppearanceHeader.Options.UseTextOptions = true;
			this.colRealValue1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colRealValue1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colRealValue1.Caption = "#";
			this.colRealValue1.FieldName = "RealValue1";
			this.colRealValue1.Name = "colRealValue1";
			this.colRealValue1.Visible = true;
			this.colRealValue1.VisibleIndex = 3;
			this.colRealValue1.Width = 85;
			// 
			// btnExportExecl
			// 
			this.btnExportExecl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportExecl.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.btnExportExecl.Appearance.Options.UseFont = true;
			this.btnExportExecl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExecl.ImageOptions.Image")));
			this.btnExportExecl.Location = new System.Drawing.Point(900, 12);
			this.btnExportExecl.Name = "btnExportExecl";
			this.btnExportExecl.Size = new System.Drawing.Size(89, 32);
			this.btnExportExecl.TabIndex = 28;
			this.btnExportExecl.Text = "Xuất excel";
			this.btnExportExecl.Click += new System.EventHandler(this.btnExportExecl_Click);
			// 
			// frmHistoryCheckDetailH
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 536);
			this.Controls.Add(this.btnExportExecl);
			this.Controls.Add(this.grdData);
			this.Name = "frmHistoryCheckDetailH";
			this.Text = "CHI TIẾT KIỂM TRA";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmHistoryCheckDetail_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl grdData;
        private DevExpress.XtraGrid.Views.Grid.GridView grvData;
        private DevExpress.XtraGrid.Columns.GridColumn colPID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDes;
        private DevExpress.XtraGrid.Columns.GridColumn colPath;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colS;
        private DevExpress.XtraGrid.Columns.GridColumn colInFilm;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderTime;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTem;
        private DevExpress.XtraGrid.Columns.GridColumn colTK;
        private DevExpress.XtraGrid.Columns.GridColumn colRealValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colValueTypeText;
        private DevExpress.XtraGrid.Columns.GridColumn colRealValue1;
        private DevExpress.XtraEditors.SimpleButton btnExportExecl;
	}
}