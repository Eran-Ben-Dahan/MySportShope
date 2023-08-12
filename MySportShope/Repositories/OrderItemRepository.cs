using MySportShope.API.Context;
using MySportShope.API.Models.DTO;

namespace MySportShope.API.Repositories
{
    public class OrderItemRepository : RepositoryBase<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(MainContext _context) : base(_context)
        {
        }
    }




}
