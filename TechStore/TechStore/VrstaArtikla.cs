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
    using System.ComponentModel;
    using System.Linq;

    public partial class VrstaArtikla
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VrstaArtikla()
        {
            this.Artikl = new HashSet<Artikl>();
        }
    
        public int ID { get; set; }
        public string Naziv { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artikl> Artikl { get; set; }

        public static BindingList<VrstaArtikla> DohvatiVrsteArtikala()
        {
            BindingList<VrstaArtikla> vrstaArtikala = null;
            using (TechStoreEntities db = new TechStoreEntities())
            {
                vrstaArtikala = new BindingList<VrstaArtikla>(db.VrstaArtikla.ToList());
            }

            return vrstaArtikala;
        }

    }
}
