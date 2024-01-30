using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySportShope.API.Models;
using MySportShope.API.Repositories;

namespace MySportShope.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersoneTypeController : Controller
    {
        private readonly ILogger<PersoneTypeController> _logger;
        private readonly IPersoneTypeRepository _repo;
      

        public PersoneTypeController(IPersoneTypeRepository _repo,ILogger<PersoneTypeController>_logger)
        {


            this._logger = _logger ?? throw new ArgumentNullException(nameof(_logger));

            this._repo = _repo ?? throw new ArgumentNullException(nameof(_repo));
        }
        //[HttpGet]
        //public IActionResult Getall()
        //{
        //    var result = _repo.FindAll().ToList();
        //    return Ok(result);
        //}

        [HttpGet]
        public IActionResult Getall()
        {
            try
            {
                var result = _repo
                    .FindAll()
                    .Include(x => x.Products)
                    .ThenInclude(x => x.SubCategory)
                    .ThenInclude(x => x.Category)
                    .Select(PersoneType => new
                    {
                        PersoneType.ID,
                        PersoneType.Name,
                        categories = PersoneType.Products
                            .Select(p => p.SubCategory.Category)
                            .Distinct()
                            .Select(c => new
                            {
                                id = c.ID,
                                name = c.Name,
                                subcategories = c.SubCategorys.Select(sc =>
                                new
                                {
                                    id = sc.ID,
                                    name = sc.Name,
                                    products = sc.Products.Select(p => new
                                    {
                                        id = p.ID,
                                        name = p.Name,
                                        price = p.Price,
                                        PersoneType = p.PersoneTypeID,
                                        galleryImage = p.Images,
                                    })
                                })
                            })
                            .ToList()
                    })
                    .ToList();

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"{ex.Message}", ex);
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult GetByID(int id)
        {
            //var result = _repo.FindByCodition(u => u.ID == id).FirstOrDefault();
            //return Ok(result);

            var result = _repo.FindByCodition(u => u.ID == id).FirstOrDefault();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Creatr(PersoneType item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            var result = _repo.Create(item);
            return Created("user", result);
        }
        [HttpPut]
        public IActionResult Update(PersoneType item)
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
