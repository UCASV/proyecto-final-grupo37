using System.Collections.Generic;

namespace Proyecto_POO_BDD.Repositiry
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        void Create(T item);

        void Delete(T item);

        void Update(T item);
    }
}