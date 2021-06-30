using System.Collections.Generic;
using System.Linq;
using Proyecto_POO_BDD.NombreDirectorio;
using Proyecto_POO_BDD.Repositiry;

namespace Proyecto_POO_BDD.servicios
{
     class ServiEnfermedades : IRepository<Enfermedad>
    {
        private Banco_de_datosContext _context;

        public ServiEnfermedades()
        {
            _context = new Banco_de_datosContext();
        }
        public void Create(Enfermedad item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Delete(Enfermedad item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public List<Enfermedad> GetAll()
        {
            return _context.Enfermedads.ToList();
        }

        public void Update(Enfermedad item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}