//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLSinhVienHunre
{
    using System;
    using System.Collections.Generic;
    
    public partial class MonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonHoc()
        {
            this.LopHocPhan = new HashSet<LopHocPhan>();
            this.PhanChiaMonHoc = new HashSet<PhanChiaMonHoc>();
        }
    
        public string maMonHoc { get; set; }
        public string tenMonHoc { get; set; }
        public Nullable<int> soTinChi { get; set; }
        public Nullable<int> namBatDau { get; set; }
        public string quyDinh { get; set; }
        public string moTaMonHoc { get; set; }
        public string hinhThucDanhGia { get; set; }
        public int idMonHoc { get; set; }
    
        public virtual HinhThuc HinhThuc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHocPhan> LopHocPhan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanChiaMonHoc> PhanChiaMonHoc { get; set; }
    }
}
