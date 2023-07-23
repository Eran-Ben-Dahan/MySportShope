namespace MySportShope.API.Models.DTO
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ManufacturerID { get; set; }
        public string TypeID { get; set; }
        public string PersoneType { get; set; }
        public int Size { get; set; }
        public List<Colors> Color { get; set; }
        public string CategoryID { get; set; }
        public  List<Image> Image  { get; set; }
    }
}
