using Microsoft.EntityFrameworkCore.ChangeTracking;
using MySportShope.API.Context;
using System.Linq.Expressions;

namespace MySportShope.API.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T: class
    {
        
        private MainContext _context;

        public RepositoryBase(MainContext _context)
        {
            this._context=_context??throw new ArgumentException(nameof(_context));
        }
        public T Create(T item)
        {
            EntityEntry<T> newItem=_context.Set<T>().Add(item);
            Save();
            return newItem.Entity;
        }

        public void Delete(T item)
        {
          _context.Set<T>().Remove(item);
            Save();
        }

        public IQueryable<T> FindAll()
        {
            return _context.Set<T>();
        }

        public IQueryable<T> FindByCodition(Expression<Func<T, bool>> condition)
        {
            return _context.Set<T>().Where(condition);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public T Update(T item)
        {
            EntityEntry<T> updatItem = _context.Set<T>().Update(item);
            Save();
            return updatItem.Entity;
        }
    }

}
