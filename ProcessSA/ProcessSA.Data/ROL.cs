//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProcessSA.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ROL
    {
        public ROL()
        {
            this.USUARIOS = new HashSet<USUARIOS>();
        }
    
        public decimal ID_ROL { get; set; }
        public string DESCRIPCION_ROL { get; set; }
    
        public virtual ICollection<USUARIOS> USUARIOS { get; set; }
    }
}