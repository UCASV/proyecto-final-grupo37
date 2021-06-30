using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_P3.SqlServerContext
{
    public partial class Ciudadano
    {
        public Ciudadano()
        {
            EmpleadoxCiudadanos = new HashSet<EmpleadoxCiudadano>();
            Enfermedads = new HashSet<Enfermedad>();
        }

        public int Dui { get; set; }
        public string Nombre { get; set; }
        public string DireccionDomicilio { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public int? IdVacunacion { get; set; }
        public int? IdIdentificador { get; set; }

        public virtual Identificador IdIdentificadorNavigation { get; set; }
        public virtual Vacunacion IdVacunacionNavigation { get; set; }
        public virtual ICollection<EmpleadoxCiudadano> EmpleadoxCiudadanos { get; set; }
        public virtual ICollection<Enfermedad> Enfermedads { get; set; }
    }
}
