using MySportShope.API.Context;
using MySportShope.API.Models;

namespace MySportShope.API.Repositories
{
    public class OrderItemRepository : RepositoryBase<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(MainContext _context) : base(_context)
        {
        }
    }




}
