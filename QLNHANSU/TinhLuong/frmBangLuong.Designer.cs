
namespace QLNHANSU.TinhLuong
{
    partial class frmBangLuong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangLuong));
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAKYCONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYCONGTRONGTHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYPHEP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYCHUNHAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYTHUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TANGCA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PHUCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UNGLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THUCLANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTinhLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnXemBangLuong = new DevExpress.XtraEditors.SimpleButton();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvDanhSach.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gvDanhSach.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDanhSach.Appearance.EvenRow.Options.UseFont = true;
            this.gvDanhSach.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvDanhSach.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gvDanhSach.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDanhSach.Appearance.OddRow.Options.UseFont = true;
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.MAKYCONG,
            this.HOTEN,
            this.NGAYCONGTRONGTHANG,
            this.IDNV,
            this.NGAYPHEP,
            this.NGAYCHUNHAT,
            this.NGAYTHUONG,
            this.TANGCA,
            this.PHUCAP,
            this.UNGLUONG,
            this.THUCLANH});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsFind.AlwaysVisible = true;
            this.gvDanhSach.OptionsFind.FindNullPrompt = "Nhập từ khoá tìm kiếm...";
            this.gvDanhSach.OptionsFind.SearchInPreview = true;
            this.gvDanhSach.OptionsFind.ShowFindButton = false;
            this.gvDanhSach.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvDanhSach.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDanhSach.OptionsView.EnableAppearanceOddRow = true;
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ID.AppearanceHeader.Options.UseFont = true;
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MaxWidth = 50;
            this.ID.MinWidth = 50;
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // MAKYCONG
            // 
            this.MAKYCONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.MAKYCONG.AppearanceHeader.Options.UseFont = true;
            this.MAKYCONG.Caption = "KỲ CÔNG";
            this.MAKYCONG.FieldName = "MAKYCONG";
            this.MAKYCONG.MaxWidth = 100;
            this.MAKYCONG.MinWidth = 100;
            this.MAKYCONG.Name = "MAKYCONG";
            this.MAKYCONG.Visible = true;
            this.MAKYCONG.VisibleIndex = 0;
            this.MAKYCONG.Width = 100;
            // 
            // HOTEN
            // 
            this.HOTEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.HOTEN.AppearanceHeader.Options.UseFont = true;
            this.HOTEN.Caption = "HỌ TÊN";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 170;
            this.HOTEN.MinWidth = 170;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            this.HOTEN.Width = 170;
            // 
            // NGAYCONGTRONGTHANG
            // 
            this.NGAYCONGTRONGTHANG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.NGAYCONGTRONGTHANG.AppearanceHeader.Options.UseFont = true;
            this.NGAYCONGTRONGTHANG.Caption = "NGÀY CÔNG";
            this.NGAYCONGTRONGTHANG.FieldName = "NGAYCONGTRONGTHANG";
            this.NGAYCONGTRONGTHANG.MaxWidth = 100;
            this.NGAYCONGTRONGTHANG.MinWidth = 130;
            this.NGAYCONGTRONGTHANG.Name = "NGAYCONGTRONGTHANG";
            this.NGAYCONGTRONGTHANG.Visible = true;
            this.NGAYCONGTRONGTHANG.VisibleIndex = 2;
            this.NGAYCONGTRONGTHANG.Width = 130;
            // 
            // IDNV
            // 
            this.IDNV.Caption = "MANV";
            this.IDNV.FieldName = "MANV";
            this.IDNV.Name = "IDNV";
            // 
            // NGAYPHEP
            // 
            this.NGAYPHEP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.NGAYPHEP.AppearanceHeader.Options.UseFont = true;
            this.NGAYPHEP.Caption = "NGÀY PHÉP";
            this.NGAYPHEP.DisplayFormat.FormatString = "n0";
            this.NGAYPHEP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NGAYPHEP.FieldName = "NGAYPHEP";
            this.NGAYPHEP.MaxWidth = 100;
            this.NGAYPHEP.MinWidth = 120;
            this.NGAYPHEP.Name = "NGAYPHEP";
            this.NGAYPHEP.Visible = true;
            this.NGAYPHEP.VisibleIndex = 3;
            this.NGAYPHEP.Width = 120;
            // 
            // NGAYCHUNHAT
            // 
            this.NGAYCHUNHAT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.NGAYCHUNHAT.AppearanceHeader.Options.UseFont = true;
            this.NGAYCHUNHAT.Caption = "CHỦ NHẬT";
            this.NGAYCHUNHAT.DisplayFormat.FormatString = "n0";
            this.NGAYCHUNHAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NGAYCHUNHAT.FieldName = "NGAYCHUNHAT";
            this.NGAYCHUNHAT.MaxWidth = 100;
            this.NGAYCHUNHAT.MinWidth = 120;
            this.NGAYCHUNHAT.Name = "NGAYCHUNHAT";
            this.NGAYCHUNHAT.Visible = true;
            this.NGAYCHUNHAT.VisibleIndex = 4;
            this.NGAYCHUNHAT.Width = 120;
            // 
            // NGAYTHUONG
            // 
            this.NGAYTHUONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.NGAYTHUONG.AppearanceHeader.Options.UseFont = true;
            this.NGAYTHUONG.Caption = "NGÀY THƯỜNG";
            this.NGAYTHUONG.DisplayFormat.FormatString = "n0";
            this.NGAYTHUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NGAYTHUONG.FieldName = "NGAYTHUONG";
            this.NGAYTHUONG.MaxWidth = 100;
            this.NGAYTHUONG.MinWidth = 150;
            this.NGAYTHUONG.Name = "NGAYTHUONG";
            this.NGAYTHUONG.Visible = true;
            this.NGAYTHUONG.VisibleIndex = 5;
            this.NGAYTHUONG.Width = 150;
            // 
            // TANGCA
            // 
            this.TANGCA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.TANGCA.AppearanceHeader.Options.UseFont = true;
            this.TANGCA.Caption = "TĂNG CA";
            this.TANGCA.DisplayFormat.FormatString = "n0";
            this.TANGCA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TANGCA.FieldName = "TANGCA";
            this.TANGCA.Name = "TANGCA";
            this.TANGCA.Visible = true;
            this.TANGCA.VisibleIndex = 6;
            this.TANGCA.Width = 115;
            // 
            // PHUCAP
            // 
            this.PHUCAP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.PHUCAP.AppearanceHeader.Options.UseFont = true;
            this.PHUCAP.Caption = "PHỤ CẤP";
            this.PHUCAP.DisplayFormat.FormatString = "n0";
            this.PHUCAP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PHUCAP.FieldName = "PHUCAP";
            this.PHUCAP.Name = "PHUCAP";
            this.PHUCAP.Visible = true;
            this.PHUCAP.VisibleIndex = 7;
            this.PHUCAP.Width = 115;
            // 
            // UNGLUONG
            // 
            this.UNGLUONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.UNGLUONG.AppearanceHeader.Options.UseFont = true;
            this.UNGLUONG.Caption = "ỨNG LƯƠNG";
            this.UNGLUONG.DisplayFormat.FormatString = "n0";
            this.UNGLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UNGLUONG.FieldName = "UNGLUONG";
            this.UNGLUONG.Name = "UNGLUONG";
            this.UNGLUONG.Visible = true;
            this.UNGLUONG.VisibleIndex = 8;
            this.UNGLUONG.Width = 165;
            // 
            // THUCLANH
            // 
            this.THUCLANH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.THUCLANH.AppearanceHeader.Options.UseFont = true;
            this.THUCLANH.Caption = "THỰC LÃNH";
            this.THUCLANH.DisplayFormat.FormatString = "n0";
            this.THUCLANH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.THUCLANH.FieldName = "THUCLANH";
            this.THUCLANH.Name = "THUCLANH";
            this.THUCLANH.Visible = true;
            this.THUCLANH.VisibleIndex = 9;
            this.THUCLANH.Width = 303;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1458, 274);
            this.gcDanhSach.TabIndex = 1;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTinhLuong,
            this.barCheckItem1,
            this.btnIn,
            this.btnDong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTinhLuong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Caption = "Tính lương";
            this.btnTinhLuong.Id = 0;
            this.btnTinhLuong.ImageOptions.Image = global::QLNHANSU.Properties.Resources.icon_tính_lương;
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTinhLuong_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 6;
            this.btnIn.ImageOptions.Image = global::QLNHANSU.Properties.Resources.icon_in;
            this.btnIn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.LargeImage")));
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 7;
            this.btnDong.ImageOptions.Image = global::QLNHANSU.Properties.Resources.icon_thoát;
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1458, 27);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 469);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1458, 19);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 27);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 442);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1458, 27);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 442);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 4;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 27);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnXemBangLuong);
            this.splitContainer2.Panel1.Controls.Add(this.cboThang);
            this.splitContainer2.Panel1.Controls.Add(this.cboNam);
            this.splitContainer2.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer2.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer2.Size = new System.Drawing.Size(1458, 442);
            this.splitContainer2.SplitterDistance = 164;
            this.splitContainer2.TabIndex = 34;
            // 
            // btnXemBangLuong
            // 
            this.btnXemBangLuong.Appearance.BackColor = System.Drawing.Color.DarkBlue;
            this.btnXemBangLuong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnXemBangLuong.Appearance.Options.UseBackColor = true;
            this.btnXemBangLuong.Appearance.Options.UseFont = true;
            this.btnXemBangLuong.ImageOptions.Image = global::QLNHANSU.Properties.Resources.icon_xem_bảng_lương;
            this.btnXemBangLuong.Location = new System.Drawing.Point(640, 42);
            this.btnXemBangLuong.Name = "btnXemBangLuong";
            this.btnXemBangLuong.Size = new System.Drawing.Size(187, 50);
            this.btnXemBangLuong.TabIndex = 11;
            this.btnXemBangLuong.Text = "Xem bảng lương";
            this.btnXemBangLuong.Click += new System.EventHandler(this.btnXemBangLuong_Click);
            // 
            // cboThang
            // 
            this.cboThang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(418, 56);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(176, 27);
            this.cboThang.TabIndex = 10;
            // 
            // cboNam
            // 
            this.cboNam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cboNam.Location = new System.Drawing.Point(147, 55);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(176, 27);
            this.cboNam.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(350, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 19);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Tháng :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(93, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 19);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Năm :";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xoá";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1458, 27);
            this.barDockControl4.Manager = null;
            this.barDockControl4.Size = new System.Drawing.Size(0, 442);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Lưu";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Huỷ";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Đóng";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem7.ImageOptions.SvgImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "In";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // frmBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 488);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBangLuong";
            this.Text = "Bảng Lương";
            this.Load += new System.EventHandler(this.frmBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn MAKYCONG;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYCONGTRONGTHANG;
        private DevExpress.XtraGrid.Columns.GridColumn IDNV;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTinhLuong;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;
        private DevExpress.XtraEditors.SimpleButton btnXemBangLuong;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYPHEP;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYCHUNHAT;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYTHUONG;
        private DevExpress.XtraGrid.Columns.GridColumn TANGCA;
        private DevExpress.XtraGrid.Columns.GridColumn PHUCAP;
        private DevExpress.XtraGrid.Columns.GridColumn UNGLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn THUCLANH;
    }
}