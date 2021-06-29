using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoPOO_BDD.DataContext
{
    public partial class Lugar
    {
        public Lugar()
        {
            Cita = new HashSet<Citum>();
        }

        public int IdLugar { get; set; }
        public string Lugar1 { get; set; }

        public virtual ICollection<Citum> Cita { get; set; }
    }
}
