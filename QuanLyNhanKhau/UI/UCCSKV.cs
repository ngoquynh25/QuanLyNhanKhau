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
    public partial class UCCSKV : UserControl
    {
        public UCCSKV()
        {
            InitializeComponent();
        }

        bool _Them;
        int _id;
        CSKVBUS _cSKVBUS;
        KhuPhoBUS _khuPhoBUS;
        List<CSKVDTO> _lstCSDTO;

        #region Method
        void loadcombox()
        {
            cbKhuPho.DataSource = _khuPhoBUS.getListFullCB();
            cbKhuPho.DisplayMember = "TenKhuPho";
            cbKhuPho.ValueMember = "IDKhuPho";
        }

        void loaddata()
        {
            gcCSKV.DataSource = _cSKVBUS.getListFull();
            gvCSKV.OptionsBehavior.Editable = false;
            _lstCSDTO = _cSKVBUS.getListFull();
        }

        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnIn.Enabled = kt;
            txtchucvu.Enabled = !kt;
            cbKhuPho.Enabled = !kt;
            dtngaycongtac.Enabled = !kt;
            txtcskv.Enabled = !kt;
            txtthongtinlienhe.Enabled = !kt;
            checktrangthai.Enabled = !kt;
        }

        void _reset()
        {
            txtcskv.Text = string.Empty;
            cbKhuPho.Text = string.Empty;
            txtthongtinlienhe.Text = string.Empty;
            txtcskv.Text = string.Empty;
            checktrangthai.Checked = false;
        }

        void SaveData()
        {
            tb_CSKV cskv = new tb_CSKV();

            if (_Them)
            {
                cskv.IDKhuPho = int.Parse(cbKhuPho.SelectedValue.ToString());
                cskv.HoTen = txtcskv.Text;
                cskv.ChucVu = txtchucvu.Text;
                cskv.NgayThamGiaCongTac = dtngaycongtac.Value;
                cskv.TrangThai = checktrangthai.Checked;
                cskv.ThongTinLienHe = txtthongtinlienhe.Text;
                _cSKVBUS.Add(cskv);
            }
            else
            {
                var dt = _cSKVBUS.getItem(_id);
                dt.IDCSKV = _id;
                dt.IDKhuPho = int.Parse(cbKhuPho.SelectedValue.ToString());
                dt.HoTen = txtcskv.Text;
                dt.ChucVu = txtchucvu.Text;
                dt.NgayThamGiaCongTac = dtngaycongtac.Value;
                dt.TrangThai = checktrangthai.Checked;
                dt.ThongTinLienHe = txtthongtinlienhe.Text;
                _cSKVBUS.Edit(dt);
            }
        }


        #endregion

        private void UCCSKV_Load(object sender, EventArgs e)
        {
            _khuPhoBUS = new KhuPhoBUS();
            _cSKVBUS = new CSKVBUS();
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
            _showHide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dt = _cSKVBUS.getItem(_id);
            int id = _id;
            if (MessageBox.Show("Bạn có chắc chắn xoá không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _cSKVBUS.Remote(dt);
                loaddata();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcskv.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phường/xã.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void gcCSKV_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvCSKV.GetFocusedRowCellValue("IDCSKV").ToString());
            var dt = _cSKVBUS.getItem(_id);
            cbKhuPho.SelectedValue = dt.IDKhuPho;
            txtcskv.Text = dt.HoTen;
            txtchucvu.Text = dt.ChucVu;
            dtngaycongtac.Value = dt.NgayThamGiaCongTac.Value;
            checktrangthai.Checked = dt.TrangThai.Value;
            txtthongtinlienhe.Text = dt.ThongTinLienHe;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lấy dữ liệu từ quanBUS.getAllQuan()
            var item = _cSKVBUS.getListFull();
            string trangthai = null;

            // Tạo DataTable và thêm dữ liệu vào
            DataTable dt = new DataTable("BangDSCSKV");

            // Thêm các cột vào DataTable (chắc chắn phải có tên cột tương ứng với tên cột trong báo cáo)
            dt.Columns.Add("TenKhuPho", typeof(string));
            dt.Columns.Add("HoTen", typeof(string));
            dt.Columns.Add("ChucVu", typeof(string));
            dt.Columns.Add("NgayThamGiaCongTac", typeof(string));
            dt.Columns.Add("ThongTinLienHe", typeof(string));
            dt.Columns.Add("TrangThai", typeof(string));
            // Thêm dữ liệu từ item (assumed to be a collection of objects) vào DataTable
            foreach (var quan in item)
            {
                if (quan.TrangThai == true)
                {
                    trangthai = "Còn Công Tác";
                }
                else
                {
                    trangthai = "Không Còn Công Tác";
                }
                dt.Rows.Add(quan.TenKhuPho, quan.HoTen, quan.ChucVu, quan.NgayThamGiaCongTac,  quan.ThongTinLienHe, trangthai);
            }

            // Tạo đối tượng báo cáo
            BangCSKV baocao = new BangCSKV();

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
