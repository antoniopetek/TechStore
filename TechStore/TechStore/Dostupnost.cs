//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dostupnost
    {
        public int ID { get; set; }
        public int Artikl_ID { get; set; }
        public int Poslovnica_ID { get; set; }
        public int Kolicina { get; set; }
    
        public virtual Artikl Artikl { get; set; }
        public virtual Poslovnica Poslovnica { get; set; }
    }
}
