using Microsoft.AspNetCore.Mvc;
using MySportShope.API.Models.DTO;
using MySportShope.API.Repositories;

namespace MySportShope.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IUserRepository _userRepo;

        public UserController(IConfiguration _config, IUserRepository _userRepo)
        {
            this._config = _config ?? throw new ArgumentNullException(nameof(_config));
            this._userRepo = _userRepo ?? throw new ArgumentNullException(nameof(_userRepo));
        }
        [HttpGet]
        public IActionResult Getall()
        {
            var result = _userRepo.FindAll().ToList();
            return Ok(result);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetByID(int id)
        {
            var result = _userRepo.FindByCodition(u => u.ID == id).FirstOrDefault();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Creatr(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            var result = _userRepo.Create(user);
            return Created("user", user);
        }
        [HttpPut]
        public IActionResult Update(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            var exists = _userRepo.FindByCodition(u => u.ID == user.ID).Any();
            if (!exists)
            {
                return NotFound();
            }

            _userRepo.Update(user);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delet(int id)
        {
            var user = _userRepo.FindByCodition(u => u.ID == id).FirstOrDefault ();
            if (user==null)
            {
                return NotFound();
            }
            _userRepo.Delete(user);
            return NoContent();
        }


    }
}
