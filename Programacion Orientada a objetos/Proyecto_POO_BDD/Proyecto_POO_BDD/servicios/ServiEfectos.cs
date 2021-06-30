using System.Collections.Generic;
using System.Linq;
using Proyecto_POO_BDD.NombreDirectorio;
using Proyecto_POO_BDD.Repositiry;

namespace Proyecto_POO_BDD.servicios
{
     class ServiEfectos: IRepository<EfectoSecundario>
    {
        private Banco_de_datosContext _context;

        public ServiEfectos()
        {
            _context = new Banco_de_datosContext();
        }
        public void Create(EfectoSecundario item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Delete(EfectoSecundario item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public List<EfectoSecundario> GetAll()
        {
            return _context.EfectoSecundarios.ToList();
        }

        public void Update(EfectoSecundario item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}