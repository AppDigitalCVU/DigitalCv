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
    
    public partial class tblEnfermedadPersonal
    {
        public int idEnfermedadPersonal { get; set; }
        public int idEnfermedad { get; set; }
        public int idPersonal { get; set; }
        public Nullable<System.DateTime> dteFechaRegistro { get; set; }
    
        public virtual catEnfermedad catEnfermedad { get; set; }
        public virtual tblPersonal tblPersonal { get; set; }
    }
}