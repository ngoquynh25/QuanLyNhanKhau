using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CSKVBUS
    {
        QuanLyNhanKhauEntities context = new QuanLyNhanKhauEntities();

        public tb_CSKV getItem(int id)
        {
            return context.tb_CSKV.Where(p => (bool)!p.IsDelete).FirstOrDefault(x => x.IDCSKV == id);
        }

        public List<CSKVDTO> getListFull()
        {
            var lstCS = context.tb_CSKV.Where(p => (bool)!p.IsDelete).ToList();
            List<CSKVDTO> lstCSDTO = new List<CSKVDTO>();
            CSKVDTO csDTO;

            foreach (var item in lstCS)
            {
                csDTO = new CSKVDTO();
                csDTO.IDCSKV = item.IDCSKV;
                csDTO.HoTen = item.HoTen;
                csDTO.ChucVu = item.ChucVu;
                csDTO.ThongTinLienHe = item.ThongTinLienHe;
                csDTO.NgayThamGiaCongTac = item.NgayThamGiaCongTac;
                csDTO.TrangThai = item.TrangThai;

                csDTO.IDKhuPho = item.IDKhuPho;
                var khupho = context.tb_KhuPho.FirstOrDefault(b => b.IDKhuPho == item.IDKhuPho);
                csDTO.TenKhuPho = khupho.TenKhuPho;

                lstCSDTO.Add(csDTO);
            }
            return lstCSDTO;
        }

        public tb_CSKV Add(tb_CSKV cskv)
        {
            try
            {
                context.sp_ThemCSKV(cskv.IDKhuPho, cskv.HoTen, cskv.ChucVu, cskv.ThongTinLienHe, cskv.NgayThamGiaCongTac, cskv.TrangThai);
                context.SaveChanges();
                return cskv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_CSKV Edit(tb_CSKV cskv)
        {
            try
            {
                context.sp_ChinhSuaCSKV(cskv.IDCSKV ,cskv.IDKhuPho, cskv.HoTen, cskv.ChucVu, cskv.ThongTinLienHe, cskv.NgayThamGiaCongTac, cskv.TrangThai);
                context.SaveChanges();
                return cskv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_CSKV Remote(tb_CSKV cskv)
        {
            try
            {
                context.sp_XoaCSKV(cskv.IDCSKV, cskv.IsDelete = true);
                context.SaveChanges();
                return cskv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
