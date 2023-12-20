
namespace QuanLyNhanKhau.UI
{
    partial class UCChuHo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCChuHo));
            this.cbKhuPho = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checktrangthai = new System.Windows.Forms.CheckBox();
            this.txtthongtinlienhe = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txttenchuho = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcChuHo = new DevExpress.XtraGrid.GridControl();
            this.gvChuHo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDChuHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDKhuPho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKhuPho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTenChuHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ConSong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThongTinLienHe = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.bar1 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChuHo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChuHo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKhuPho
            // 
            this.cbKhuPho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhuPho.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbKhuPho.FormattingEnabled = true;
            this.cbKhuPho.Location = new System.Drawing.Point(225, 85);
            this.cbKhuPho.Name = "cbKhuPho";
            this.cbKhuPho.Size = new System.Drawing.Size(411, 29);
            this.cbKhuPho.TabIndex = 12;
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
            this.splitContainer1.Panel1.Controls.Add(this.checktrangthai);
            this.splitContainer1.Panel1.Controls.Add(this.cbKhuPho);
            this.splitContainer1.Panel1.Controls.Add(this.txtthongtinlienhe);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.txtdiachi);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.txttenchuho);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcChuHo);
            this.splitContainer1.Size = new System.Drawing.Size(1382, 776);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 12;
            // 
            // checktrangthai
            // 
            this.checktrangthai.AutoSize = true;
            this.checktrangthai.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checktrangthai.Location = new System.Drawing.Point(851, 129);
            this.checktrangthai.Name = "checktrangthai";
            this.checktrangthai.Size = new System.Drawing.Size(101, 25);
            this.checktrangthai.TabIndex = 18;
            this.checktrangthai.Text = "Còn Sống";
            this.checktrangthai.UseVisualStyleBackColor = true;
            // 
            // txtthongtinlienhe
            // 
            this.txtthongtinlienhe.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthongtinlienhe.Location = new System.Drawing.Point(851, 85);
            this.txtthongtinlienhe.Name = "txtthongtinlienhe";
            this.txtthongtinlienhe.Size = new System.Drawing.Size(411, 28);
            this.txtthongtinlienhe.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(681, 86);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(140, 21);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Thông Tin Liên Hệ:";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(851, 39);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(411, 28);
            this.txtdiachi.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(707, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(114, 21);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Địa Chỉ Cư Trú:\r\n";
            // 
            // txttenchuho
            // 
            this.txttenchuho.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenchuho.Location = new System.Drawing.Point(225, 39);
            this.txttenchuho.Name = "txttenchuho";
            this.txttenchuho.Size = new System.Drawing.Size(411, 28);
            this.txttenchuho.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(85, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(92, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên Chủ Hộ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(61, 88);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Thuộc Khu Phố:";
            // 
            // gcChuHo
            // 
            this.gcChuHo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChuHo.Location = new System.Drawing.Point(0, 0);
            this.gcChuHo.MainView = this.gvChuHo;
            this.gcChuHo.MenuManager = this.barManager1;
            this.gcChuHo.Name = "gcChuHo";
            this.gcChuHo.Size = new System.Drawing.Size(1382, 580);
            this.gcChuHo.TabIndex = 5;
            this.gcChuHo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChuHo});
            this.gcChuHo.Click += new System.EventHandler(this.gcChuHo_Click);
            // 
            // gvChuHo
            // 
            this.gvChuHo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDChuHo,
            this.IDKhuPho,
            this.TenKhuPho,
            this.HoTenChuHo,
            this.DiaChi,
            this.ConSong,
            this.ThongTinLienHe});
            this.gvChuHo.GridControl = this.gcChuHo;
            this.gvChuHo.Name = "gvChuHo";
            // 
            // IDChuHo
            // 
            this.IDChuHo.Caption = "ID Chủ Hộ";
            this.IDChuHo.FieldName = "IDChuHo";
            this.IDChuHo.MinWidth = 25;
            this.IDChuHo.Name = "IDChuHo";
            this.IDChuHo.Visible = true;
            this.IDChuHo.VisibleIndex = 0;
            this.IDChuHo.Width = 40;
            // 
            // IDKhuPho
            // 
            this.IDKhuPho.Caption = "IDKhuPho";
            this.IDKhuPho.FieldName = "IDKhuPho";
            this.IDKhuPho.MinWidth = 25;
            this.IDKhuPho.Name = "IDKhuPho";
            this.IDKhuPho.Width = 94;
            // 
            // TenKhuPho
            // 
            this.TenKhuPho.Caption = "Thuộc Khu Phố";
            this.TenKhuPho.FieldName = "TenKhuPho";
            this.TenKhuPho.MinWidth = 25;
            this.TenKhuPho.Name = "TenKhuPho";
            this.TenKhuPho.Visible = true;
            this.TenKhuPho.VisibleIndex = 1;
            this.TenKhuPho.Width = 217;
            // 
            // HoTenChuHo
            // 
            this.HoTenChuHo.Caption = "Họ và Tên Chủ Hộ";
            this.HoTenChuHo.FieldName = "HoTenChuHo";
            this.HoTenChuHo.MinWidth = 25;
            this.HoTenChuHo.Name = "HoTenChuHo";
            this.HoTenChuHo.Visible = true;
            this.HoTenChuHo.VisibleIndex = 2;
            this.HoTenChuHo.Width = 217;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa Chỉ Cư Trú";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.MinWidth = 25;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 3;
            this.DiaChi.Width = 217;
            // 
            // ConSong
            // 
            this.ConSong.Caption = "Còn Sống";
            this.ConSong.FieldName = "ConSong";
            this.ConSong.MinWidth = 25;
            this.ConSong.Name = "ConSong";
            this.ConSong.Visible = true;
            this.ConSong.VisibleIndex = 5;
            this.ConSong.Width = 94;
            // 
            // ThongTinLienHe
            // 
            this.ThongTinLienHe.Caption = "Thông Tin Liên Hệ";
            this.ThongTinLienHe.FieldName = "ThongTinLienHe";
            this.ThongTinLienHe.MinWidth = 25;
            this.ThongTinLienHe.Name = "ThongTinLienHe";
            this.ThongTinLienHe.Visible = true;
            this.ThongTinLienHe.VisibleIndex = 4;
            this.ThongTinLienHe.Width = 227;
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
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // UCChuHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UCChuHo";
            this.Size = new System.Drawing.Size(1382, 806);
            this.Load += new System.EventHandler(this.UCChuHo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcChuHo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChuHo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKhuPho;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox checktrangthai;
        private System.Windows.Forms.TextBox txtthongtinlienhe;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtdiachi;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txttenchuho;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcChuHo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChuHo;
        private DevExpress.XtraGrid.Columns.GridColumn IDChuHo;
        private DevExpress.XtraGrid.Columns.GridColumn IDKhuPho;
        private DevExpress.XtraGrid.Columns.GridColumn TenKhuPho;
        private DevExpress.XtraGrid.Columns.GridColumn HoTenChuHo;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn ConSong;
        private DevExpress.XtraGrid.Columns.GridColumn ThongTinLienHe;
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
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar1;
    }
}
