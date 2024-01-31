using MySportShope.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MySportShope.API.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Username name must be at least 3 chars")]
        [MaxLength(50, ErrorMessage = "Username name must be less then 50 chars")]
        public string Username { get; set; }


        [Required]
        [MinLength(8, ErrorMessage = "The Password must be at least 8 chars")]
        [MaxLength(50, ErrorMessage = "The Password must be less then 50 chars")]
        public string Password { get; set; }
        public UserType Type { get; set; }
        public DateTime LastLogin { get; set; }
        public int ClientID { get; set; }
        public Cart Cart { get; set; }
    }
}
