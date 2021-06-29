using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoPOO_BDD.DataContext
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
