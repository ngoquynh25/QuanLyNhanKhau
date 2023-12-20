
namespace QuanLyNhanKhau.UI
{
    partial class UCPhuongXa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPhuongXa));
            this.ThongTinLienHe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienTich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DanSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenPhuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenQuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDPhuongXa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvPhuongXa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDQuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiTruSoHanhChinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPhuongXa = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.txtthongtinlienhe = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbQuan = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtdiachikhupho = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtdientich = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtdanso = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtphuong = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhuongXa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhuongXa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThongTinLienHe
            // 
            this.ThongTinLienHe.Caption = "Thông Tin Liên Hệ";
            this.ThongTinLienHe.FieldName = "ThongTinLienHe";
            this.ThongTinLienHe.MinWidth = 25;
            this.ThongTinLienHe.Name = "ThongTinLienHe";
            this.ThongTinLienHe.Visible = true;
            this.ThongTinLienHe.VisibleIndex = 6;
            this.ThongTinLienHe.Width = 227;
            // 
            // DienTich
            // 
            this.DienTich.Caption = "Diện Tích";
            this.DienTich.FieldName = "DienTich";
            this.DienTich.MinWidth = 25;
            this.DienTich.Name = "DienTich";
            this.DienTich.Visible = true;
            this.DienTich.VisibleIndex = 4;
            this.DienTich.Width = 217;
            // 
            // DanSo
            // 
            this.DanSo.Caption = "Dân Số";
            this.DanSo.FieldName = "DanSo";
            this.DanSo.MinWidth = 25;
            this.DanSo.Name = "DanSo";
            this.DanSo.Visible = true;
            this.DanSo.VisibleIndex = 3;
            this.DanSo.Width = 217;
            // 
            // TenPhuong
            // 
            this.TenPhuong.Caption = "Tên Phường";
            this.TenPhuong.FieldName = "TenPhuong";
            this.TenPhuong.MinWidth = 25;
            this.TenPhuong.Name = "TenPhuong";
            this.TenPhuong.Visible = true;
            this.TenPhuong.VisibleIndex = 2;
            this.TenPhuong.Width = 217;
            // 
            // TenQuan
            // 
            this.TenQuan.Caption = "Tên Quận";
            this.TenQuan.FieldName = "TenQuan";
            this.TenQuan.MinWidth = 25;
            this.TenQuan.Name = "TenQuan";
            this.TenQuan.Visible = true;
            this.TenQuan.VisibleIndex = 1;
            this.TenQuan.Width = 217;
            // 
            // IDPhuongXa
            // 
            this.IDPhuongXa.Caption = "ID Phường/Xã";
            this.IDPhuongXa.FieldName = "IDPhuongXa";
            this.IDPhuongXa.MinWidth = 25;
            this.IDPhuongXa.Name = "IDPhuongXa";
            this.IDPhuongXa.Visible = true;
            this.IDPhuongXa.VisibleIndex = 0;
            this.IDPhuongXa.Width = 40;
            // 
            // gvPhuongXa
            // 
            this.gvPhuongXa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDPhuongXa,
            this.IDQuan,
            this.TenQuan,
            this.TenPhuong,
            this.DanSo,
            this.DienTich,
            this.DiaChiTruSoHanhChinh,
            this.ThongTinLienHe});
            this.gvPhuongXa.GridControl = this.gcPhuongXa;
            this.gvPhuongXa.Name = "gvPhuongXa";
            // 
            // IDQuan
            // 
            this.IDQuan.Caption = "IDQuan";
            this.IDQuan.FieldName = "IDQuan";
            this.IDQuan.MinWidth = 25;
            this.IDQuan.Name = "IDQuan";
            this.IDQuan.Width = 94;
            // 
            // DiaChiTruSoHanhChinh
            // 
            this.DiaChiTruSoHanhChinh.Caption = "Địa Chỉ Trụ Sở Hành Chính";
            this.DiaChiTruSoHanhChinh.FieldName = "DiaChiTruSoHanhChinh";
            this.DiaChiTruSoHanhChinh.MinWidth = 25;
            this.DiaChiTruSoHanhChinh.Name = "DiaChiTruSoHanhChinh";
            this.DiaChiTruSoHanhChinh.Visible = true;
            this.DiaChiTruSoHanhChinh.VisibleIndex = 5;
            this.DiaChiTruSoHanhChinh.Width = 217;
            // 
            // gcPhuongXa
            // 
            this.gcPhuongXa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPhuongXa.Location = new System.Drawing.Point(0, 0);
            this.gcPhuongXa.MainView = this.gvPhuongXa;
            this.gcPhuongXa.MenuManager = this.barManager1;
            this.gcPhuongXa.Name = "gcPhuongXa";
            this.gcPhuongXa.Size = new System.Drawing.Size(1382, 556);
            this.gcPhuongXa.TabIndex = 5;
            this.gcPhuongXa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhuongXa});
            this.gcPhuongXa.Click += new System.EventHandler(this.gcPhuongXa_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnThoat,
            this.btnLuu,
            this.btnHuy,
            this.btnIn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.A));
            this.btnThem.Name = "btnThem";
            this.btnThem.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.E));
            this.btnSua.Name = "btnSua";
            this.btnSua.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.D));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 7;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.LargeImage")));
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 5;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 6;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.H));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1382, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 806);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1382, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 776);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1382, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 776);
            // 
            // btnThoat
            // 
            this.btnThoat.Id = 4;
            this.btnThoat.Name = "btnThoat";
            // 
            // txtthongtinlienhe
            // 
            this.txtthongtinlienhe.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthongtinlienhe.Location = new System.Drawing.Point(852, 129);
            this.txtthongtinlienhe.Name = "txtthongtinlienhe";
            this.txtthongtinlienhe.Size = new System.Drawing.Size(411, 28);
            this.txtthongtinlienhe.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbQuan);
            this.splitContainer1.Panel1.Controls.Add(this.txtthongtinlienhe);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.txtdiachikhupho);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.txtdientich);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.txtdanso);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.txtphuong);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcPhuongXa);
            this.splitContainer1.Size = new System.Drawing.Size(1382, 776);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 10;
            // 
            // cbQuan
            // 
            this.cbQuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuan.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbQuan.FormattingEnabled = true;
            this.cbQuan.Location = new System.Drawing.Point(225, 38);
            this.cbQuan.Name = "cbQuan";
            this.cbQuan.Size = new System.Drawing.Size(411, 29);
            this.cbQuan.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(682, 132);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(140, 21);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Thông Tin Liên Hệ:";
            // 
            // txtdiachikhupho
            // 
            this.txtdiachikhupho.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachikhupho.Location = new System.Drawing.Point(852, 85);
            this.txtdiachikhupho.Name = "txtdiachikhupho";
            this.txtdiachikhupho.Size = new System.Drawing.Size(411, 28);
            this.txtdiachikhupho.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(698, 88);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(124, 21);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Địa Chỉ Khu Phố:\r\n";
            // 
            // txtdientich
            // 
            this.txtdientich.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdientich.Location = new System.Drawing.Point(852, 39);
            this.txtdientich.Name = "txtdientich";
            this.txtdientich.Size = new System.Drawing.Size(411, 28);
            this.txtdientich.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(746, 42);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 21);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Diện Tích:";
            // 
            // txtdanso
            // 
            this.txtdanso.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdanso.Location = new System.Drawing.Point(225, 129);
            this.txtdanso.Name = "txtdanso";
            this.txtdanso.Size = new System.Drawing.Size(411, 28);
            this.txtdanso.TabIndex = 5;
            this.txtdanso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdanso_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(118, 132);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 21);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Dân Số:";
            // 
            // txtphuong
            // 
            this.txtphuong.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphuong.Location = new System.Drawing.Point(225, 85);
            this.txtphuong.Name = "txtphuong";
            this.txtphuong.Size = new System.Drawing.Size(411, 28);
            this.txtphuong.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(83, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên Phường:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(82, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Thuộc Quận:";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // UCPhuongXa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UCPhuongXa";
            this.Size = new System.Drawing.Size(1382, 806);
            this.Load += new System.EventHandler(this.UCPhuongXa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPhuongXa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhuongXa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn ThongTinLienHe;
        private DevExpress.XtraGrid.Columns.GridColumn DienTich;
        private DevExpress.XtraGrid.Columns.GridColumn DanSo;
        private DevExpress.XtraGrid.Columns.GridColumn TenPhuong;
        private DevExpress.XtraGrid.Columns.GridColumn TenQuan;
        private DevExpress.XtraGrid.Columns.GridColumn IDPhuongXa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhuongXa;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiTruSoHanhChinh;
        private DevExpress.XtraGrid.GridControl gcPhuongXa;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtthongtinlienhe;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtdiachikhupho;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtdientich;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtdanso;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtphuong;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraGrid.Columns.GridColumn IDQuan;
        private System.Windows.Forms.ComboBox cbQuan;
    }
}
