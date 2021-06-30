using System;
using System.Collections.Generic;

#nullable disable

namespace finalprojectp4.SqlServerContext
{
    public partial class Enfermedad
    {
        public int IdEnfermedad { get; set; }
        public string Enfermedad1 { get; set; }
        public int? DuiCiudadano { get; set; }

        public virtual Ciudadano DuiCiudadanoNavigation { get; set; }
    }
}
