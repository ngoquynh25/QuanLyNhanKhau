using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class QuanBUS
    {
        QuanLyNhanKhauEntities context = new QuanLyNhanKhauEntities();

        public List<tb_Quan> getAllQuan()
        {
            return context.tb_Quan.Where(p => (bool)!p.IsDelete).ToList();
        }

        public List<tb_Quan> getAllQuanCB()
        {
            return context.tb_Quan.ToList();
        }

        public tb_Quan getItem(int id)
        {
            return context.tb_Quan.Where(p => (bool)!p.IsDelete).FirstOrDefault(x => x.IDQuan == id);
        }

        public tb_Quan Add(tb_Quan quan)
        {
            try
            {
                context.sp_ThemQuan(quan.TenQuan, quan.ThanhPho_Tinh, quan.DanSo, quan.DienTich, quan.DiaChiKhuPhoHanhChinh, quan.ThongTinLienHe);
                context.SaveChanges();
                return quan;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_Quan Edit(tb_Quan quan)
        {
            try
            {
                context.sp_ChinhSuaQuan(quan.IDQuan ,quan.TenQuan, quan.ThanhPho_Tinh, quan.DanSo, quan.DienTich, quan.DiaChiKhuPhoHanhChinh, quan.ThongTinLienHe);
                context.SaveChanges();
                return quan;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_Quan Remote(tb_Quan quan)
        {
            try
            {
                context.sp_XoaQuan(quan.IDQuan, quan.IsDelete = true);
                context.SaveChanges();
                return quan;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
