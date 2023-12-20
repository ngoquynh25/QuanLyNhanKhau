using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class PhuongXaBUS
    {
        QuanLyNhanKhauEntities context = new QuanLyNhanKhauEntities();

        public tb_PhuongXa getItem(int id)
        {
            return context.tb_PhuongXa.Where(p => (bool)!p.IsDelete).FirstOrDefault(x => x.IDPhuongXa == id);
        }

        public List<PhuongXaDTO> getListFull()
        {
            var lstPX = context.tb_PhuongXa.Where(p => (bool)!p.IsDelete).ToList();
            List<PhuongXaDTO> lstPXDTO = new List<PhuongXaDTO>();
            PhuongXaDTO pxDTO;

            foreach(var item in lstPX)
            {
                pxDTO = new PhuongXaDTO();
                pxDTO.IDPhuongXa = item.IDPhuongXa;
                pxDTO.TenPhuong = item.TenPhuong;
                pxDTO.DanSo = item.DanSo;
                pxDTO.DienTich = item.DienTich;
                pxDTO.DiaChiTruSoHanhChinh = item.DiaChiTruSoHanhChinh;
                pxDTO.ThongTinLienHe = item.ThongTinLienHe;
                pxDTO.IsDelete = item.IsDelete;

                pxDTO.IDQuan = item.IDQuan;
                var quan = context.tb_Quan.FirstOrDefault(b => b.IDQuan == item.IDQuan);
                pxDTO.TenQuan = quan.TenQuan;

                lstPXDTO.Add(pxDTO);
            }
            return lstPXDTO;
        }

        public tb_PhuongXa Add(tb_PhuongXa phuong)
        {
            try
            {
                context.sp_ThemPhuongXa(phuong.IDQuan, phuong.TenPhuong, phuong.DanSo, phuong.DienTich, phuong.DiaChiTruSoHanhChinh, phuong.ThongTinLienHe);
                context.SaveChanges();
                return phuong;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_PhuongXa Edit(tb_PhuongXa phuong)
        {
            try
            {
                context.sp_ChinhSuaPhuongXa(phuong.IDPhuongXa ,phuong.IDQuan, phuong.TenPhuong, phuong.DanSo, phuong.DienTich, phuong.DiaChiTruSoHanhChinh, phuong.ThongTinLienHe);
                context.SaveChanges();
                return phuong;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_PhuongXa Remote(tb_PhuongXa phuong)
        {
            try
            {
                context.sp_XoaPhuongXa(phuong.IDPhuongXa, phuong.IsDelete = true);
                context.SaveChanges();
                return phuong;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
