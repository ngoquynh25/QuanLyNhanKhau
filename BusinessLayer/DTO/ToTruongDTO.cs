using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class ToTruongDTO
    {
        public int IDToTruong { get; set; }
        public Nullable<int> IDKhuPho { get; set; }
        public string TenToTruong { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChiCuTru { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public string ThongTinLienHe { get; set; }
        public Nullable<bool> IsDelete { get; set; }

        public string TenKhuPho { get; set; }
    }
}
