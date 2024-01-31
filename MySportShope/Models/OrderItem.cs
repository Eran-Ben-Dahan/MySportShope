using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace MySportShope.API.Models
{
    public class OrderItem
    {
        public int ID { get; set; }
        public int OrdersID { get; set; }
        public int productID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public Cart Cart { get; set; }
    }
}
