using System.Drawing;

namespace MySportShope.API.Models.DTO
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public IList<PersoneType> PersoneTypes { get; set; }
        public IList<ItemSize> ItemSizesID { get; set; }
        public IList<Color> ColorsID { get; set; }
        public int CategoryID { get; set; }
        public IList<Image> ImagesID  { get; set; }
        public int BoxSizeID { get; set; }
    }
}
