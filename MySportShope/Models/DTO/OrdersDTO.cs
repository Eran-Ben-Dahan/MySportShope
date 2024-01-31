using System.ComponentModel.DataAnnotations;

namespace MySportShope.API.Models.DTO
{
    public class OrdersDTO
    {
        public int ID { get; set; } 
        public DateTime OrderDate { get; set; }
        public bool PaymentID { get; set; }
        public int ClientID { get; set; }
        public int CartID { get; set; }
        public int ShippingAddressID { get; set; }
        public List<OrderItem> OrderItems { get; set; }

    }
}

