using DevExpress.XtraBars;
using QuanLyNhanKhau.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhanKhau
{
    public partial class FormMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        UCQuan uCQuan;
        UCPhuongXa uCPhuongXa;
        UCKhuPho uCKhuPho;
        UCToTruong uCToTruong;
        UCCSKV uCCSKV;
        UCChuHo uCChuHo;
        UCHoGiaDinh uCHoGiaDinh;
        UCBackUp uCBackUp;
        UCRestore uCRestore;

        private void controlQuan_Click(object sender, EventArgs e)
        {
            if(uCQuan == null)
            {
                uCQuan = new UCQuan();
                uCQuan.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uCQuan);
                uCQuan.BringToFront();
            }else
                uCQuan.BringToFront();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    // Xử lý sự kiện nhấn Enter tại đây
            //    MessageBox.Show("Phím Enter được nhấn trong UserControl");
            //}
        }

        private void controlPhuongXa_Click(object sender, EventArgs e)
        {
            if (uCPhuongXa == null)
            {
                uCPhuongXa = new UCPhuongXa();
                uCPhuongXa.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uCPhuongXa);
                uCPhuongXa.BringToFront();
            }
            else
                uCPhuongXa.BringToFront();
        }

        private void controlKP_Click(object sender, EventArgs e)
        {
            if (uCKhuPho == null)
            {
                uCKhuPho = new UCKhuPho();
                uCKhuPho.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uCKhuPho);
                uCKhuPho.BringToFront();
            }
            else
                uCKhuPho.BringToFront();
        }

        private void controlToTruong_Click(object sender, EventArgs e)
        {
            if (uCToTruong == null)
            {
                uCToTruong = new UCToTruong();
                uCToTruong.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uCToTruong);
                uCToTruong.BringToFront();
            }
            else
                uCToTruong.BringToFront();
        }

        private void controlCSKV_Click(object sender, EventArgs e)
        {
            if (uCCSKV == null)
            {
                uCCSKV = new UCCSKV();
                uCCSKV.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uCCSKV);
                uCCSKV.BringToFront();
            }
            else
                uCCSKV.BringToFront();
        }

        private void controlChuHo_Click(object sender, EventArgs e)
        {
            if (uCChuHo == null)
            {
                uCChuHo = new UCChuHo();
                uCChuHo.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uCChuHo);
                uCChuHo.BringToFront();
            }
            else
                uCChuHo.BringToFront();
        }

        private void controlHGD_Click(object sender, EventArgs e)
        {
            if (uCHoGiaDinh == null)
            {
                uCHoGiaDinh = new UCHoGiaDinh();
                uCHoGiaDinh.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uCHoGiaDinh);
                uCHoGiaDinh.BringToFront();
            }
            else
                uCHoGiaDinh.BringToFront();
        }

        private void controlBackUp_Click(object sender, EventArgs e)
        {
            if (uCBackUp == null)
            {
                uCBackUp = new UCBackUp();
                uCBackUp.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uCBackUp);
                uCBackUp.BringToFront();
            }
            else
                uCBackUp.BringToFront();
        }

        private void controlRestore_Click(object sender, EventArgs e)
        {
            if (uCRestore == null)
            {
                uCRestore = new UCRestore();
                uCRestore.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uCRestore);
                uCRestore.BringToFront();
            }
            else
                uCRestore.BringToFront();
        }
    }
}
