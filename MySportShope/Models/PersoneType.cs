namespace MySportShope.API.Models
{
    public class PersoneType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }



    }
}
