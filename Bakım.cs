//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bakım
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bakım()
        {
            this.Islems = new HashSet<Islem>();
        }
    
        public int BakımID { get; set; }
        public Nullable<int> AracID { get; set; }
        public Nullable<System.DateTime> GirisTarihi { get; set; }
        public Nullable<System.DateTime> CıkısTarihi { get; set; }
        public Nullable<int> ToplamTutar { get; set; }
        public string OdemeTuru { get; set; }
    
        public virtual Arac Arac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Islem> Islems { get; set; }
    }
}
