//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppDigitalCv.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUsuarioRol
    {
        public int idRolUsuario { get; set; }
        public int idUsuario { get; set; }
        public int idRol { get; set; }
        public Nullable<System.DateTime> dteFechaAsignacion { get; set; }
    
        public virtual catRoles catRoles { get; set; }
        public virtual catUsuarios catUsuarios { get; set; }
    }
}