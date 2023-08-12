using MySportShope.API.Context;
using MySportShope.API.Models.DTO;

namespace MySportShope.API.Repositories
{
    public class OrdersRepository : RepositoryBase<Orders>, IOrdersRepository
    {
        public OrdersRepository(MainContext _context) : base(_context)
        {
        }
    }




}
