using MySportShope.API.Models.DTO;
using MySportShope.API.Repositories;

namespace MySportShope.API.Models
{
    internal class InitalStateData
    {
        private InitalStateData()
        {
        }

        public List<BoxSize> BoxSize { get; private set; }
        public List<Category> Category { get; private set; }
        public List<Client> Clien { get; private set; }
        public List<Color> Color { get; private set; }
        public List<Image> Image { get; private set; }
        public List<ItemSize> ItemSize { get; private set; }
        public List<OrderItem> OrderItem { get; private set; }
        public List<Orders> Orders { get; private set; }
        public List<Payment> Payment { get; private set; }
        public List<PersoneType> PersoneType { get; private set; }
        public List<Product> Product { get; private set; }
        public List<ShippingAddres> ShippingAddres { get; private set; }
        public List<SubCategory> SubCategory { get; private set; }

        internal static InitalStateData Create(
            IBoxSizeRepository boxSizeRepository,
            ICategoryRepository categoryRepository,
            IClientRepository clientRepository,
            IColorRepository colorRepository,
            IImageRepository imageRepository,
            IItemSizeRepository itemSizeRepository,
            IOrderItemRepository orderItemRepository,
            IOrdersRepository ordersRepository,
            IPaymentRepository paymentRepository,
            IPersoneTypeRepository personeTypeRepository,
            IProductRepository productRepository,
            IShippingAddresRepository shippingAddresRepository,
            ISubCategoryRepository subCategoryRepository)
        {

            InitalStateData initalStateData = new InitalStateData();

            initalStateData.BoxSize = boxSizeRepository.FindAll().ToList();
            initalStateData.Category = categoryRepository.FindAll().ToList();
            initalStateData.Clien = clientRepository.FindAll().ToList();
            initalStateData.Color = colorRepository.FindAll().ToList();
            initalStateData.Image = imageRepository.FindAll().ToList();
            initalStateData.ItemSize = itemSizeRepository.FindAll().ToList();
            initalStateData.OrderItem = orderItemRepository.FindAll().ToList();
            initalStateData.Orders = ordersRepository.FindAll().ToList();
            initalStateData.Payment = paymentRepository.FindAll().ToList();
            initalStateData.PersoneType = personeTypeRepository.FindAll().ToList();
            initalStateData.Product = productRepository.FindAll().ToList();
            initalStateData.ShippingAddres = shippingAddresRepository.FindAll().ToList();
            initalStateData.SubCategory = subCategoryRepository.FindAll().ToList();


            return initalStateData;
        }

    }
}