
namespace BMS
{
	partial class frmAddEditPlan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditPlan));
			this.mnuMenu = new System.Windows.Forms.ToolStrip();
			this.btnSaveClose = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSaveNew = new System.Windows.Forms.ToolStripButton();
			this.txbQtyPlan = new System.Windows.Forms.NumericUpDown();
			this.txbLotSize = new System.Windows.Forms.NumericUpDown();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.txbPartCode = new System.Windows.Forms.TextBox();
			this.txbOrderCode = new System.Windows.Forms.TextBox();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.txbNote = new System.Windows.Forms.TextBox();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.dtpProdDate = new System.Windows.Forms.DateTimePicker();
			this.dtpDateExported = new System.Windows.Forms.DateTimePicker();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txbRealProdQty = new System.Windows.Forms.NumericUpDown();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.txbNG = new System.Windows.Forms.NumericUpDown();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.txbSaleCode = new System.Windows.Forms.TextBox();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.txbOP = new System.Windows.Forms.NumericUpDown();
			this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.txbShipTo = new System.Windows.Forms.TextBox();
			this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.txbShipVia = new System.Windows.Forms.TextBox();
			this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
			this.dtpPrintedDate = new System.Windows.Forms.DateTimePicker();
			this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
			this.txbConfirmCode = new System.Windows.Forms.TextBox();
			this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
			this.txbWorkerCode = new System.Windows.Forms.TextBox();
			this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.catVaThemOiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtCNT = new System.Windows.Forms.NumericUpDown();
			this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
			this.mnuMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txbQtyPlan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txbLotSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txbRealProdQty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txbNG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txbOP)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtCNT)).BeginInit();
			this.SuspendLayout();
			// 
			// mnuMenu
			// 
			this.mnuMenu.AutoSize = false;
			this.mnuMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.mnuMenu.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveClose,
            this.toolStripSeparator2,
            this.btnSaveNew});
			this.mnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.mnuMenu.Location = new System.Drawing.Point(0, 0);
			this.mnuMenu.Name = "mnuMenu";
			this.mnuMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnuMenu.Size = new System.Drawing.Size(1135, 46);
			this.mnuMenu.TabIndex = 2;
			this.mnuMenu.Text = "toolStrip2";
			// 
			// btnSaveClose
			// 
			this.btnSaveClose.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveClose.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveClose.Image")));
			this.btnSaveClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSaveClose.Name = "btnSaveClose";
			this.btnSaveClose.Size = new System.Drawing.Size(96, 42);
			this.btnSaveClose.Tag = "frmProduct_AddProductH";
			this.btnSaveClose.Text = "Cất && Đóng";
			this.btnSaveClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.AutoSize = false;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
			// 
			// btnSaveNew
			// 
			this.btnSaveNew.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveNew.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveNew.Image")));
			this.btnSaveNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSaveNew.Name = "btnSaveNew";
			this.btnSaveNew.Size = new System.Drawing.Size(128, 42);
			this.btnSaveNew.Tag = "frmProduct_AddProductH";
			this.btnSaveNew.Text = "Cất && Thêm mới";
			this.btnSaveNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
			// 
			// txbQtyPlan
			// 
			this.txbQtyPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txbQtyPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbQtyPlan.Location = new System.Drawing.Point(295, 89);
			this.txbQtyPlan.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.txbQtyPlan.Name = "txbQtyPlan";
			this.txbQtyPlan.Size = new System.Drawing.Size(182, 35);
			this.txbQtyPlan.TabIndex = 199;
			// 
			// txbLotSize
			// 
			this.txbLotSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txbLotSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbLotSize.Location = new System.Drawing.Point(295, 48);
			this.txbLotSize.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.txbLotSize.Name = "txbLotSize";
			this.txbLotSize.Size = new System.Drawing.Size(182, 35);
			this.txbLotSize.TabIndex = 198;
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl7.Location = new System.Drawing.Point(19, 49);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(82, 29);
			this.labelControl7.TabIndex = 197;
			this.labelControl7.Text = "Lot size";
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl6.Location = new System.Drawing.Point(19, 92);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(101, 29);
			this.labelControl6.TabIndex = 196;
			this.labelControl6.Text = "Kế hoạch";
			// 
			// txbPartCode
			// 
			this.txbPartCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbPartCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbPartCode.Location = new System.Drawing.Point(256, 4);
			this.txbPartCode.Name = "txbPartCode";
			this.txbPartCode.Size = new System.Drawing.Size(362, 35);
			this.txbPartCode.TabIndex = 190;
			// 
			// txbOrderCode
			// 
			this.txbOrderCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbOrderCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbOrderCode.Location = new System.Drawing.Point(256, 43);
			this.txbOrderCode.Name = "txbOrderCode";
			this.txbOrderCode.Size = new System.Drawing.Size(362, 35);
			this.txbOrderCode.TabIndex = 191;
			// 
			// labelControl9
			// 
			this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl9.Location = new System.Drawing.Point(10, 47);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(97, 29);
			this.labelControl9.TabIndex = 195;
			this.labelControl9.Text = "Mã order";
			// 
			// txbNote
			// 
			this.txbNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbNote.Location = new System.Drawing.Point(256, 81);
			this.txbNote.Multiline = true;
			this.txbNote.Name = "txbNote";
			this.txbNote.Size = new System.Drawing.Size(362, 100);
			this.txbNote.TabIndex = 192;
			// 
			// labelControl4
			// 
			this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Location = new System.Drawing.Point(10, 93);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(65, 29);
			this.labelControl4.TabIndex = 194;
			this.labelControl4.Text = "Mô tả:";
			// 
			// labelControl3
			// 
			this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Location = new System.Drawing.Point(10, 9);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(128, 29);
			this.labelControl3.TabIndex = 193;
			this.labelControl3.Text = "Mã linh kiện";
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Location = new System.Drawing.Point(10, 186);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(225, 29);
			this.labelControl1.TabIndex = 200;
			this.labelControl1.Text = "Ngày sản xuất thực tế";
			// 
			// dtpProdDate
			// 
			this.dtpProdDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpProdDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.dtpProdDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpProdDate.Location = new System.Drawing.Point(256, 185);
			this.dtpProdDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dtpProdDate.Name = "dtpProdDate";
			this.dtpProdDate.Size = new System.Drawing.Size(362, 35);
			this.dtpProdDate.TabIndex = 202;
			// 
			// dtpDateExported
			// 
			this.dtpDateExported.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpDateExported.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.dtpDateExported.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDateExported.Location = new System.Drawing.Point(256, 222);
			this.dtpDateExported.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dtpDateExported.Name = "dtpDateExported";
			this.dtpDateExported.Size = new System.Drawing.Size(362, 35);
			this.dtpDateExported.TabIndex = 204;
			// 
			// labelControl2
			// 
			this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Location = new System.Drawing.Point(10, 224);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(162, 29);
			this.labelControl2.TabIndex = 203;
			this.labelControl2.Text = "Ngày xuất khẩu";
			// 
			// txbRealProdQty
			// 
			this.txbRealProdQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txbRealProdQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbRealProdQty.Location = new System.Drawing.Point(295, 130);
			this.txbRealProdQty.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.txbRealProdQty.Name = "txbRealProdQty";
			this.txbRealProdQty.Size = new System.Drawing.Size(182, 35);
			this.txbRealProdQty.TabIndex = 206;
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl5.Location = new System.Drawing.Point(19, 133);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(258, 29);
			this.labelControl5.TabIndex = 205;
			this.labelControl5.Text = "Số lượng sx thực tế (OK)";
			// 
			// txbNG
			// 
			this.txbNG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txbNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbNG.Location = new System.Drawing.Point(295, 173);
			this.txbNG.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.txbNG.Name = "txbNG";
			this.txbNG.Size = new System.Drawing.Size(182, 35);
			this.txbNG.TabIndex = 208;
			// 
			// labelControl8
			// 
			this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl8.Location = new System.Drawing.Point(19, 176);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(36, 29);
			this.labelControl8.TabIndex = 207;
			this.labelControl8.Text = "NG";
			// 
			// txbSaleCode
			// 
			this.txbSaleCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbSaleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbSaleCode.Location = new System.Drawing.Point(256, 261);
			this.txbSaleCode.Name = "txbSaleCode";
			this.txbSaleCode.Size = new System.Drawing.Size(362, 35);
			this.txbSaleCode.TabIndex = 209;
			// 
			// labelControl10
			// 
			this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl10.Location = new System.Drawing.Point(10, 263);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(113, 29);
			this.labelControl10.TabIndex = 210;
			this.labelControl10.Text = "Sale order";
			// 
			// txbOP
			// 
			this.txbOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txbOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbOP.Location = new System.Drawing.Point(295, 215);
			this.txbOP.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.txbOP.Name = "txbOP";
			this.txbOP.Size = new System.Drawing.Size(182, 35);
			this.txbOP.TabIndex = 212;
			// 
			// labelControl11
			// 
			this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl11.Location = new System.Drawing.Point(19, 219);
			this.labelControl11.Name = "labelControl11";
			this.labelControl11.Size = new System.Drawing.Size(35, 29);
			this.labelControl11.TabIndex = 211;
			this.labelControl11.Text = "OP";
			// 
			// txbShipTo
			// 
			this.txbShipTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txbShipTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbShipTo.Location = new System.Drawing.Point(296, 256);
			this.txbShipTo.Name = "txbShipTo";
			this.txbShipTo.Size = new System.Drawing.Size(183, 35);
			this.txbShipTo.TabIndex = 213;
			// 
			// labelControl12
			// 
			this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl12.Location = new System.Drawing.Point(20, 258);
			this.labelControl12.Name = "labelControl12";
			this.labelControl12.Size = new System.Drawing.Size(75, 29);
			this.labelControl12.TabIndex = 214;
			this.labelControl12.Text = "Ship to";
			// 
			// txbShipVia
			// 
			this.txbShipVia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txbShipVia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbShipVia.Location = new System.Drawing.Point(296, 299);
			this.txbShipVia.Name = "txbShipVia";
			this.txbShipVia.Size = new System.Drawing.Size(183, 35);
			this.txbShipVia.TabIndex = 215;
			// 
			// labelControl13
			// 
			this.labelControl13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl13.Location = new System.Drawing.Point(20, 300);
			this.labelControl13.Name = "labelControl13";
			this.labelControl13.Size = new System.Drawing.Size(85, 29);
			this.labelControl13.TabIndex = 216;
			this.labelControl13.Text = "Ship via";
			// 
			// dtpPrintedDate
			// 
			this.dtpPrintedDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpPrintedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.dtpPrintedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpPrintedDate.Location = new System.Drawing.Point(256, 299);
			this.dtpPrintedDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dtpPrintedDate.Name = "dtpPrintedDate";
			this.dtpPrintedDate.Size = new System.Drawing.Size(362, 35);
			this.dtpPrintedDate.TabIndex = 218;
			// 
			// labelControl14
			// 
			this.labelControl14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl14.Location = new System.Drawing.Point(10, 301);
			this.labelControl14.Name = "labelControl14";
			this.labelControl14.Size = new System.Drawing.Size(81, 29);
			this.labelControl14.TabIndex = 217;
			this.labelControl14.Text = "Ngày in";
			// 
			// txbConfirmCode
			// 
			this.txbConfirmCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txbConfirmCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbConfirmCode.Location = new System.Drawing.Point(296, 338);
			this.txbConfirmCode.Name = "txbConfirmCode";
			this.txbConfirmCode.Size = new System.Drawing.Size(183, 35);
			this.txbConfirmCode.TabIndex = 219;
			// 
			// labelControl15
			// 
			this.labelControl15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl15.Location = new System.Drawing.Point(20, 340);
			this.labelControl15.Name = "labelControl15";
			this.labelControl15.Size = new System.Drawing.Size(84, 29);
			this.labelControl15.TabIndex = 220;
			this.labelControl15.Text = "Confirm";
			// 
			// txbWorkerCode
			// 
			this.txbWorkerCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbWorkerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbWorkerCode.Location = new System.Drawing.Point(256, 338);
			this.txbWorkerCode.Name = "txbWorkerCode";
			this.txbWorkerCode.Size = new System.Drawing.Size(362, 35);
			this.txbWorkerCode.TabIndex = 221;
			// 
			// labelControl16
			// 
			this.labelControl16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl16.Location = new System.Drawing.Point(10, 340);
			this.labelControl16.Name = "labelControl16";
			this.labelControl16.Size = new System.Drawing.Size(90, 29);
			this.labelControl16.TabIndex = 222;
			this.labelControl16.Text = "Người in";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.panel1.Controls.Add(this.labelControl3);
			this.panel1.Controls.Add(this.txbWorkerCode);
			this.panel1.Controls.Add(this.labelControl16);
			this.panel1.Controls.Add(this.labelControl4);
			this.panel1.Controls.Add(this.txbNote);
			this.panel1.Controls.Add(this.labelControl9);
			this.panel1.Controls.Add(this.txbOrderCode);
			this.panel1.Controls.Add(this.dtpPrintedDate);
			this.panel1.Controls.Add(this.txbPartCode);
			this.panel1.Controls.Add(this.labelControl14);
			this.panel1.Controls.Add(this.labelControl1);
			this.panel1.Controls.Add(this.dtpProdDate);
			this.panel1.Controls.Add(this.labelControl2);
			this.panel1.Controls.Add(this.dtpDateExported);
			this.panel1.Controls.Add(this.labelControl10);
			this.panel1.Controls.Add(this.txbSaleCode);
			this.panel1.Location = new System.Drawing.Point(0, 42);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(642, 380);
			this.panel1.TabIndex = 223;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.panel2.Controls.Add(this.txtCNT);
			this.panel2.Controls.Add(this.labelControl17);
			this.panel2.Controls.Add(this.txbConfirmCode);
			this.panel2.Controls.Add(this.labelControl7);
			this.panel2.Controls.Add(this.labelControl15);
			this.panel2.Controls.Add(this.labelControl6);
			this.panel2.Controls.Add(this.txbShipVia);
			this.panel2.Controls.Add(this.txbLotSize);
			this.panel2.Controls.Add(this.labelControl13);
			this.panel2.Controls.Add(this.txbQtyPlan);
			this.panel2.Controls.Add(this.txbShipTo);
			this.panel2.Controls.Add(this.labelControl5);
			this.panel2.Controls.Add(this.labelControl12);
			this.panel2.Controls.Add(this.txbRealProdQty);
			this.panel2.Controls.Add(this.txbOP);
			this.panel2.Controls.Add(this.labelControl8);
			this.panel2.Controls.Add(this.labelControl11);
			this.panel2.Controls.Add(this.txbNG);
			this.panel2.Location = new System.Drawing.Point(646, 42);
			this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(488, 380);
			this.panel2.TabIndex = 224;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cấtToolStripMenuItem,
            this.catVaThemOiToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(430, 7);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(139, 24);
			this.menuStrip1.TabIndex = 225;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Visible = false;
			// 
			// cấtToolStripMenuItem
			// 
			this.cấtToolStripMenuItem.Name = "cấtToolStripMenuItem";
			this.cấtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cấtToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.cấtToolStripMenuItem.Text = "Cất";
			this.cấtToolStripMenuItem.Click += new System.EventHandler(this.cấtToolStripMenuItem_Click);
			// 
			// catVaThemOiToolStripMenuItem
			// 
			this.catVaThemOiToolStripMenuItem.Name = "catVaThemOiToolStripMenuItem";
			this.catVaThemOiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.catVaThemOiToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
			this.catVaThemOiToolStripMenuItem.Text = "Cat va them oi";
			this.catVaThemOiToolStripMenuItem.Click += new System.EventHandler(this.catVaThemOiToolStripMenuItem_Click);
			// 
			// txtCNT
			// 
			this.txtCNT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCNT.Location = new System.Drawing.Point(295, 4);
			this.txtCNT.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.txtCNT.Name = "txtCNT";
			this.txtCNT.Size = new System.Drawing.Size(182, 35);
			this.txtCNT.TabIndex = 222;
			// 
			// labelControl17
			// 
			this.labelControl17.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl17.Location = new System.Drawing.Point(20, 10);
			this.labelControl17.Name = "labelControl17";
			this.labelControl17.Size = new System.Drawing.Size(51, 29);
			this.labelControl17.TabIndex = 221;
			this.labelControl17.Text = "CNT";
			this.labelControl17.Click += new System.EventHandler(this.labelControl17_Click);
			// 
			// frmAddEditPlan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1135, 425);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.mnuMenu);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frmAddEditPlan";
			this.Text = "frmAddEditPlan";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditPlan_FormClosing);
			this.Load += new System.EventHandler(this.frmAddEditPlan_Load);
			this.mnuMenu.ResumeLayout(false);
			this.mnuMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txbQtyPlan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txbLotSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txbRealProdQty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txbNG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txbOP)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtCNT)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip mnuMenu;
		private System.Windows.Forms.ToolStripButton btnSaveClose;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnSaveNew;
		private System.Windows.Forms.NumericUpDown txbQtyPlan;
		private System.Windows.Forms.NumericUpDown txbLotSize;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private System.Windows.Forms.TextBox txbPartCode;
		private System.Windows.Forms.TextBox txbOrderCode;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private System.Windows.Forms.TextBox txbNote;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private System.Windows.Forms.DateTimePicker dtpProdDate;
		private System.Windows.Forms.DateTimePicker dtpDateExported;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private System.Windows.Forms.NumericUpDown txbRealProdQty;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private System.Windows.Forms.NumericUpDown txbNG;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private System.Windows.Forms.TextBox txbSaleCode;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private System.Windows.Forms.NumericUpDown txbOP;
		private DevExpress.XtraEditors.LabelControl labelControl11;
		private System.Windows.Forms.TextBox txbShipTo;
		private DevExpress.XtraEditors.LabelControl labelControl12;
		private System.Windows.Forms.TextBox txbShipVia;
		private DevExpress.XtraEditors.LabelControl labelControl13;
		private System.Windows.Forms.DateTimePicker dtpPrintedDate;
		private DevExpress.XtraEditors.LabelControl labelControl14;
		private System.Windows.Forms.TextBox txbConfirmCode;
		private DevExpress.XtraEditors.LabelControl labelControl15;
		private System.Windows.Forms.TextBox txbWorkerCode;
		private DevExpress.XtraEditors.LabelControl labelControl16;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cấtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem catVaThemOiToolStripMenuItem;
		private System.Windows.Forms.NumericUpDown txtCNT;
		private DevExpress.XtraEditors.LabelControl labelControl17;
	}
}