using MySportShope.API.Context;
using MySportShope.API.Models.DTO;

namespace MySportShope.API.Repositories
{
    public class ImageRepository : RepositoryBase<Image>, IImageRepository
    {
        public ImageRepository(MainContext _context) : base(_context)
        {
        }
    }




}
