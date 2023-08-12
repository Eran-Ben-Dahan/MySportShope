using MySportShope.API.Context;
using MySportShope.API.Models.DTO;

namespace MySportShope.API.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(MainContext _context) : base(_context)
        {
        }
    }




}
