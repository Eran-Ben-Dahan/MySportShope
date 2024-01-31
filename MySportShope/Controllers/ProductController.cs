using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySportShope.API.Migrations;
using MySportShope.API.Models;
using MySportShope.API.Models.DTO;
using MySportShope.API.Repositories;
using System.IdentityModel.Tokens.Jwt;
using static System.Net.Mime.MediaTypeNames;
using Image = MySportShope.API.Models.Image;

namespace MySportShope.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _repo;
        private readonly ILogger<ProductController> _logger;
        private readonly IProductRepository _productRepo;

        private readonly IUserRepository _userRepo;
        private readonly IImageRepository _ImageRepo;

        private readonly IPersoneTypeRepository _PersoneTypeRepo;


        public ProductController(IProductRepository _repo, IProductRepository productRepo,
            IUserRepository userRepo,
            ILogger<ProductController> logger,

            IImageRepository imageRepo,

            IPersoneTypeRepository personeTypeRepo)
        {
           
                this._repo = _repo ?? throw new ArgumentNullException(nameof(_repo));
                this._userRepo = userRepo;
                this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
                this._productRepo = productRepo ?? throw new ArgumentNullException(nameof(productRepo));
                this._ImageRepo = imageRepo ?? throw new ArgumentNullException(nameof(imageRepo));
                this._PersoneTypeRepo = personeTypeRepo ?? throw new ArgumentNullException(nameof(personeTypeRepo));
        }
        [HttpGet]
        public IActionResult Getall()
        {

            var result = _repo.FindAll().Include(p=>p.Images).Include(p=>p.OrderItems).ToList();
            return Ok(result);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetByID(int id)
        {
            var result = _repo.FindByCodition(u => u.ID == id).FirstOrDefault();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Creatr(Product item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            var result = _repo.Create(item);
            return Created("user", result);
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductDTO item)
        {
            try
            {
                var token = Request.Headers["Authorization"];
                token = token.ToString().Split("Bearer ")[1];
                var decodedToken = new JwtSecurityTokenHandler().ReadJwtToken(token);
                var userId = decodedToken.Claims.First().Value;
                var user = _userRepo.FindByCodition(user => user.ID == int.Parse(userId)).Include(u => u.Cart)
                    .ThenInclude(cart => cart.OrderItems)
                    .ThenInclude(orderItems => orderItems.Product)
                    .ThenInclude(item => item.Images)
                    .FirstOrDefault();

                if (user is null || user.Type != MySportShope.API.Models.Enums.UserType.Admin)
                {
                    return Unauthorized();
                }

                if (item == null)
                {
                    _logger.LogDebug("Item is null.");
                    return BadRequest();
                }

                var newItem = new Product()
                {
                    Name = item.Name,
                    Price = item.Price,
                    Description = item.Description,
                    CategoryID = item.CategoryID,
                    SubCategoryID = item.SubCategoryID,
                    PersoneTypeID = item.PersoneTypeID,
                    AddedOn = DateTime.UtcNow,
                };

                // Check if the DepartmentID is valid by querying your Departments table
                var personeType = _PersoneTypeRepo.FindByCodition(d => d.ID == newItem.PersoneTypeID).FirstOrDefault();

                if (personeType == null)
                {
                    return BadRequest("Invalid DepartmentID. Department does not exist.");
                }

                if (item.Images != null)
                {
                    newItem.Images = new List<Image>();

                    foreach (var ImageDto in item.Images)
                    {
                        var galleryImage = new Image
                        {
                            Title = ImageDto.Title,
                            URL = ImageDto.URL,
                            Alt = ImageDto.Alt,
                            ProductID = newItem.ID,
                        };
                        newItem.Images.Add(galleryImage);
                    }
                }

                var result = _productRepo.Create(newItem);
                return Created("user", result);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                _logger.LogCritical(ex, "An error occurred while creating the item.");

                return StatusCode(500, new
                {
                    Message = "An error occurred while creating the item.",
                    ExceptionMessage = ex.Message,
                    InnerExceptionMessage = ex.InnerException?.Message,
                    StackTrace = ex.StackTrace
                });
            }
        }





        [HttpPut]
        public IActionResult Update(Product item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            var exists = _repo.FindByCodition(u => u.ID == item.ID).Any();
            if (!exists)
            {
                return NotFound();
            }

            _repo.Update(item);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delet(int id)
        {
            var user = _repo.FindByCodition(u => u.ID == id).FirstOrDefault ();
            if (user==null)
            {
                return NotFound();
            }
            _repo.Delete(user);
            return NoContent();
        }


    }
}
