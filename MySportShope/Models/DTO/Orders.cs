using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace MySportShope.API.Models.DTO
{
    public class Orders
    {
        public int ID  { get; set; }
        public int ClientID { get; set; }
        public int ShippingAddresID { get; set; }
        public DateTime OrderDate { get; set; }
        public int SpecialDiscount{ get; set; }
    }
}
