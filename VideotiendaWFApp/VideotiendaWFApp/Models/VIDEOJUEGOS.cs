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
    
    public partial class VIDEOJUEGOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VIDEOJUEGOS()
        {
            this.ALQ_VIDEOJUEGOS = new HashSet<ALQ_VIDEOJUEGOS>();
            this.CAT_VIDEOJUEGOS = new HashSet<CAT_VIDEOJUEGOS>();
        }
    
        public int NRO_REFERENCIA { get; set; }
        public string NOM_VIDEOJUEGO { get; set; }
        public string IMG_VIDEOJUEGO { get; set; }
        public int ID_PROD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALQ_VIDEOJUEGOS> ALQ_VIDEOJUEGOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAT_VIDEOJUEGOS> CAT_VIDEOJUEGOS { get; set; }
        public virtual PRODUCTORES PRODUCTORES { get; set; }
    }
}
