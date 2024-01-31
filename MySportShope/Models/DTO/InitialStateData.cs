using MySportShope.API.Migrations;
using MySportShope.API.Models;
using MySportShope.API.Repositories;

namespace API.Models.DTO
{
    internal class InitialStateData
    {

        private InitialStateData()
        {

        }

        public List<Cart> Cart { get; private set; }
        public List<Category> Categories { get; private set; }
        public List<Client> Client { get; private set; }
        public List<PersoneType> PersoneType { get; private set; }
        public List<Image> Image { get; private set; }
        public List<Orders> Orders { get; private set; }
        public List<OrderItem> GrderItem { get; private set; }
        public List<Product> Products { get; private set; }
        public List<SubCategory> SubCategories { get; private set; }
        internal static InitialStateData Create(

            ICartRepository cartRepository,
            ICategoryRepository categoryRepo,
            IClientRepository clientrRepo,
            IPersoneTypeRepository PersoneTypeRepo,
            IImageRepository ImageRepo,
            IOrdersRepository ordersRepo,
            IOrderItemRepository orderItemRepo,
            IProductRepository productRepo,      
            ISubCategoryRepository subCategoryRepo
            )
        {
            InitialStateData initialStateData = new InitialStateData();

            initialStateData.Cart = cartRepository.FindAll().ToList();
            initialStateData.Categories = categoryRepo.FindAll().ToList();
            initialStateData.Client = clientrRepo.FindAll().ToList();
            initialStateData.PersoneType=PersoneTypeRepo.FindAll().ToList();
            initialStateData.Image = ImageRepo.FindAll().ToList();
            initialStateData.GrderItem = orderItemRepo.FindAll().ToList();
            
            return initialStateData;
        }
    }
}