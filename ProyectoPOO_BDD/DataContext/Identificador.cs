using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoPOO_BDD.DataContext
{
    public partial class Identificador
    {
        public Identificador()
        {
            Ciudadanos = new HashSet<Ciudadano>();
        }

        public int IdNumero { get; set; }
        public int? NumeroIdentificador { get; set; }

        public virtual ICollection<Ciudadano> Ciudadanos { get; set; }
    }
}
