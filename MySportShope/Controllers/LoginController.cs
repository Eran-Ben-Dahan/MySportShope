using Microsoft.AspNetCore.Mvc;
using MySportShope.API.Models;

namespace MySportShope.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : Controller
    {

        [HttpGet]
        public IActionResult GetToken(LoginInfo loginInfo)
        {
            return Ok();
        }

    }
}
