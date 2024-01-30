using MySportShope.API.Context;
using MySportShope.API.Models;

namespace MySportShope.API.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(MainContext _context) : base(_context)
        {
        }
    }




}
