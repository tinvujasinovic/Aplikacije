//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MilkyApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class korisnici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public korisnici()
        {
            this.biljeske = new HashSet<biljeske>();
            this.zadaci = new HashSet<zadaci>();
        }
    
        public int korisnik_ID { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public decimal OIB { get; set; }
        public System.DateTime datum_rodenja { get; set; }
        public string ulica_i_kucni_broj { get; set; }
        public string grad { get; set; }
        public string strucna_sprema { get; set; }
        public string zanimanje { get; set; }
        public string telefon { get; set; }
        public string radno_mjesto { get; set; }
        public string broj_racuna { get; set; }
        public byte vlasnik { get; set; }
        public string email { get; set; }
        public string lozinka { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<biljeske> biljeske { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zadaci> zadaci { get; set; }
    }
}
