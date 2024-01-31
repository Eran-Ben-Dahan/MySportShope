using MySportShope.API.Models;

namespace MySportShope.API.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        void CreateWith(User newUser, Action<object> value);
    }
}
