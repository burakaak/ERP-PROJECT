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
    
    public partial class GorevDetayTb
    {
        public int Id { get; set; }
        public Nullable<int> Gorev { get; set; }
        public string Aciklama { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string Saat { get; set; }
    
        public virtual GorevTb GorevTb { get; set; }
    }
}
