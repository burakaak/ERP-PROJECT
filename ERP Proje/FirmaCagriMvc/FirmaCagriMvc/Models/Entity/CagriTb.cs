//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirmaCagriMvc.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CagriTb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CagriTb()
        {
            this.CagriDetayTb = new HashSet<CagriDetayTb>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Musteri { get; set; }
        public string Konu { get; set; }
        public string Aciklama { get; set; }
        public Nullable<bool> Durum { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        public virtual MusteriTb MusteriTb { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CagriDetayTb> CagriDetayTb { get; set; }
    }
}
