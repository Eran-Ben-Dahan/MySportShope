using System.Diagnostics;

namespace MySportShope.API.Models.DTO
{
    public class OrderItem
    {
        public string OrdersID { get; set; }
        public Product product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
