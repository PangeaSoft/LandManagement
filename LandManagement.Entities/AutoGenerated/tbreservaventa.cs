//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LandManagement.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbreservaventa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbreservaventa()
        {
            this.tboperaciones = new HashSet<tboperaciones>();
        }
    
        public int rev_id { get; set; }
        public double rev_oferta { get; set; }
        public string rev_observaciones { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tboperaciones> tboperaciones { get; set; }
    }
}
