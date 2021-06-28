using Proyecto_POO_BDD.NombreDirectorio;

namespace Proyecto_POO_BDD.viewModel
{
    public static class ciudadMapper
    {
       public static CiudadanoVm mapedCiudadanoVm(Ciudadano e)

        {
            return new CiudadanoVm
            {
                Dui = e.Dui,
                Nombre = e.Nombre,
                DireccionDomicilio = e.DireccionDomicilio,
                Telefono = e.Telefono,
                CorreoElectronico = e.CorreoElectronico,
                Enfermedad = e.Enfermedad,
                Institucion = e.Institucion

            };
        }
    }
}