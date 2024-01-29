namespace MySportShope.API.Models.DTO
{
    public class SubCategory
    {
        public int ID { get; set; }
        public List<Product> Products { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public Category? Category { get; set; }

    }
}
