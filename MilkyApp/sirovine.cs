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
    
    public partial class sirovine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sirovine()
        {
            this.dobavlja = new HashSet<dobavlja>();
        }
    
        public int sirovina_ID { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }
        public int raspolozivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dobavlja> dobavlja { get; set; }
    }
}
