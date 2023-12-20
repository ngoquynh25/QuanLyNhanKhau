
namespace QuanLyNhanKhau
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.controlDiaBanHanhChinh = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlQuan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlPhuongXa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlKP = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlKhuPho = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlToTruong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlCSKV = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlHoGiaDinh = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlChuHo = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlHGD = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(350, 39);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(885, 686);
            this.mainContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 10F);
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.controlDiaBanHanhChinh,
            this.controlKhuPho,
            this.controlHoGiaDinh});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(350, 686);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // controlDiaBanHanhChinh
            // 
            this.controlDiaBanHanhChinh.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.controlQuan,
            this.controlPhuongXa,
            this.controlKP});
            this.controlDiaBanHanhChinh.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.controlDiaBanHanhChinh.Name = "controlDiaBanHanhChinh";
            this.controlDiaBanHanhChinh.Text = "Địa Bàn Hành Chính";
            // 
            // controlQuan
            // 
            this.controlQuan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("controlQuan.ImageOptions.Image")));
            this.controlQuan.Name = "controlQuan";
            this.controlQuan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlQuan.Text = "Danh Sách Các Quận";
            this.controlQuan.Click += new System.EventHandler(this.controlQuan_Click);
            // 
            // controlPhuongXa
            // 
            this.controlPhuongXa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("controlPhuongXa.ImageOptions.Image")));
            this.controlPhuongXa.Name = "controlPhuongXa";
            this.controlPhuongXa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlPhuongXa.Text = "Danh Sách Phường Xã";
            this.controlPhuongXa.Click += new System.EventHandler(this.controlPhuongXa_Click);
            // 
            // controlKP
            // 
            this.controlKP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("controlKP.ImageOptions.Image")));
            this.controlKP.Name = "controlKP";
            this.controlKP.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlKP.Text = "Danh Sách Khu Phố";
            this.controlKP.Click += new System.EventHandler(this.controlKP_Click);
            // 
            // controlKhuPho
            // 
            this.controlKhuPho.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.controlToTruong,
            this.controlCSKV});
            this.controlKhuPho.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.controlKhuPho.Name = "controlKhuPho";
            this.controlKhuPho.Text = "Quản Lý Khu Phố";
            // 
            // controlToTruong
            // 
            this.controlToTruong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("controlToTruong.ImageOptions.Image")));
            this.controlToTruong.Name = "controlToTruong";
            this.controlToTruong.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlToTruong.Text = "Danh Sách Tổ Trưởng Khu Phố";
            this.controlToTruong.Click += new System.EventHandler(this.controlToTruong_Click);
            // 
            // controlCSKV
            // 
            this.controlCSKV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("controlCSKV.ImageOptions.Image")));
            this.controlCSKV.Name = "controlCSKV";
            this.controlCSKV.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlCSKV.Text = "Danh Sách Cảnh Sát Khu Vực";
            this.controlCSKV.Click += new System.EventHandler(this.controlCSKV_Click);
            // 
            // controlHoGiaDinh
            // 
            this.controlHoGiaDinh.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.controlChuHo,
            this.controlHGD});
            this.controlHoGiaDinh.Name = "controlHoGiaDinh";
            this.controlHoGiaDinh.Text = "Quản Lý Hộ Gia Đình";
            // 
            // controlChuHo
            // 
            this.controlChuHo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("controlChuHo.ImageOptions.Image")));
            this.controlChuHo.Name = "controlChuHo";
            this.controlChuHo.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlChuHo.Text = "Danh Sách Chủ Hộ";
            this.controlChuHo.Click += new System.EventHandler(this.controlChuHo_Click);
            // 
            // controlHGD
            // 
            this.controlHGD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("controlHGD.ImageOptions.Image")));
            this.controlHGD.Name = "controlHGD";
            this.controlHGD.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlHGD.Text = "Danh Sách Hộ Gia Đình";
            this.controlHGD.Click += new System.EventHandler(this.controlHGD_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1235, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 725);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormMain";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Quản Lý Nhân Khẩu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlDiaBanHanhChinh;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlQuan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlPhuongXa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlKP;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlKhuPho;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlToTruong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlCSKV;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlHoGiaDinh;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlChuHo;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlHGD;
    }
}

