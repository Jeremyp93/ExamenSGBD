//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reservation()
        {
            this.DetailReservations = new HashSet<DetailReservation>();
        }
    
        public int idReservation { get; set; }
        public string numeroReservation { get; set; }
        public int idTable { get; set; }
        public System.DateTime date { get; set; }
        public string prenom { get; set; }
        public string nom { get; set; }
        public int nbreDePersonnes { get; set; }
        public Nullable<int> prixTotal { get; set; }
        public int definitif { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailReservation> DetailReservations { get; set; }
        public virtual TablesChaise TablesChaise { get; set; }
    }
}
