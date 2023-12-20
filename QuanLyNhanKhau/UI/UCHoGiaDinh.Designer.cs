
namespace QuanLyNhanKhau.UI
{
    partial class UCHoGiaDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHoGiaDinh));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
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
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ConSong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgheNghiep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDChuHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDHoGiaDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvHoGiaDinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcHoGiaDinh = new DevExpress.XtraGrid.GridControl();
            this.checktrangthai = new System.Windows.Forms.CheckBox();
            this.txtquanhechuho = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtnghenghiep = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbgioitinh = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbChuHo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoGiaDinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoGiaDinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 776);
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
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới Tính";
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.MinWidth = 25;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 4;
            this.GioiTinh.Width = 343;
            // 
            // ConSong
            // 
            this.ConSong.Caption = "Còn Sống";
            this.ConSong.FieldName = "ConSong";
            this.ConSong.MinWidth = 25;
            this.ConSong.Name = "ConSong";
            this.ConSong.Visible = true;
            this.ConSong.VisibleIndex = 5;
            this.ConSong.Width = 155;
            // 
            // NgheNghiep
            // 
            this.NgheNghiep.Caption = "Nghề Nghiệp";
            this.NgheNghiep.FieldName = "NgheNghiep";
            this.NgheNghiep.MinWidth = 25;
            this.NgheNghiep.Name = "NgheNghiep";
            this.NgheNghiep.Visible = true;
            this.NgheNghiep.VisibleIndex = 3;
            this.NgheNghiep.Width = 327;
            // 
            // IDChuHo
            // 
            this.IDChuHo.Caption = "ID Chủ Hộ";
            this.IDChuHo.FieldName = "IDChuHo";
            this.IDChuHo.MinWidth = 25;
            this.IDChuHo.Name = "IDChuHo";
            this.IDChuHo.Visible = true;
            this.IDChuHo.VisibleIndex = 1;
            this.IDChuHo.Width = 100;
            // 
            // IDHoGiaDinh
            // 
            this.IDHoGiaDinh.Caption = "ID Hộ Gia Đình";
            this.IDHoGiaDinh.FieldName = "IDHoGiaDinh";
            this.IDHoGiaDinh.MinWidth = 25;
            this.IDHoGiaDinh.Name = "IDHoGiaDinh";
            this.IDHoGiaDinh.Visible = true;
            this.IDHoGiaDinh.VisibleIndex = 0;
            this.IDHoGiaDinh.Width = 100;
            // 
            // gvHoGiaDinh
            // 
            this.gvHoGiaDinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDHoGiaDinh,
            this.IDChuHo,
            this.HoTen,
            this.NgheNghiep,
            this.GioiTinh,
            this.ConSong});
            this.gvHoGiaDinh.GridControl = this.gcHoGiaDinh;
            this.gvHoGiaDinh.Name = "gvHoGiaDinh";
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Họ và Tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.MinWidth = 25;
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 2;
            this.HoTen.Width = 327;
            // 
            // gcHoGiaDinh
            // 
            this.gcHoGiaDinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHoGiaDinh.Location = new System.Drawing.Point(0, 0);
            this.gcHoGiaDinh.MainView = this.gvHoGiaDinh;
            this.gcHoGiaDinh.MenuManager = this.barManager1;
            this.gcHoGiaDinh.Name = "gcHoGiaDinh";
            this.gcHoGiaDinh.Size = new System.Drawing.Size(1382, 580);
            this.gcHoGiaDinh.TabIndex = 5;
            this.gcHoGiaDinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHoGiaDinh});
            this.gcHoGiaDinh.Click += new System.EventHandler(this.gcHoGiaDinh_Click);
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
            // txtquanhechuho
            // 
            this.txtquanhechuho.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquanhechuho.Location = new System.Drawing.Point(851, 39);
            this.txtquanhechuho.Name = "txtquanhechuho";
            this.txtquanhechuho.Size = new System.Drawing.Size(411, 28);
            this.txtquanhechuho.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(665, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(156, 21);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Quan Hệ Với Chủ Hộ:\r\n";
            // 
            // txthoten
            // 
            this.txthoten.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Location = new System.Drawing.Point(225, 39);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(411, 28);
            this.txthoten.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(90, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Họ và Tên:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(62, 88);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Thuộc Chủ Hộ:";
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
            this.splitContainer1.Panel1.Controls.Add(this.txtnghenghiep);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.cbgioitinh);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.checktrangthai);
            this.splitContainer1.Panel1.Controls.Add(this.cbChuHo);
            this.splitContainer1.Panel1.Controls.Add(this.txtquanhechuho);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.txthoten);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcHoGiaDinh);
            this.splitContainer1.Size = new System.Drawing.Size(1382, 776);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 13;
            // 
            // txtnghenghiep
            // 
            this.txtnghenghiep.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnghenghiep.Location = new System.Drawing.Point(225, 129);
            this.txtnghenghiep.Name = "txtnghenghiep";
            this.txtnghenghiep.Size = new System.Drawing.Size(411, 28);
            this.txtnghenghiep.TabIndex = 22;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(71, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(100, 21);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Nghề Nghiệp:";
            // 
            // cbgioitinh
            // 
            this.cbgioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbgioitinh.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbgioitinh.FormattingEnabled = true;
            this.cbgioitinh.Location = new System.Drawing.Point(851, 85);
            this.cbgioitinh.Name = "cbgioitinh";
            this.cbgioitinh.Size = new System.Drawing.Size(411, 29);
            this.cbgioitinh.TabIndex = 20;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(750, 88);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 21);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Giới Tính:";
            // 
            // cbChuHo
            // 
            this.cbChuHo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChuHo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbChuHo.FormattingEnabled = true;
            this.cbChuHo.Location = new System.Drawing.Point(225, 85);
            this.cbChuHo.Name = "cbChuHo";
            this.cbChuHo.Size = new System.Drawing.Size(411, 29);
            this.cbChuHo.TabIndex = 12;
            // 
            // UCHoGiaDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UCHoGiaDinh";
            this.Size = new System.Drawing.Size(1382, 806);
            this.Load += new System.EventHandler(this.UCHoGiaDinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoGiaDinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoGiaDinh)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
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
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox checktrangthai;
        private System.Windows.Forms.ComboBox cbChuHo;
        private System.Windows.Forms.TextBox txtquanhechuho;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txthoten;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcHoGiaDinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHoGiaDinh;
        private DevExpress.XtraGrid.Columns.GridColumn IDHoGiaDinh;
        private DevExpress.XtraGrid.Columns.GridColumn IDChuHo;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn NgheNghiep;
        private DevExpress.XtraGrid.Columns.GridColumn ConSong;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.TextBox txtnghenghiep;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cbgioitinh;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}
