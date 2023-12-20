using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class PhuongXaDTO
    {
        public int IDPhuongXa { get; set; }
        public Nullable<int> IDQuan { get; set; }
        public string TenPhuong { get; set; }
        public Nullable<int> DanSo { get; set; }
        public Nullable<double> DienTich { get; set; }
        public string DiaChiTruSoHanhChinh { get; set; }
        public string ThongTinLienHe { get; set; }
        public Nullable<bool> IsDelete { get; set; }

        public string TenQuan { get; set; }
    }
}
