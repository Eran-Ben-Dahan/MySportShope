using MySportShope.API.Context;
using MySportShope.API.Models;

namespace MySportShope.API.Repositories
{
    public class ItemSizeRepository : RepositoryBase<ItemSize>, IItemSizeRepository
    {
        public ItemSizeRepository(MainContext _context) : base(_context)
        {
        }
    }




}
