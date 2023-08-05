using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace MySportShope.API.Models.DTO
{
    public class OrderItem
    {
        public int OrdersID { get; set; }
        public int productID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
