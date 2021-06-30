using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_P3.SqlServerContext
{
    public partial class Lugar
    {
        public Lugar()
        {
            Cita = new HashSet<Cita>();
        }

        public int IdLugar { get; set; }
        public string Lugar1 { get; set; }

        public virtual ICollection<Cita> Cita { get; set; }
    }
}
