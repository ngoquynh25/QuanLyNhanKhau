//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_KhuPho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_KhuPho()
        {
            this.tb_CSKV = new HashSet<tb_CSKV>();
            this.tb_ChuHo = new HashSet<tb_ChuHo>();
            this.tb_ToTruongKhuPho = new HashSet<tb_ToTruongKhuPho>();
        }
    
        public int IDKhuPho { get; set; }
        public Nullable<int> IDPhuongXa { get; set; }
        public string TenKhuPho { get; set; }
        public Nullable<int> DanSo { get; set; }
        public string DiaChiTruSoHanhChinh { get; set; }
        public string ThongTinLienHe { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_CSKV> tb_CSKV { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ChuHo> tb_ChuHo { get; set; }
        public virtual tb_PhuongXa tb_PhuongXa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ToTruongKhuPho> tb_ToTruongKhuPho { get; set; }
    }
}
