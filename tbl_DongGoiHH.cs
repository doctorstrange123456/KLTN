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
    
    public partial class tbl_DongGoiHH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_DongGoiHH()
        {
            this.tbl_HangHoa = new HashSet<tbl_HangHoa>();
        }
    
        public long ID { get; set; }
        public string HinhThucDongGoi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_HangHoa> tbl_HangHoa { get; set; }
    }
}
