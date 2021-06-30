using System.Collections.Generic;
using System.Linq;
using Proyecto_POO_BDD.NombreDirectorio;
using Proyecto_POO_BDD.Repositiry;

namespace Proyecto_POO_BDD.servicios
{
    class ServiCabina : IRepository<Cabina>
    {
        private Banco_de_datosContext _context;

        public ServiCabina()
        {
            _context = new Banco_de_datosContext();
        }
        public void Create(Cabina item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Delete(Cabina item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public List<Cabina> GetAll()
        {
            return _context.Cabinas.ToList();
        }

        public void Update(Cabina item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}