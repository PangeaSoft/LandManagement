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
    
    public partial class tbventa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbventa()
        {
            this.tboperaciones = new HashSet<tboperaciones>();
        }
    
        public int ven_id { get; set; }
        public System.DateTime ven_fecha_boleto { get; set; }
        public System.DateTime ven_fecha_escritura { get; set; }
        public double ven_precio { get; set; }
        public string ven_escribano { get; set; }
        public double ven_presupuesto { get; set; }
        public string ven_escribania { get; set; }
        public double ven_cobrado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tboperaciones> tboperaciones { get; set; }
    }
}
