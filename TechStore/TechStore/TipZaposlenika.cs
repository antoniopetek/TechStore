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

    /// <summary>
    /// Klasa TipZaposlenika
    /// </summary>
    public partial class TipZaposlenika
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipZaposlenika()
        {
            this.Zaposlenik = new HashSet<Zaposlenik>();
        }
    
        public int ID { get; set; }
        public string Naziv { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zaposlenik> Zaposlenik { get; set; }


        /// <summary>
        /// Metoda koja dohva�a sve tipove zaposlenika iz baze.
        /// </summary>
        /// <returns>Vra�a listu u kojoj se nalaze svi tipovi zaposlenika.</returns>
        public static BindingList<TipZaposlenika> DohvatiTipoveZaposlenika()
        {
            BindingList<TipZaposlenika> tipoviZaposlenika = null;
            using (TechStoreEntities db = new TechStoreEntities())
            {
                tipoviZaposlenika = new BindingList<TipZaposlenika>(db.TipZaposlenika.ToList());
            }

            return tipoviZaposlenika;
        }
    }
}
