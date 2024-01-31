using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace MySportShope.API.Models
{
    public class Orders
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public int ShippingAddresID { get; set; }
        public int PaymentID { get; set; }
        public DateTime OrderDate { get; set; }
        public int SpecialDiscount { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public Cart Cart { get; set; }
        public int CartID { get; set; }

    }
}
