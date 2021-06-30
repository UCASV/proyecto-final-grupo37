using System.Collections.Generic;
using System.Linq;
using Proyecto_POO_BDD.NombreDirectorio;
using Proyecto_POO_BDD.Repositiry;

namespace Proyecto_POO_BDD.servicios
{
     class ServiEmpleado : IRepository<Empleado>
    {
        private Banco_de_datosContext _context;

        public ServiEmpleado()
        {
            _context = new Banco_de_datosContext();
        }
        public void Create(Empleado item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Delete(Empleado item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public List<Empleado> GetAll()
        {
            return _context.Empleados.ToList();
        }

        public void Update(Empleado item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    
    }
}