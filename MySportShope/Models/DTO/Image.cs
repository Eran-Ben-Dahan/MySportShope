namespace MySportShope.API.Models.DTO
{
    public class Image
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string Alt { get; set; }
        public string Title { get; set; }
    }
}
