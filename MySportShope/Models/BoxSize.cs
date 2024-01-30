using System.ComponentModel.DataAnnotations;

namespace MySportShope.API.Models
{

    public class BoxSize
    {
        [Key]
        public int ID { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public int ProductID { get; set; }
    }
}
