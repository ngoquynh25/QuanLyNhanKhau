using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KhuPhoBUS
    {
        QuanLyNhanKhauEntities context = new QuanLyNhanKhauEntities();

        public tb_KhuPho getItem(int id)
        {
            return context.tb_KhuPho.Where(p => (bool)!p.IsDelete).FirstOrDefault(x => x.IDKhuPho == id);
        }

        public List<KhuPhoDTO> getListFullCB()
        {
            var query = from kp in context.tb_KhuPho
                        join px in context.tb_PhuongXa on kp.IDPhuongXa equals px.IDPhuongXa
                        join q in context.tb_Quan on px.IDQuan equals q.IDQuan
                        select new
                        {
                            KhuPho = kp,
                            PhuongXa_TenPhuong = px.TenPhuong,
                            Quan_TenQuan = q.TenQuan
                        };
            List<KhuPhoDTO> lstKPDTO = new List<KhuPhoDTO>();
            KhuPhoDTO kpDTO;

            foreach (var item in query)
            {
                kpDTO = new KhuPhoDTO();
                kpDTO.IDKhuPho = item.KhuPho.IDKhuPho;
                kpDTO.TenKhuPho = item.KhuPho.TenKhuPho;
                kpDTO.DanSo = item.KhuPho.DanSo;
                kpDTO.DiaChiTruSoHanhChinh = item.KhuPho.DiaChiTruSoHanhChinh;
                kpDTO.ThongTinLienHe = item.KhuPho.ThongTinLienHe;
                kpDTO.IsDelete = item.KhuPho.IsDelete;

                kpDTO.IDPhuongXa = item.KhuPho.IDPhuongXa;
                var phuong = context.tb_PhuongXa.FirstOrDefault(b => b.IDPhuongXa == item.KhuPho.IDPhuongXa);
                kpDTO.TenPhuong = phuong.TenPhuong;

                kpDTO.TenQuan = item.Quan_TenQuan;

                lstKPDTO.Add(kpDTO);
            }
            return lstKPDTO;
        }

        public List<KhuPhoDTO> getListFull()
        {
            var query = from kp in context.tb_KhuPho
                        join px in context.tb_PhuongXa on kp.IDPhuongXa equals px.IDPhuongXa
                        join q in context.tb_Quan on px.IDQuan equals q.IDQuan
                        where kp.IsDelete == false
                        select new
                        {
                            KhuPho = kp,
                            PhuongXa_TenPhuong = px.TenPhuong,
                            Quan_TenQuan = q.TenQuan
                        };
            List<KhuPhoDTO> lstKPDTO = new List<KhuPhoDTO>();
            KhuPhoDTO kpDTO;

            foreach(var item in query)
            {
                kpDTO = new KhuPhoDTO();
                kpDTO.IDKhuPho = item.KhuPho.IDKhuPho;
                kpDTO.TenKhuPho = item.KhuPho.TenKhuPho;
                kpDTO.DanSo = item.KhuPho.DanSo;
                kpDTO.DiaChiTruSoHanhChinh = item.KhuPho.DiaChiTruSoHanhChinh;
                kpDTO.ThongTinLienHe = item.KhuPho.ThongTinLienHe;
                kpDTO.IsDelete = item.KhuPho.IsDelete;

                kpDTO.IDPhuongXa = item.KhuPho.IDPhuongXa;
                var phuong = context.tb_PhuongXa.FirstOrDefault(b => b.IDPhuongXa == item.KhuPho.IDPhuongXa);
                kpDTO.TenPhuong = phuong.TenPhuong;

                kpDTO.TenQuan = item.Quan_TenQuan;

                lstKPDTO.Add(kpDTO);
            }
            return lstKPDTO;
        }

        public tb_KhuPho Add(tb_KhuPho khupho)
        {
            try
            {
                context.sp_ThemKhuPho(khupho.IDPhuongXa, khupho.TenKhuPho, khupho.DanSo, khupho.DiaChiTruSoHanhChinh, khupho.ThongTinLienHe);
                context.SaveChanges();
                return khupho;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_KhuPho Edit(tb_KhuPho khupho)
        {
            try
            {
                context.sp_ChinhSuaKhuPho(khupho.IDKhuPho ,khupho.IDPhuongXa, khupho.TenKhuPho, khupho.DanSo, khupho.DiaChiTruSoHanhChinh, khupho.ThongTinLienHe);
                context.SaveChanges();
                return khupho;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_KhuPho Remote(tb_KhuPho khupho)
        {
            try
            {
                context.sp_XoaKhuPho(khupho.IDKhuPho, khupho.IsDelete = true);
                context.SaveChanges();
                return khupho;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
