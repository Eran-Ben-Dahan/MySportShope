using MySportShope.API.Models.Enums;

namespace MySportShope.API.Models.DTO
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
        public DateTime LastLogin { get; set; }
        public int ClientID { get; set; }
    }
}
