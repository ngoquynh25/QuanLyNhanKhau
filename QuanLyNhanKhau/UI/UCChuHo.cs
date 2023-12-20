using BusinessLayer;
using BusinessLayer.DTO;
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
    public partial class UCChuHo : UserControl
    {
        public UCChuHo()
        {
            InitializeComponent();
        }

        bool _Them;
        int _id;
        ChuHoBUS _chuHoBUS;
        KhuPhoBUS _khuPhoBUS;
        List<ChuHoDTO> _lstCHDTO;

        #region Method

        void loadcombox()
        {
            cbKhuPho.DataSource = _khuPhoBUS.getListFullCB();
            cbKhuPho.DisplayMember = "TenKhuPho";
            cbKhuPho.ValueMember = "IDKhuPho";
        }

        void loaddata()
        {
            gcChuHo.DataSource = _chuHoBUS.getListFull();
            gvChuHo.OptionsBehavior.Editable = false;
            _lstCHDTO = _chuHoBUS.getListFull();
        }

        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnIn.Enabled = kt;
            txttenchuho.Enabled = !kt;
            cbKhuPho.Enabled = !kt;
            txtdiachi.Enabled = !kt;
            txtthongtinlienhe.Enabled = !kt;
            checktrangthai.Enabled = !kt;
        }

        void _reset()
        {
            txttenchuho.Text = string.Empty;
            cbKhuPho.Text = string.Empty;
            txtthongtinlienhe.Text = string.Empty;
            txtdiachi.Text = string.Empty;
            checktrangthai.Checked = false;
        }

        void SaveData()
        {
            tb_ChuHo chuho = new tb_ChuHo();

            if (_Them)
            {
                chuho.IDKhuPho = int.Parse(cbKhuPho.SelectedValue.ToString());
                chuho.HoTenChuHo = txttenchuho.Text;
                chuho.DiaChi = txtdiachi.Text;
                chuho.ConSong = checktrangthai.Checked;
                chuho.ThongTinLienHe = txtthongtinlienhe.Text;
                _chuHoBUS.Add(chuho);
            }
            else
            {
                var dt = _chuHoBUS.getItem(_id);
                dt.IDChuHo = _id;
                dt.IDKhuPho = int.Parse(cbKhuPho.SelectedValue.ToString());
                dt.HoTenChuHo = txttenchuho.Text;
                dt.DiaChi = txtdiachi.Text;
                dt.ConSong = checktrangthai.Checked;
                dt.ThongTinLienHe = txtthongtinlienhe.Text;
                _chuHoBUS.Edit(dt);
            }
        }


        #endregion


        private void UCChuHo_Load(object sender, EventArgs e)
        {
            _chuHoBUS = new ChuHoBUS();
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
            var dt = _chuHoBUS.getItem(_id);
            int id = _id;
            if (MessageBox.Show("Bạn có chắc chắn xoá không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _chuHoBUS.Remote(dt);
                loaddata();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txttenchuho.Text))
            {
                MessageBox.Show("Vui lòng nhập tên chủ hộ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtdiachi.Text))
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

        private void gcChuHo_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvChuHo.GetFocusedRowCellValue("IDChuHo").ToString());
            var dt = _chuHoBUS.getItem(_id);
            cbKhuPho.SelectedValue = dt.IDKhuPho;
            txttenchuho.Text = dt.HoTenChuHo;
            txtdiachi.Text = dt.DiaChi;
            checktrangthai.Checked = dt.ConSong.Value;
            txtthongtinlienhe.Text = dt.ThongTinLienHe;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lấy dữ liệu từ quanBUS.getAllQuan()
            var item = _chuHoBUS.getListFull();
            string trangthai = null;

            // Tạo DataTable và thêm dữ liệu vào
            DataTable dt = new DataTable("BangDSChuHo");

            // Thêm các cột vào DataTable (chắc chắn phải có tên cột tương ứng với tên cột trong báo cáo)
            dt.Columns.Add("TenKhuPho", typeof(string));
            dt.Columns.Add("HoTenChuHo", typeof(string));
            dt.Columns.Add("DiaChi", typeof(string));
            dt.Columns.Add("ThongTinLienHe", typeof(string));
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
                dt.Rows.Add(quan.TenKhuPho, quan.HoTenChuHo, quan.DiaChi, quan.ThongTinLienHe, trangthai);
            }

            // Tạo đối tượng báo cáo
            BangChuHo baocao = new BangChuHo();

            // Đặt DataSource cho báo cáo là DataTable vừa tạo
            baocao.SetDataSource(dt);

            // Hiển thị báo cáo
            frmIN fin = new frmIN();
            fin.crystalReportViewer1.ReportSource = baocao;
            fin.ShowDialog();
        }
    }
}
