using System.Collections.Generic;
using System.Linq;
using Proyecto_POO_BDD.NombreDirectorio;
using Proyecto_POO_BDD.Repositiry;

namespace Proyecto_POO_BDD.servicios
{ 
    class ServiciudadanoXVacunacion : IRepository<Vacunacion>
    {
        private Banco_de_datosContext _context;

        public ServiciudadanoXVacunacion()
        {
            _context = new Banco_de_datosContext();
        }
        public void Create(Vacunacion item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Delete(Vacunacion item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public List<Vacunacion> GetAll()
        {
            return _context.Vacunacions.ToList();
        }

        public void Update(Vacunacion item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}