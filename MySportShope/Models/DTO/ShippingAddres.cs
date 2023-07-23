namespace MySportShope.API.Models.DTO
{
    public class ShippingAddres
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string StreetName { get; set; }
        public int Building { get; set; }
        public int House { get; set; }
        public int Zip { get; set; }
    }
}
