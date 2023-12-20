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

namespace QuanLyNhanKhau.UI
{
    public partial class UCQuan : UserControl
    {
        public UCQuan()
        {
            InitializeComponent();
            txtdanso.KeyPress += txtdanso_KeyPress;
            
        }

        QuanBUS quanBUS = new QuanBUS();
        bool _Them;
        int _id;

        void loaddata()
        {
            gcQuan.DataSource = quanBUS.getAllQuan();
            gvQuan.OptionsBehavior.Editable = false;
        }

        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnIn.Enabled = kt;
            txttenquan.Enabled = !kt;
            txtdanso.Enabled = !kt;
            txtdiachikhupho.Enabled = !kt;
            txtdientich.Enabled = !kt;
            txtthongtinlienhe.Enabled = !kt;
            txtthanhpho.Enabled = !kt;
        }

        void _reset()
        {
            txttenquan.Text = string.Empty;
            txtthanhpho.Text = string.Empty;
            txtthongtinlienhe.Text = string.Empty;
            txtdientich.Text = string.Empty;
            txtdanso.Text = string.Empty;
            txtdiachikhupho.Text = string.Empty;
        }

        void SaveData()
        {
            

            tb_Quan quan = new tb_Quan();
            if (_Them)
            {
                quan.TenQuan = txttenquan.Text;
                quan.ThanhPho_Tinh = txtthanhpho.Text;
                quan.ThongTinLienHe = txtthongtinlienhe.Text;
                quan.DienTich = float.Parse(txtdientich.Text);
                quan.DanSo = int.Parse(txtdanso.Text);
                quan.DiaChiKhuPhoHanhChinh = txtdiachikhupho.Text;
                quanBUS.Add(quan);
            }
            else
            {
                var dt = quanBUS.getItem(_id);
                dt.IDQuan = _id;
                dt.TenQuan = txttenquan.Text;
                dt.ThanhPho_Tinh = txtthanhpho.Text;
                dt.ThongTinLienHe = txtthongtinlienhe.Text;
                dt.DienTich = float.Parse(txtdientich.Text);
                dt.DanSo = int.Parse(txtdanso.Text);
                dt.DiaChiKhuPhoHanhChinh = txtdiachikhupho.Text;
                quanBUS.Edit(dt);
            }
        }


        private void UCQuan_Load(object sender, EventArgs e)
        {
            
            _Them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
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
            var dt = quanBUS.getItem(_id);
            int id = _id;
            if (MessageBox.Show("Bạn có chắc chắn xoá không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                quanBUS.Remote(dt);
                loaddata();
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lấy dữ liệu từ quanBUS.getAllQuan()
            var item = quanBUS.getAllQuan();

            // Tạo DataTable và thêm dữ liệu vào
            DataTable dt = new DataTable("BangDSQuan");

            // Thêm các cột vào DataTable (chắc chắn phải có tên cột tương ứng với tên cột trong báo cáo)
            dt.Columns.Add("IDQuan", typeof(string));
            dt.Columns.Add("TenQuan", typeof(string));
            dt.Columns.Add("ThanhPho_Tinh", typeof(string));
            dt.Columns.Add("DiaChiKhuPhoHanhChinh", typeof(string));
            dt.Columns.Add("ThongTinLienHe", typeof(string));
            // Thêm dữ liệu từ item (assumed to be a collection of objects) vào DataTable
            foreach (var quan in item)
            {
                dt.Rows.Add(quan.IDQuan ,quan.TenQuan, quan.ThanhPho_Tinh, quan.DiaChiKhuPhoHanhChinh, quan.ThongTinLienHe);
            }

            // Tạo đối tượng báo cáo
            BangQuan baocao = new BangQuan();

            // Đặt DataSource cho báo cáo là DataTable vừa tạo
            baocao.SetDataSource(dt);

            // Hiển thị báo cáo
            frmIN fin = new frmIN();
            fin.crystalReportViewer1.ReportSource = baocao;
            fin.ShowDialog();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txttenquan.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Quận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtthanhpho.Text))
            {
                MessageBox.Show("Vui lòng nhập Thành Phố/Tỉnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void gcQuan_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvQuan.GetFocusedRowCellValue("IDQuan").ToString());
            txttenquan.Text = gvQuan.GetFocusedRowCellValue("TenQuan").ToString();
            txtthanhpho.Text = gvQuan.GetFocusedRowCellValue("ThanhPho_Tinh").ToString();
            txtthongtinlienhe.Text = gvQuan.GetFocusedRowCellValue("ThongTinLienHe").ToString();
            txtdientich.Text = gvQuan.GetFocusedRowCellValue("DienTich").ToString();
            txtdiachikhupho.Text = gvQuan.GetFocusedRowCellValue("DiaChiKhuPhoHanhChinh").ToString();
            txtdanso.Text = gvQuan.GetFocusedRowCellValue("DanSo").ToString();
        }

        private void UCQuan_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    // Gọi phương thức hoặc thực hiện hành động "Lưu" ở đây
            //    btnLuu.PerformClick();

            //    // Ngăn chặn sự kiện KeyDown được truyền tiếp để tránh xử lý nhiều lần
            //    e.Handled = true;
            //    e.SuppressKeyPress = true;
            //}
            if (e.KeyCode == Keys.Enter)
            {
                // Xử lý sự kiện nhấn Enter tại đây
                MessageBox.Show("Phím Enter được nhấn trong UserControl");
            }
        }

        private void UCQuan_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Xử lý sự kiện nhấn Enter tại đây
                MessageBox.Show("Phím Enter được nhấn trong UserControl");
            }
        }
    }
}
