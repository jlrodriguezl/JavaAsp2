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
    
    public partial class CAT_VIDEOJUEGOS
    {
        public int ID_CAT_VIDEOJUEGO { get; set; }
        public int ID_CATEGORIA { get; set; }
        public int NRO_REFERENCIA { get; set; }
    
        public virtual CATEGORIAS CATEGORIAS { get; set; }
        public virtual VIDEOJUEGOS VIDEOJUEGOS { get; set; }
    }
}
