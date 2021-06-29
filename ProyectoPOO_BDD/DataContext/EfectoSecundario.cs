using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoPOO_BDD.DataContext
{
    public partial class EfectoSecundario
    {
        public int IdSecundario { get; set; }
        public string EfectoSecundario1 { get; set; }
        public int? IdVacunacion { get; set; }

        public virtual Vacunacion IdVacunacionNavigation { get; set; }
    }
}
