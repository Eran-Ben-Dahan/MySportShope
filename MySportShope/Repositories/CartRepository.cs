using MySportShope.API.Context;
using MySportShope.API.Models;
using MySportShope.API.Repositories;

namespace MyProject.API.Repositories.Implementation
{
    public class CartRepository : RepositoryBase<Cart>, ICartRepository
    {
        public CartRepository(MainContext context) : base(context)
        {
            
        }
    }
}
