using System;
using System.Collections.Generic;

#nullable disable

namespace finalprojectp4.SqlServerContext
{
    public partial class CabinaxEmpleado
    {
        public int IdCabinaxempleado { get; set; }
        public int? IdCabina { get; set; }
        public int? IdIdentificador { get; set; }

        public virtual Cabina IdCabinaNavigation { get; set; }
        public virtual Empleado IdIdentificadorNavigation { get; set; }
    }
}
