using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class KhuPhoDTO
    {
        public int IDKhuPho { get; set; }
        public Nullable<int> IDPhuongXa { get; set; }
        public string TenKhuPho { get; set; }
        public Nullable<int> DanSo { get; set; }
        public string DiaChiTruSoHanhChinh { get; set; }
        public string ThongTinLienHe { get; set; }
        public Nullable<bool> IsDelete { get; set; }

        public string TenPhuong { get; set; }
        public string TenQuan { get; set; }
    }
}
