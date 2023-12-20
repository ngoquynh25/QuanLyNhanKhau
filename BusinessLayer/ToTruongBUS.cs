using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ToTruongBUS
    {
        QuanLyNhanKhauEntities context = new QuanLyNhanKhauEntities();

        public tb_ToTruongKhuPho getItem(int id)
        {
            return context.tb_ToTruongKhuPho.Where(p => (bool)!p.IsDelete).FirstOrDefault(x => x.IDToTruong == id);
        }

        public List<ToTruongDTO> getListFull()
        {
            var lstTT = context.tb_ToTruongKhuPho.Where(p => (bool)!p.IsDelete).ToList();
            List<ToTruongDTO> lstTTDTO = new List<ToTruongDTO>();
            ToTruongDTO ttDTO;

            foreach(var item in lstTT)
            {
                ttDTO = new ToTruongDTO();
                ttDTO.IDToTruong = item.IDToTruong;
                ttDTO.TenToTruong = item.TenToTruong;
                ttDTO.NgaySinh = item.NgaySinh;
                ttDTO.GioiTinh = item.GioiTinh;
                ttDTO.DiaChiCuTru = item.DiaChiCuTru;
                ttDTO.NgayBatDau = item.NgayBatDau;
                ttDTO.TrangThai = item.TrangThai;
                ttDTO.ThongTinLienHe = item.ThongTinLienHe;
                ttDTO.IsDelete = item.IsDelete;

                ttDTO.IDKhuPho = item.IDKhuPho;
                var khupho = context.tb_KhuPho.FirstOrDefault(b => b.IDKhuPho == item.IDKhuPho);
                ttDTO.TenKhuPho = khupho.TenKhuPho;

                lstTTDTO.Add(ttDTO);
            }
            return lstTTDTO;
        }

        public tb_ToTruongKhuPho Add(tb_ToTruongKhuPho totruong)
        {
            try
            {
                context.sp_ThemToTruongKhuPho(totruong.IDKhuPho, totruong.TenToTruong, totruong.NgaySinh, totruong.GioiTinh, totruong.DiaChiCuTru, totruong.NgayBatDau, totruong.TrangThai, totruong.ThongTinLienHe);
                context.SaveChanges();
                return totruong;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_ToTruongKhuPho Edit(tb_ToTruongKhuPho totruong)
        {
            try
            {
                context.sp_ChinhSuaToTruongKhuPho(totruong.IDToTruong ,totruong.IDKhuPho, totruong.TenToTruong, totruong.NgaySinh, totruong.GioiTinh, totruong.DiaChiCuTru, totruong.NgayBatDau, totruong.TrangThai, totruong.ThongTinLienHe);
                context.SaveChanges();
                return totruong;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_ToTruongKhuPho Remote(tb_ToTruongKhuPho totruong)
        {
            try
            {
                context.sp_XoaToTruongKhuPho(totruong.IDToTruong, totruong.IsDelete = true);
                context.SaveChanges();
                return totruong;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

    }
}
