using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_BDD.NombreDirectorio
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
