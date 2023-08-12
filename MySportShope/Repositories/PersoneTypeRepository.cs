using MySportShope.API.Context;
using MySportShope.API.Models.DTO;

namespace MySportShope.API.Repositories
{
    public class PersoneTypeRepository : RepositoryBase<PersoneType>, IPersoneTypeRepository
    {
        public PersoneTypeRepository(MainContext _context) : base(_context)
        {
        }
    }




}
