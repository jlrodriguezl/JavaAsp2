//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideotiendaWFApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERSONAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERSONAS()
        {
            this.ALQUILER = new HashSet<ALQUILER>();
        }
    
        public decimal NRO_DOC { get; set; }
        public string TIPO_DOC { get; set; }
        public string NOMBRES { get; set; }
        public decimal CELULAR { get; set; }
        public string CORREO { get; set; }
        public string DIRECCION { get; set; }
        public string TIPO_PERSONA { get; set; }
        public string CONTRASENA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALQUILER> ALQUILER { get; set; }
    }
}
