//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KhoaLuanTotNghiep
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_KhoNoiBo
    {
        public long ID { get; set; }
        public Nullable<long> IDKhoNB { get; set; }
        public string TenKho { get; set; }
        public Nullable<System.DateTime> NgayBD { get; set; }
        public Nullable<System.DateTime> NgayXuat { get; set; }
        public string DiaDiemKho { get; set; }
        public Nullable<long> IDHH { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<int> SoNgay { get; set; }
        public Nullable<double> TrongLuong { get; set; }
        public Nullable<double> ThanhTien { get; set; }
        public Nullable<long> IDKH { get; set; }
    
        public virtual tbl_HangHoa tbl_HangHoa { get; set; }
        public virtual tbl_KhachHanga tbl_KhachHanga { get; set; }
    }
}
