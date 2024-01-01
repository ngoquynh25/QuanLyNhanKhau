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
using BusinessLayer;
using DataLayer;
using BusinessLayer.DTO;

namespace QuanLyNhanKhau.UI
{
    public partial class UCPhuongXa : DevExpress.XtraEditors.XtraUserControl
    {
        public UCPhuongXa()
        {
            InitializeComponent();
            txtdanso.KeyPress += txtdanso_KeyPress;
        }

        bool _Them;
        int _id;
        QuanBUS _quanBus;
        PhuongXaBUS _phuongxaBus;
        List<PhuongXaDTO> _lstPXDTO;

        #region Method
        void loadcombox()
        {
            cbQuan.DataSource = _quanBus.getAllQuanCB();
            cbQuan.DisplayMember = "TenQuan";
            cbQuan.ValueMember = "IDQuan";
        }

        void loaddata()
        {
            gcPhuongXa.DataSource = _phuongxaBus.getListFull();
            gvPhuongXa.OptionsBehavior.Editable = false;
            _lstPXDTO = _phuongxaBus.getListFull();
        }

        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnIn.Enabled = kt;
            txtphuong.Enabled = !kt;
            txtdanso.Enabled = !kt;
            txtdiachikhupho.Enabled = !kt;
            txtdientich.Enabled = !kt;
            txtthongtinlienhe.Enabled = !kt;
            cbQuan.Enabled = !kt;
        }

        void _reset()
        {
            txtphuong.Text = string.Empty;
            cbQuan.Text = string.Empty;
            txtthongtinlienhe.Text = string.Empty;
            txtdientich.Text = string.Empty;
            txtdanso.Text = string.Empty;
            txtdiachikhupho.Text = string.Empty;
        }

        void SaveData()
        {
            tb_PhuongXa phuongxa = new tb_PhuongXa();

            if (_Them)
            {
                phuongxa.IDQuan = int.Parse(cbQuan.SelectedValue.ToString());
                phuongxa.TenPhuong = txtphuong.Text;
                phuongxa.DienTich = float.Parse(txtdientich.Text);
                phuongxa.DanSo = int.Parse(txtdanso.Text);
                phuongxa.DiaChiTruSoHanhChinh = txtdiachikhupho.Text;
                phuongxa.ThongTinLienHe = txtthongtinlienhe.Text;
                _phuongxaBus.Add(phuongxa);
            }
            else
            {
                var dt = _phuongxaBus.getItem(_id);
                dt.IDPhuongXa = _id;
                dt.IDQuan = int.Parse(cbQuan.SelectedValue.ToString());
                dt.TenPhuong = txtphuong.Text;
                dt.DienTich = float.Parse(txtdientich.Text);
                dt.DanSo = int.Parse(txtdanso.Text);
                dt.DiaChiTruSoHanhChinh = txtdiachikhupho.Text;
                dt.ThongTinLienHe = txtthongtinlienhe.Text;
                _phuongxaBus.Edit(dt);
            }
        }
        #endregion

        private void UCPhuongXa_Load(object sender, EventArgs e)
        {
            _quanBus = new QuanBUS();
            _phuongxaBus = new PhuongXaBUS();
            _Them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
            loadcombox();
            loaddata();
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
            var dt = _phuongxaBus.getItem(_id);
            int id = _id;
            if (MessageBox.Show("Bạn có chắc chắn xoá không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _phuongxaBus.Remote(dt);
                loaddata();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtphuong.Text))
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

            // Kiểm tra giá trị không được nhập cho Diện tích
            if (string.IsNullOrEmpty(txtdientich.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị cho Diện tích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void gcPhuongXa_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvPhuongXa.GetFocusedRowCellValue("IDPhuongXa").ToString());
            var dt = _phuongxaBus.getItem(_id);
            cbQuan.SelectedValue = dt.IDQuan;
            txtphuong.Text = gvPhuongXa.GetFocusedRowCellValue("TenPhuong").ToString();
            txtdanso.Text = gvPhuongXa.GetFocusedRowCellValue("DanSo").ToString();
            txtdientich.Text = gvPhuongXa.GetFocusedRowCellValue("DienTich").ToString();
            txtdiachikhupho.Text = gvPhuongXa.GetFocusedRowCellValue("DiaChiTruSoHanhChinh").ToString();
            txtthongtinlienhe.Text = gvPhuongXa.GetFocusedRowCellValue("ThongTinLienHe").ToString();

        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lấy dữ liệu từ quanBUS.getAllQuan()
            var item = _phuongxaBus.getListFull();

            // Tạo DataTable và thêm dữ liệu vào
            DataTable dt = new DataTable("BangDSPhuong");

            // Thêm các cột vào DataTable (chắc chắn phải có tên cột tương ứng với tên cột trong báo cáo)
            dt.Columns.Add("IDQuan", typeof(string));
            dt.Columns.Add("TenPhuong", typeof(string));
            dt.Columns.Add("DiaChiTruSoHanhChinh", typeof(string));
            dt.Columns.Add("ThongTinLienHe", typeof(string));
            // Thêm dữ liệu từ item (assumed to be a collection of objects) vào DataTable
            foreach (var quan in item)
            {
                dt.Rows.Add(quan.IDQuan, quan.TenPhuong, quan.DiaChiTruSoHanhChinh, quan.ThongTinLienHe);
            }

            // Tạo đối tượng báo cáo
            BangPhuong baocao = new BangPhuong();

            // Đặt DataSource cho báo cáo là DataTable vừa tạo
            baocao.SetDataSource(dt);

            // Hiển thị báo cáo
            frmIN fin = new frmIN();
            fin.crystalReportViewer1.ReportSource = baocao;
            fin.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loaddata();
        }
    }
}
