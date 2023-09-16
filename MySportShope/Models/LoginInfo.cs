using System.ComponentModel.DataAnnotations;

namespace MySportShope.API.Models
{
    public class LoginInfo
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}