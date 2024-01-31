using MySportShope.API.Context;
using System.Linq.Expressions;

namespace MySportShope.API.Repositories
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCodition(Expression<Func<T, bool>> condition);
      
        public delegate void CreateWithDelegate(MainContext context);
        Task<T> CreateWith(T item, CreateWithDelegate beforeSave);
        T Create(T item); 
        T Update(T item);
        void Delete(T item);
        void Save();
    }

}
