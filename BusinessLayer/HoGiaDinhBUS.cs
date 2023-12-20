using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class HoGiaDinhBUS
    {
        QuanLyNhanKhauEntities context = new QuanLyNhanKhauEntities();

        public tb_HoGiaDinh getItem(int id)
        {
            return context.tb_HoGiaDinh.Where(p => (bool)!p.IsDelete).FirstOrDefault(x => x.IDHoGiaDinh == id);
        }

        public List<tb_HoGiaDinh> getList()
        {
            return context.tb_HoGiaDinh.Where(p => (bool)!p.IsDelete).ToList();
        }

        public tb_HoGiaDinh Add(tb_HoGiaDinh hogiadinh)
        {
            try
            {
                context.sp_ThemHoGiaDinh(hogiadinh.IDChuHo, hogiadinh.HoTen, hogiadinh.NgheNghiep, hogiadinh.GioiTinh, hogiadinh.QuanHeChuHo, hogiadinh.ConSong);
                context.SaveChanges();
                return hogiadinh;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_HoGiaDinh Edit(tb_HoGiaDinh hogiadinh)
        {
            try
            {
                context.sp_ChinhSuaHoGiaDinh(hogiadinh.IDHoGiaDinh ,hogiadinh.IDChuHo, hogiadinh.HoTen, hogiadinh.NgheNghiep, hogiadinh.GioiTinh, hogiadinh.QuanHeChuHo, hogiadinh.ConSong);
                context.SaveChanges();
                return hogiadinh;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_HoGiaDinh Remote(tb_HoGiaDinh hogiadinh)
        {
            try
            {
                context.sp_XoaHoGiaDinh(hogiadinh.IDHoGiaDinh, hogiadinh.IsDelete = true);
                context.SaveChanges();
                return hogiadinh;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
