﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDigitalCv.ViewModels
{
    public class AlergiasVM
    {
        public int IdAlergia { get; set; }
        public string StrDescripcion { get; set; }
        public string StrObservacion { get; set; }
        public int IdPersonal { get; set; }
        public int IdTipoAlergia { get; set; }

    }
}