using BusinessLayer;
using DataLayer;
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
    public partial class UCHoGiaDinh : UserControl
    {
        public UCHoGiaDinh()
        {
            InitializeComponent();
        }

        bool _Them;
        int _id;
        HoGiaDinhBUS _hoGiaDinhBUS;
        ChuHoBUS _chuHoBUS;

        #region Method

        void loadchuho()
        {
            slkChuHo.Properties.DataSource = _chuHoBUS.getListFull();
            slkChuHo.Properties.ValueMember = "IDChuHo";
            slkChuHo.Properties.DisplayMember = "HoTenChuHo";
        }

        void loadcombox()
        {
            //cbChuHo.DataSource = _chuHoBUS.getListFullCB();
            //cbChuHo.DisplayMember = "IDChuHo";
            //cbChuHo.ValueMember = "IDChuHo";

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
            gcHoGiaDinh.DataSource = _hoGiaDinhBUS.getList();
            gvHoGiaDinh.OptionsBehavior.Editable = false;
        }

        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnIn.Enabled = kt;
            txthoten.Enabled = !kt;
            //cbChuHo.Enabled = !kt;
            cbgioitinh.Enabled = !kt;
            txtquanhechuho.Enabled = !kt;
            txtnghenghiep.Enabled = !kt;
            checktrangthai.Enabled = !kt;
        }

        void _reset()
        {
            txthoten.Text = string.Empty;
            txtquanhechuho.Text = string.Empty;
            txtnghenghiep.Text = string.Empty;
            checktrangthai.Checked = false;
        }

        void SaveData()
        {
            tb_HoGiaDinh hogiadinh = new tb_HoGiaDinh();

            if (_Them)
            {
                //hogiadinh.IDChuHo = int.Parse(cbChuHo.SelectedValue.ToString());
                hogiadinh.IDChuHo = int.Parse(slkChuHo.EditValue.ToString());
                hogiadinh.HoTen = txthoten.Text;
                hogiadinh.NgheNghiep = txtnghenghiep.Text;
                hogiadinh.GioiTinh = cbgioitinh.SelectedValue.ToString();
                hogiadinh.QuanHeChuHo = txtquanhechuho.Text;
                hogiadinh.ConSong = checktrangthai.Checked;
                _hoGiaDinhBUS.Add(hogiadinh);
            }
            else
            {
                var dt = _hoGiaDinhBUS.getItem(_id);
                dt.IDHoGiaDinh = _id;
                dt.IDChuHo = int.Parse(slkChuHo.EditValue.ToString());
                dt.HoTen = txthoten.Text;
                dt.NgheNghiep = txtnghenghiep.Text;
                dt.GioiTinh = cbgioitinh.SelectedValue.ToString();
                dt.QuanHeChuHo = txtquanhechuho.Text;
                dt.ConSong = checktrangthai.Checked;
                _hoGiaDinhBUS.Edit(dt);
            }
        }

        #endregion

        private void UCHoGiaDinh_Load(object sender, EventArgs e)
        {
            _hoGiaDinhBUS = new HoGiaDinhBUS();
            _chuHoBUS = new ChuHoBUS();
            _Them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
            loadcombox();
            loaddata();
            loadchuho();
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
            var dt = _hoGiaDinhBUS.getItem(_id);
            int id = _id;
            if (MessageBox.Show("Bạn có chắc chắn xoá không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _hoGiaDinhBUS.Remote(dt);
                loaddata();
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lấy dữ liệu từ quanBUS.getAllQuan()
            var item = _hoGiaDinhBUS.getList();
            string trangthai = null;

            // Tạo DataTable và thêm dữ liệu vào
            DataTable dt = new DataTable("BangDSHoChuHo");

            // Thêm các cột vào DataTable (chắc chắn phải có tên cột tương ứng với tên cột trong báo cáo)
            dt.Columns.Add("IDChuHo", typeof(string));
            dt.Columns.Add("HoTen", typeof(string));
            dt.Columns.Add("NgheNghiep", typeof(string));
            dt.Columns.Add("GioiTinh", typeof(string));
            dt.Columns.Add("QuanHeChuHo", typeof(string));
            dt.Columns.Add("TinhTrang", typeof(string));
            // Thêm dữ liệu từ item (assumed to be a collection of objects) vào DataTable
            foreach (var quan in item)
            {
                if (quan.ConSong == true)
                {
                    trangthai = "Còn Sống";
                }
                else
                {
                    trangthai = "Đã Mất";
                }
                dt.Rows.Add(quan.IDChuHo, quan.HoTen, quan.NgheNghiep, quan.GioiTinh, quan.QuanHeChuHo, trangthai);
            }

            // Tạo đối tượng báo cáo
            BangHoGiaDinh baocao = new BangHoGiaDinh();

            // Đặt DataSource cho báo cáo là DataTable vừa tạo
            baocao.SetDataSource(dt);

            // Hiển thị báo cáo
            frmIN fin = new frmIN();
            fin.crystalReportViewer1.ReportSource = baocao;
            fin.ShowDialog();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txthoten.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtquanhechuho.Text))
            {
                MessageBox.Show("Vui lòng nhập quan hệ chủ hộ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void gcHoGiaDinh_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvHoGiaDinh.GetFocusedRowCellValue("IDHoGiaDinh").ToString());
            var dt = _hoGiaDinhBUS.getItem(_id);
            //cbChuHo.SelectedValue = dt.IDChuHo;
            slkChuHo.EditValue = dt.IDChuHo;
            txthoten.Text = dt.HoTen;
            cbgioitinh.SelectedValue = dt.GioiTinh;
            txtnghenghiep.Text = dt.NgheNghiep;
            checktrangthai.Checked = dt.ConSong.Value;
            txtquanhechuho.Text = dt.QuanHeChuHo;
        }

        private void btnLammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loaddata();
        }
    }
}
