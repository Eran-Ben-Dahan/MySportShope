using Microsoft.AspNetCore.Authentication;
using System.Diagnostics;

namespace MySportShope.API.Models.DTO
{
    public class Orders
    {
        public int ID  { get; set; }
        public string ClientID { get; set; }
        public string ShippingAddresID { get; set; }
        public DateTime OrderDate { get; set; }
        public int SpecialDiscount{ get; set; }
    }
}
