using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_P3.SqlServerContext
{
    public partial class Cita
    {
        public int IdCita { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdentificadorCita { get; set; }
        public int? IdLugar { get; set; }
        public int? IdHora { get; set; }
        public int? IdIdentificador { get; set; }

        public virtual Hora IdHoraNavigation { get; set; }
        public virtual Empleado IdIdentificadorNavigation { get; set; }
        public virtual Lugar IdLugarNavigation { get; set; }
    }
}
