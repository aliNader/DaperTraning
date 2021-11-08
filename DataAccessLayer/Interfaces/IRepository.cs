using System.Collections.Generic;

namespace DataAccessLayer.Interfaces
{
    public interface IRepository<T> where T :class
    {
        IEnumerable<T> Query(string where = null);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
