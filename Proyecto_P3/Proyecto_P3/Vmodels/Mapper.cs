using System;
using Proyecto_P3.Entitys.Ciudadanos;
using Proyecto_P3.SqlServerContext;

namespace Proyecto_P3.Vmodels
{
    public static  class CiudadanoMapper
    {
       public static CiudadanoVm mapCiudadanotoCiudadanoVm(Ciudadano1 e)
        {
            return new CiudadanoVm
            {
                Dui = Convert.ToInt32(e.Dui),
                Nombre = e.Name,
                DireccionDomicilio = e.Direction,
                Telefono = e.Cellphone,
                CorreoElectronico = e.Email


            };
        }
    }
}