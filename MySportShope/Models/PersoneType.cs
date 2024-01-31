using System.ComponentModel.DataAnnotations;

namespace MySportShope.API.Models
{
    public class PersoneType
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }



    }
}
