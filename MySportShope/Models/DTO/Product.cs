using System.Drawing;

namespace MySportShope.API.Models.DTO
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public string PersoneType { get; set; }
        public List<ItemSize> ItemSizesID { get; set; }
        public List<Color> ColorsID { get; set; }
        public int CategoryID { get; set; }
        public List<Image> ImagesID  { get; set; }
        public int BoxSizeID { get; set; }
    }
}
