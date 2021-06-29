using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoPOO_BDD.DataContext
{
    public partial class Cabina
    {
        public Cabina()
        {
            CabinaxEmpleados = new HashSet<CabinaxEmpleado>();
        }

        public int IdCabina { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public virtual ICollection<CabinaxEmpleado> CabinaxEmpleados { get; set; }
    }
}
