using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_P3.SqlServerContext
{
    public partial class Hora
    {
        public Hora()
        {
            Cita = new HashSet<Cita>();
        }

        public int IdHora { get; set; }
        public TimeSpan? Hora1 { get; set; }

        public virtual ICollection<Cita> Cita { get; set; }
    }
}
