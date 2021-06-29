using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoPOO_BDD.DataContext
{
    public partial class Empleado
    {
        public Empleado()
        {
            CabinaxEmpleados = new HashSet<CabinaxEmpleado>();
            Cita = new HashSet<Citum>();
            EmpleadoxCiudadanos = new HashSet<EmpleadoxCiudadano>();
        }

        public int IdIdentificador { get; set; }
        public string Nombre { get; set; }
        public string CorreoInstitucional { get; set; }
        public string DireccionVivienda { get; set; }
        public string Usuario { get; set; }
        public string Contasena { get; set; }
        public int? IdTipo { get; set; }

        public virtual Tipo IdTipoNavigation { get; set; }
        public virtual ICollection<CabinaxEmpleado> CabinaxEmpleados { get; set; }
        public virtual ICollection<Citum> Cita { get; set; }
        public virtual ICollection<EmpleadoxCiudadano> EmpleadoxCiudadanos { get; set; }
    }
}
