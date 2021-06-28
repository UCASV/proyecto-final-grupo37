using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_BDD.NombreDirectorio
{
    public partial class EfectoSecundario
    {
        public int IdSecundario { get; set; }
        public string EfectoSecundario1 { get; set; }
        public int? IdVacunacion { get; set; }

        public virtual Vacunacion IdVacunacionNavigation { get; set; }
    }
}
