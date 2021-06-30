using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_P3.SqlServerContext
{
    public partial class EmpleadoxCiudadano
    {
        public int IdEmpleadoxciudadano { get; set; }
        public int? IdIdentificador { get; set; }
        public int? DuiCiudadano { get; set; }

        public virtual Ciudadano DuiCiudadanoNavigation { get; set; }
        public virtual Empleado IdIdentificadorNavigation { get; set; }
    }
}
