using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoPOO_BDD.DataContext
{
    public partial class Tipo
    {
        public Tipo()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int IdTipo { get; set; }
        public string Tipo1 { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
