//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestTemplate.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class coso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public coso()
        {
            this.NHANVIENs = new HashSet<NHANVIEN>();
            this.sans = new HashSet<san>();
        }
    
        public string macs { get; set; }
        public string tencs { get; set; }
        public string hinhanh { get; set; }
        public string diachi { get; set; }
        public string link { get; set; }
        public string mals { get; set; }
    
        public virtual loaisan loaisan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<san> sans { get; set; }
    }
}