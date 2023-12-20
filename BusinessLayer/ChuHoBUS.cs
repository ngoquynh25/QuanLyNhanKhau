using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ChuHoBUS
    {
        QuanLyNhanKhauEntities context = new QuanLyNhanKhauEntities();

        public tb_ChuHo getItem(int id)
        {
            return context.tb_ChuHo.Where(p => (bool)!p.IsDelete).FirstOrDefault(x => x.IDChuHo == id);
        }

        public List<ChuHoDTO> getListFullCB()
        {
            var lstCH = context.tb_ChuHo.ToList();
            List<ChuHoDTO> lstCHDTO = new List<ChuHoDTO>();
            ChuHoDTO chDTO;

            foreach (var item in lstCH)
            {
                chDTO = new ChuHoDTO();
                chDTO.IDChuHo = item.IDChuHo;
                chDTO.HoTenChuHo = item.HoTenChuHo;
                chDTO.DiaChi = item.DiaChi;
                chDTO.ThongTinLienHe = item.ThongTinLienHe;
                chDTO.ConSong = item.ConSong;
                chDTO.IsDelete = item.IsDelete;

                chDTO.IDKhuPho = item.IDKhuPho;
                var khupho = context.tb_KhuPho.FirstOrDefault(b => b.IDKhuPho == item.IDKhuPho);
                chDTO.TenKhuPho = khupho.TenKhuPho;

                lstCHDTO.Add(chDTO);
            }
            return lstCHDTO;
        }

        public List<ChuHoDTO> getListFull()
        {
            var lstCH = context.tb_ChuHo.Where(p => (bool)!p.IsDelete).ToList();
            List<ChuHoDTO> lstCHDTO = new List<ChuHoDTO>();
            ChuHoDTO chDTO;

            foreach (var item in lstCH)
            {
                chDTO = new ChuHoDTO();
                chDTO.IDChuHo = item.IDChuHo;
                chDTO.HoTenChuHo = item.HoTenChuHo;
                chDTO.DiaChi = item.DiaChi;
                chDTO.ThongTinLienHe = item.ThongTinLienHe;
                chDTO.ConSong = item.ConSong;
                chDTO.IsDelete = item.IsDelete;

                chDTO.IDKhuPho = item.IDKhuPho;
                var khupho = context.tb_KhuPho.FirstOrDefault(b => b.IDKhuPho == item.IDKhuPho);
                chDTO.TenKhuPho = khupho.TenKhuPho;

                lstCHDTO.Add(chDTO);
            }
            return lstCHDTO;
        }

        public tb_ChuHo Add(tb_ChuHo chuho)
        {
            try
            {
                context.sp_ThemChuHo(chuho.IDKhuPho, chuho.HoTenChuHo, chuho.DiaChi, chuho.ThongTinLienHe, chuho.ConSong);
                context.SaveChanges();
                return chuho;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_ChuHo Edit(tb_ChuHo chuho)
        {
            try
            {
                context.sp_ChinhSuaChuHo(chuho.IDChuHo ,chuho.IDKhuPho, chuho.HoTenChuHo, chuho.DiaChi, chuho.ThongTinLienHe, chuho.ConSong);
                context.SaveChanges();
                return chuho;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_ChuHo Remote(tb_ChuHo chuho)
        {
            try
            {
                context.sp_XoaChuHo(chuho.IDChuHo, chuho.IsDelete = true);
                context.SaveChanges();
                return chuho;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
