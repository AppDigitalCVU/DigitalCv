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
    
    public partial class tblDatosLaboralesDocente
    {
        public int idDatosLaboralesDocente { get; set; }
        public Nullable<System.DateTime> dteFechaInicio { get; set; }
        public int idProgramaEducativo { get; set; }
        public int idTipoContrato { get; set; }
        public int idPersonal { get; set; }
        public int idCuerpoAcademico { get; set; }
        public int idEdificio { get; set; }
        public int idUnidadesAcademicas { get; set; }
        public string strObjetivoPersonal { get; set; }
        public string strNumeroExtencion { get; set; }
        public decimal dcmSalarioHoras { get; set; }
    
        public virtual catCuerpoAcademico catCuerpoAcademico { get; set; }
        public virtual catEdificio catEdificio { get; set; }
        public virtual catProgramaEducativo catProgramaEducativo { get; set; }
        public virtual catTipoContrato catTipoContrato { get; set; }
        public virtual catUnidadesAcademicas catUnidadesAcademicas { get; set; }
        public virtual tblPersonal tblPersonal { get; set; }
    }
}
