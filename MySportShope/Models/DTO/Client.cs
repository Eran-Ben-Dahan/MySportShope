namespace MySportShope.API.Models.DTO
{
    public class Client
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BDay { get; set; }
        public int PhoneNumber { get; set; }
        public List<Orders> Orders { get; set; }
    }
}
