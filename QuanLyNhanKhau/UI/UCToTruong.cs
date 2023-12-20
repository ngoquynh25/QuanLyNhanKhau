using BusinessLayer;
using BusinessLayer.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace QuanLyNhanKhau.UI
{
    public partial class UCToTruong : UserControl
    {
        public UCToTruong()
        {
            InitializeComponent();
        }

        bool _Them;
        int _id;
        ToTruongBUS _toTruongBUS;
        KhuPhoBUS _khuPhoBUS;
        List<ToTruongDTO> _lstTTDTO;

        #region Method
        void loadcombox()
        {
            cbKhuPho.DataSource = _khuPhoBUS.getListFullCB();
            cbKhuPho.DisplayMember = "TenKhuPho";
            cbKhuPho.ValueMember = "IDKhuPho";

            List<KeyValuePair<string, string>> items = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("Nam", "Nam"),
                new KeyValuePair<string, string>("Nữ", "Nữ")
            };
            cbgioitinh.DataSource = items;
            cbgioitinh.DisplayMember = "Value";
            cbgioitinh.ValueMember = "Key";

        }

        void loaddata()
        {
            gcToTruong.DataSource = _toTruongBUS.getListFull();
            gvToTruong.OptionsBehavior.Editable = false;
            _lstTTDTO = _toTruongBUS.getListFull();
        }

        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnIn.Enabled = kt;
            txttotruong.Enabled = !kt;
            cbKhuPho.Enabled = !kt;
            cbgioitinh.Enabled = !kt;
            dtngaybatdau.Enabled = !kt;
            dtngaysinh.Enabled = !kt;
            txtdiachicutru.Enabled = !kt;
            txtthongtinlienhe.Enabled = !kt;
            checktrangthai.Enabled = !kt;
        }

        void _reset()
        {
            txttotruong.Text = string.Empty;
            cbKhuPho.Text = string.Empty;
            txtthongtinlienhe.Text = string.Empty;
            txtdiachicutru.Text = string.Empty;
            checktrangthai.Checked = false;
        }

        void SaveData()
        {
            tb_ToTruongKhuPho totruong = new tb_ToTruongKhuPho();

            if (_Them)
            {
                totruong.IDKhuPho = int.Parse(cbKhuPho.SelectedValue.ToString());
                totruong.TenToTruong = txttotruong.Text;
                totruong.NgaySinh = dtngaysinh.Value;
                totruong.GioiTinh = cbKhuPho.SelectedValue.ToString();
                totruong.DiaChiCuTru = txtdiachicutru.Text;
                totruong.NgayBatDau = dtngaybatdau.Value;
                totruong.TrangThai = checktrangthai.Checked;
                totruong.ThongTinLienHe = txtthongtinlienhe.Text;
                _toTruongBUS.Add(totruong);
            }
            else
            {
                var dt = _toTruongBUS.getItem(_id);
                dt.IDToTruong = _id;
                dt.IDKhuPho = int.Parse(cbKhuPho.SelectedValue.ToString());
                dt.TenToTruong = txttotruong.Text;
                dt.NgaySinh = dtngaysinh.Value;
                dt.GioiTinh = cbgioitinh.SelectedValue.ToString();
                dt.DiaChiCuTru = txtdiachicutru.Text;
                dt.NgayBatDau = dtngaybatdau.Value;
                dt.TrangThai = checktrangthai.Checked;
                dt.ThongTinLienHe = txtthongtinlienhe.Text;
                _toTruongBUS.Edit(dt);
            }
        }

        #endregion


        private void UCToTruong_Load(object sender, EventArgs e)
        {
            _toTruongBUS = new ToTruongBUS();
            _khuPhoBUS = new KhuPhoBUS();
            _Them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
            loaddata();
            loadcombox();
            
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _reset();
            _showHide(false);
            _Them = true;
            splitContainer1.Panel1Collapsed = false;
            splitContainer1.Panel2.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            _Them = false;
            //_Sua = false;
            _showHide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dt = _toTruongBUS.getItem(_id);
            int id = _id;
            if (MessageBox.Show("Bạn có chắc chắn xoá không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _toTruongBUS.Remote(dt);
                loaddata();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txttotruong.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tổ trưởng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtdiachicutru.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtthongtinlienhe.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin liên hệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            splitContainer1.Panel1Collapsed = true;
            splitContainer1.Panel2.Enabled = true;
            SaveData();
            //EditData();
            loaddata();
            _Them = false;
            _showHide(true);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            splitContainer1.Panel2.Enabled = true;
            _Them = false;
            _showHide(true);
        }

        private void gcToTruong_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvToTruong.GetFocusedRowCellValue("IDToTruong").ToString());
            var dt = _toTruongBUS.getItem(_id);
            cbKhuPho.SelectedValue = dt.IDKhuPho;
            txttotruong.Text = dt.TenToTruong;
            dtngaysinh.Value = dt.NgaySinh.Value;
            cbgioitinh.SelectedValue = dt.GioiTinh;
            txtdiachicutru.Text = dt.DiaChiCuTru;
            dtngaybatdau.Value = dt.NgayBatDau.Value;
            checktrangthai.Checked = dt.TrangThai.Value;
            txtthongtinlienhe.Text = dt.ThongTinLienHe;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lấy dữ liệu từ quanBUS.getAllQuan()
            var item = _toTruongBUS.getListFull();
            string trangthai = null;

            // Tạo DataTable và thêm dữ liệu vào
            DataTable dt = new DataTable("BangDSToTruong");

            // Thêm các cột vào DataTable (chắc chắn phải có tên cột tương ứng với tên cột trong báo cáo)
            dt.Columns.Add("TenKhuPho", typeof(string));
            dt.Columns.Add("TenToTruong", typeof(string));
            dt.Columns.Add("GioiTinh", typeof(string));
            dt.Columns.Add("DiaChiCuTru", typeof(string));
            dt.Columns.Add("TrangThai", typeof(string));
            dt.Columns.Add("ThongTinLienHe", typeof(string));
            // Thêm dữ liệu từ item (assumed to be a collection of objects) vào DataTable
            foreach (var quan in item)
            {
                if(quan.TrangThai == true)
                {
                    trangthai = "Còn Công Tác";
                }
                else
                {
                    trangthai = "Không Còn Công Tác";
                }
                dt.Rows.Add(quan.TenKhuPho, quan.TenToTruong, quan.GioiTinh, quan.DiaChiCuTru, trangthai, quan.ThongTinLienHe);
            }

            // Tạo đối tượng báo cáo
            BangToTruong baocao = new BangToTruong();

            // Đặt DataSource cho báo cáo là DataTable vừa tạo
            baocao.SetDataSource(dt);

            // Hiển thị báo cáo
            frmIN fin = new frmIN();
            fin.crystalReportViewer1.ReportSource = baocao;
            fin.ShowDialog();
        }
    }
}
