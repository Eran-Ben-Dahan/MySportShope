using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using MySportShope.API.Models;
using MySportShope.API.Repositories;

namespace MySportShope.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InitalStateController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IBoxSizeRepository boxSizeRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IClientRepository clientRepository;
        private readonly IColorRepository colorRepository;
        private readonly IImageRepository imageRepository;
        private readonly IItemSizeRepository itemSizeRepository;
        private readonly IOrderItemRepository orderItemRepository;
        private readonly IOrdersRepository ordersRepository;
        private readonly IPaymentRepository PaymentRepository;
        private readonly IPersoneTypeRepository personeTypeRepository;
        private readonly IProductRepository productRepository;
        private readonly IShippingAddresRepository shippingAddresRepository;
        private readonly ISubCategoryRepository subCategoryRepository;
        private readonly IUserRepository _userRepo;

        public InitalStateController(IConfiguration _config,
            IBoxSizeRepository boxSizeRepository,
            ICategoryRepository categoryRepository,
            IClientRepository clientRepository,
            IColorRepository colorRepository,
            IImageRepository imageRepository,
            IItemSizeRepository itemSizeRepository,
            IOrderItemRepository orderItemRepository,
            IOrdersRepository ordersRepository,
            IPaymentRepository PaymentRepository,
            IPersoneTypeRepository personeTypeRepository,
            IProductRepository productRepository,
            IShippingAddresRepository shippingAddresRepository,
            ISubCategoryRepository subCategoryRepository
            )
        {
            this._config = _config ?? throw new ArgumentNullException(nameof(_config));
            this.boxSizeRepository = boxSizeRepository ?? throw new ArgumentNullException(nameof(boxSizeRepository));
            this.categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
            this.clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            this.colorRepository = colorRepository ?? throw new ArgumentNullException(nameof(colorRepository));
            this.imageRepository = imageRepository ?? throw new ArgumentNullException(nameof(imageRepository));
            this.itemSizeRepository = itemSizeRepository ?? throw new ArgumentNullException(nameof(itemSizeRepository));
            this.orderItemRepository = orderItemRepository ?? throw new ArgumentNullException(nameof(orderItemRepository));
            this.ordersRepository = ordersRepository ?? throw new ArgumentNullException(nameof(ordersRepository));
            this.PaymentRepository = PaymentRepository ?? throw new ArgumentNullException(nameof(PaymentRepository));
            this.personeTypeRepository = personeTypeRepository ?? throw new ArgumentNullException(nameof(personeTypeRepository));
            this.productRepository=productRepository??throw new ArgumentNullException(nameof(productRepository));
            this.shippingAddresRepository = shippingAddresRepository ?? throw new ArgumentNullException(nameof(shippingAddresRepository));
            this.subCategoryRepository = subCategoryRepository ?? throw new ArgumentNullException(nameof(subCategoryRepository));
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            InitalStateData result = InitalStateData.Create(
           boxSizeRepository,
           categoryRepository,
           clientRepository,
           colorRepository,
           imageRepository,
           itemSizeRepository,
           orderItemRepository,
           ordersRepository,
           PaymentRepository,
           personeTypeRepository,
           productRepository,
           shippingAddresRepository,
           subCategoryRepository
                );
            return Ok(result);
        }
    }
}

