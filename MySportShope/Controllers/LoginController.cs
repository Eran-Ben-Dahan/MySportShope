using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MySportShope.API.Models;
using MySportShope.API.Models.DTO;
using MySportShope.API.Models.Enums;
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
            try
            {
                User user = _userRepo.FindByCodition(u => u.Username == loginInfo.Username && u.Password == loginInfo.Password).FirstOrDefault();
                if (user == null)
                {
                    return Unauthorized();
                }

                var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_config["Authentication:Secret"] ?? throw new ArgumentException("Authentication:Secret")));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var claims = new List<Claim>()
                {
                    new Claim("sub",user.ID.ToString()),
                     new Claim("usertype", user.Type.ToString())
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
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("GetUser")]
        public IActionResult GetUser()
        {
            try
            {
                var token = Request.Headers["Authorization"];
                token = token.ToString().Split("Bearer ")[1];
                var decodedToken = new JwtSecurityTokenHandler().ReadJwtToken(token);
                var userId = decodedToken.Claims.First().Value;
                var userQuery = _userRepo.FindByCodition(user => user.ID == int.Parse(userId)).Include(u => u.Cart)
                    .ThenInclude(cart => cart.OrderItems)
                    .ThenInclude(orderItems => orderItems.Product)
                    .ThenInclude(item => item.Images);

                var user = userQuery.FirstOrDefault();
                return Ok(user);
            }
            catch (Exception ex)
            {

                return StatusCode(500);
            }

        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(LoginInfo registrationInfo)
        {
            // Validate registrationInfo
            if (registrationInfo == null || string.IsNullOrWhiteSpace(registrationInfo.Username) || string.IsNullOrWhiteSpace(registrationInfo.Password))
            {
                return BadRequest("Invalid registration information.");
            }

            // Check if the user already exists
            if (_userRepo.FindByCodition(u => u.Username == registrationInfo.Username).Any())
            {
                return BadRequest("User already exists.");
            }

            // Create a new user
            User newUser = new User
            {
                Username = registrationInfo.Username,
                Password = registrationInfo.Password,
                Type = UserType.Unknown // Or UserType.Admin based on your logic
            };

            // Add the new user to the database
            object value = _userRepo.CreateWith(newUser, (_context) =>
            {
                var cart = new Cart { };
                _context.Cart.Add(cart);
                newUser.Cart = cart;
            });
            _userRepo.Save();

            return Ok("User registered successfully.");


        }
    }
}
