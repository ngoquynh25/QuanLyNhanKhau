using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class CSKVDTO
    {
        public int IDCSKV { get; set; }
        public Nullable<int> IDKhuPho { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public string ThongTinLienHe { get; set; }
        public Nullable<System.DateTime> NgayThamGiaCongTac { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public Nullable<bool> IsDelete { get; set; }

        public string TenKhuPho { get; set; }
    }
}
