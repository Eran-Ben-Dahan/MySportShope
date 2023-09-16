using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MySportShope.API.Models;
using MySportShope.API.Models.DTO;
using MySportShope.API.Repositories;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MySportShope.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IUserRepository _userRepo;

        public LoginController(IConfiguration _config, IUserRepository _userRepo)
        {
            this._config = _config ?? throw new ArgumentNullException(nameof(_config));
            this._userRepo = _userRepo ?? throw new ArgumentNullException(nameof(_userRepo));
        }

        [HttpPost]
        public IActionResult GetToken(LoginInfo loginInfo)
        {

            if (loginInfo == null || string.IsNullOrEmpty(loginInfo.Username) || string.IsNullOrEmpty(loginInfo.Password))
            {
                return BadRequest();
            }
            User user = _userRepo.FindByCodition(u => u.Username == loginInfo.Username && u.Password == loginInfo.Password).FirstOrDefault();
            if (user == null)
            {
                return Unauthorized();
            }

            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_config["Authentication:Secret"] ?? throw new ArgumentException("Authentication:Secret")));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>()
            {
                new Claim("sub",user.ID.ToString())
            };

            string ValidAudience = _config["Authentication:Audience"] ?? throw new ArgumentException("Authentication:Audience");
            string ValidIssuer = _config["Authentication:Issuer"] ?? throw new ArgumentException("Authentication:Issuer");

            var token = new JwtSecurityToken(
                ValidIssuer,
                ValidAudience,
                claims,
                DateTime.UtcNow,
                  DateTime.UtcNow.AddDays(1),
                  creds
                );
            var tokenStr = new JwtSecurityTokenHandler().WriteToken(token);
            return Ok(tokenStr);
        }
    }
}
