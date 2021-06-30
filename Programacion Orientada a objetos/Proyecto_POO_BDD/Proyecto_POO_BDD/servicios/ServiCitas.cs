using System.Collections.Generic;
using System.Linq;
using Proyecto_POO_BDD.NombreDirectorio;
using Proyecto_POO_BDD.Repositiry;

namespace Proyecto_POO_BDD.servicios
{ 
    class ServiCitas : IRepository<Citum>
    {
        private Banco_de_datosContext _context;

        public ServiCitas()
        {
            _context = new Banco_de_datosContext();
        }
        public void Create(Citum item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Delete(Citum item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public List<Citum> GetAll()
        {
            return _context.Cita.ToList();
        }

        public void Update(Citum item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
    }
