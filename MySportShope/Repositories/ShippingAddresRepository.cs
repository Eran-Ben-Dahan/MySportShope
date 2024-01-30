using MySportShope.API.Context;
using MySportShope.API.Models;

namespace MySportShope.API.Repositories
{
    public class ShippingAddresRepository : RepositoryBase<ShippingAddres>, IShippingAddresRepository
    {
        public ShippingAddresRepository(MainContext _context) : base(_context)
        {
        }
    }




}
