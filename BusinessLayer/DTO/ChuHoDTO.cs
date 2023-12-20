using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class ChuHoDTO
    {
        public int IDChuHo { get; set; }
        public Nullable<int> IDKhuPho { get; set; }
        public string HoTenChuHo { get; set; }
        public string DiaChi { get; set; }
        public string ThongTinLienHe { get; set; }
        public Nullable<bool> ConSong { get; set; }
        public Nullable<bool> IsDelete { get; set; }

        public string TenKhuPho { get; set; }
    }
}
