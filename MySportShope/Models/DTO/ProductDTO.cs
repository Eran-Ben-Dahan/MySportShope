namespace MySportShope.API.Models.DTO
{
    public class ProductDTO
    {
        //[Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public int SubCategoryID { get; set; }
        public SubCategory SubCategory { get; set; }
        public ICollection<Image> Images { get; set; }
        public int PersoneTypeID { get; set; }
        public double Price { get; set; }
        public int ProductID { get; set; }
        public int CategoryID { get; internal set; }
     
    }
}
