using BusinessLayer;
using BusinessLayer.DTO;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanKhau.UI
{
    public partial class UCKhuPho : DevExpress.XtraEditors.XtraUserControl
    {
        public UCKhuPho()
        {
            InitializeComponent();
            txtdanso.KeyPress += txtdanso_KeyPress;
        }

        bool _Them;
        int _id;
        PhuongXaBUS _phuongXaBUS;
        KhuPhoBUS _khuphoBUS;
        List<KhuPhoDTO> _lstKPDTO;

        #region Method
        void loadcombox()
        {
            cbPhuong.DataSource = _phuongXaBUS.getListFull();
            cbPhuong.DisplayMember = "TenPhuong";
            cbPhuong.ValueMember = "IDPhuongXa";
        }


        void loaddata()
        {
            gcKhuPho.DataSource = _khuphoBUS.getListFull();
            gvKhuPho.OptionsBehavior.Editable = false;
            _lstKPDTO = _khuphoBUS.getListFull();
        }

        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnIn.Enabled = kt;
            txtkhupho.Enabled = !kt;
            txtdanso.Enabled = !kt;
            txtdiachikhupho.Enabled = !kt;
            txtthongtinlienhe.Enabled = !kt;
            cbPhuong.Enabled = !kt;
        }

        void _reset()
        {
            txtkhupho.Text = string.Empty;
            cbPhuong.Text = string.Empty;
            txtthongtinlienhe.Text = string.Empty;
            txtdanso.Text = string.Empty;
            txtdiachikhupho.Text = string.Empty;
        }


        void SaveData()
        {
            tb_KhuPho khupho = new tb_KhuPho();

            if (_Them)
            {
                khupho.IDPhuongXa = int.Parse(cbPhuong.SelectedValue.ToString());
                khupho.TenKhuPho = txtkhupho.Text;
                khupho.DanSo = int.Parse(txtdanso.Text);
                khupho.DiaChiTruSoHanhChinh = txtdiachikhupho.Text;
                khupho.ThongTinLienHe = txtthongtinlienhe.Text;
                _khuphoBUS.Add(khupho);
            }
            else
            {
                var dt = _khuphoBUS.getItem(_id);
                dt.IDKhuPho = _id;
                dt.IDPhuongXa = int.Parse(cbPhuong.SelectedValue.ToString());
                dt.TenKhuPho = txtkhupho.Text;
                dt.DanSo = int.Parse(txtdanso.Text);
                dt.DiaChiTruSoHanhChinh = txtdiachikhupho.Text;
                dt.ThongTinLienHe = txtthongtinlienhe.Text;
                _khuphoBUS.Edit(dt);
            }
        }
        #endregion

        private void UCKhuPho_Load(object sender, EventArgs e)
        {
            _khuphoBUS = new KhuPhoBUS();
            _phuongXaBUS = new PhuongXaBUS();
            _Them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
            loaddata();
            loadcombox();
        }

        private void txtdanso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
            var dt = _khuphoBUS.getItem(_id);
            int id = _id;
            if (MessageBox.Show("Bạn có chắc chắn xoá không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _khuphoBUS.Remote(dt);
                loaddata();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtkhupho.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phường/xã.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtdiachikhupho.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtthongtinlienhe.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin liên hệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giá trị không được nhập cho Dân số
            if (string.IsNullOrEmpty(txtdanso.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị cho Dân số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void gcKhuPho_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvKhuPho.GetFocusedRowCellValue("IDKhuPho").ToString());
            var dt = _khuphoBUS.getItem(_id);
            cbPhuong.SelectedValue = dt.IDPhuongXa;
            txtkhupho.Text = gvKhuPho.GetFocusedRowCellValue("TenKhuPho").ToString();
            txtdanso.Text = gvKhuPho.GetFocusedRowCellValue("DanSo").ToString();
            txtdiachikhupho.Text = gvKhuPho.GetFocusedRowCellValue("DiaChiTruSoHanhChinh").ToString();
            txtthongtinlienhe.Text = gvKhuPho.GetFocusedRowCellValue("ThongTinLienHe").ToString();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lấy dữ liệu từ quanBUS.getAllQuan()
            var item = _khuphoBUS.getListFull();

            // Tạo DataTable và thêm dữ liệu vào
            DataTable dt = new DataTable("BangDSKhuPho");

            // Thêm các cột vào DataTable (chắc chắn phải có tên cột tương ứng với tên cột trong báo cáo)
            dt.Columns.Add("TenPhuongXa", typeof(string));
            dt.Columns.Add("TenKhuPho", typeof(string));
            dt.Columns.Add("DiaChiTruSoHanhChinh", typeof(string));
            dt.Columns.Add("ThongTinLienHe", typeof(string));
            // Thêm dữ liệu từ item (assumed to be a collection of objects) vào DataTable
            foreach (var quan in item)
            {
                dt.Rows.Add(quan.TenPhuong, quan.TenKhuPho, quan.DiaChiTruSoHanhChinh, quan.ThongTinLienHe);
            }

            // Tạo đối tượng báo cáo
            BangKhuPho baocao = new BangKhuPho();

            // Đặt DataSource cho báo cáo là DataTable vừa tạo
            baocao.SetDataSource(dt);

            // Hiển thị báo cáo
            frmIN fin = new frmIN();
            fin.crystalReportViewer1.ReportSource = baocao;
            fin.ShowDialog();
        }
    }
}
