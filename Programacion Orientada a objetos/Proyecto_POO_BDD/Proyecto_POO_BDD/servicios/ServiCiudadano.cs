using System.Collections.Generic;
using System.Linq;
using Proyecto_POO_BDD.NombreDirectorio;
using Proyecto_POO_BDD.Repositiry;

namespace Proyecto_POO_BDD.servicios
{
     class ServiCiudadano : IRepository<Ciudadano>
    {
        private Banco_de_datosContext _context;

        public ServiCiudadano()
        {
            _context = new Banco_de_datosContext();
        }
        public void Create(Ciudadano item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Delete(Ciudadano item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public List<Ciudadano> GetAll()
        {
            return _context.Ciudadanos.ToList();
        }

        public void Update(Ciudadano item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}