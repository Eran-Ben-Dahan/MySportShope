namespace MySportShope.API.Models.DTO
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public  List <SubCategory> SubCategorys { get; set; }

    }
}
