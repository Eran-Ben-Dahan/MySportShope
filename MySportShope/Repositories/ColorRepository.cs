using MySportShope.API.Context;
using MySportShope.API.Models;

namespace MySportShope.API.Repositories
{
    public class ColorRepository : RepositoryBase<Color>, IColorRepository
    {
        public ColorRepository(MainContext _context) : base(_context)
        {
        }
    }




}
