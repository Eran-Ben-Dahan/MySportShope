using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySportShope.API.Migrations;
using MySportShope.API.Models;
using MySportShope.API.Models.DTO;
using MySportShope.API.Repositories;
using static System.Net.Mime.MediaTypeNames;

namespace MySportShope.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _repo;
      

        public ProductController(IProductRepository _repo)
        {
           
            this._repo = _repo ?? throw new ArgumentNullException(nameof(_repo));
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
        //[HttpPost]
        //public IActionResult Creatr( Product item)
        //{
        //    if (item == null)
        //    {
        //        return BadRequest("Invalid data");
        //    }
        //    var newItem = new ProductDTO()
        //    {
        //        ID = item.ID,
        //        Name = item.Name,
        //        Description = item.Description,
        //        Manufacturer = item.Manufacturer,
        //        SubCategoryID = item.SubCategoryID,
        //        SubCategory = item.SubCategory,
        //        Images = item.Images,
        //        PersoneTypeID = item.PersoneTypeID,
        //        Price = item.Price,
        //    };
        //    var createdProduct = _repo.Create(newItem);

            // Assuming createdProduct is the created product, modify the Created method accordingly
        //    return Created( "user", createdProduct);
        //}

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
