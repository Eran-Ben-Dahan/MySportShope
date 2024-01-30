using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace MySportShope.API.Models
{
    public class Product
    {
        //[Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public List<ItemSize> ItemSizes { get; set; }
        public List<Color> Colors { get; set; }
        public int SubCategoryID { get; set; }
        public SubCategory SubCategory { get; set; }
        public ICollection<Image> Images { get; set; }
        public List<BoxSize> BoxSizes { get; set; }
        public int PersoneTypeID { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public double Price { get; set; }
    }
}
