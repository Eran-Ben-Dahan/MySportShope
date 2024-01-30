using MySportShope.API.Context;
using MySportShope.API.Models;

namespace MySportShope.API.Repositories
{
    public class BoxSizeRepository : RepositoryBase<BoxSize>, IBoxSizeRepository
    {
        public BoxSizeRepository(MainContext _context) : base(_context)
        {
        }
    }




}
