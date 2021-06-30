﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_BDD.NombreDirectorio
{
    public partial class Hora
    {
        public Hora()
        {
            Cita = new HashSet<Citum>();
        }

        public int IdHora { get; set; }
        public TimeSpan? Hora1 { get; set; }

        public virtual ICollection<Citum> Cita { get; set; }
    }
}
