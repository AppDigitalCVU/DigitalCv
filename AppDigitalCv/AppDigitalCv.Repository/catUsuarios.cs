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
    
    public partial class catUsuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public catUsuarios()
        {
            this.tblPersonal = new HashSet<tblPersonal>();
            this.tblUsuarioRol = new HashSet<tblUsuarioRol>();
        }
    
        public int idUsuario { get; set; }
        public string strEmailInstitucional { get; set; }
        public string strNombrUsuario { get; set; }
        public string strPassword { get; set; }
        public System.DateTime dteFechaRegistro { get; set; }
        public int idStatus { get; set; }
    
        public virtual catStatus catStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPersonal> tblPersonal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUsuarioRol> tblUsuarioRol { get; set; }
    }
}