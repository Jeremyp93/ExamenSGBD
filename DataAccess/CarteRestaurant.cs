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
    
    public partial class CarteRestaurant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarteRestaurant()
        {
            this.DetailMenus = new HashSet<DetailMenu>();
        }
    
        public int idCarteRestaurant { get; set; }
        public int idRestaurant { get; set; }
        public int idCarteGroupe { get; set; }
        public int Prix { get; set; }
    
        public virtual CarteGroupe CarteGroupe { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailMenu> DetailMenus { get; set; }
    }
}
