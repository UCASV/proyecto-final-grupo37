using System;
using System.Collections.Generic;

#nullable disable

namespace finalprojectp4.SqlServerContext
{
    public partial class Vacunacion
    {
        public Vacunacion()
        {
            Ciudadanos = new HashSet<Ciudadano>();
            EfectoSecundarios = new HashSet<EfectoSecundario>();
        }

        public int IdVacunacion { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public DateTime? FechaSalida { get; set; }
        public TimeSpan? Tiempo { get; set; }

        public virtual ICollection<Ciudadano> Ciudadanos { get; set; }
        public virtual ICollection<EfectoSecundario> EfectoSecundarios { get; set; }
    }
}
