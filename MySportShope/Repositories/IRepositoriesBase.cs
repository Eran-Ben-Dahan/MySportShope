using Microsoft.EntityFrameworkCore.ChangeTracking;
using MySportShope.API.Context;
using System.Linq.Expressions;

namespace MySportShope.API.Repositories
{
    public interface IRepositoriesBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCodition(Expression<Func<T, bool>> condition);
        T Create(T item); 
        T Update(T item);
        void Delete(T item);
        void Save();
    }

}
