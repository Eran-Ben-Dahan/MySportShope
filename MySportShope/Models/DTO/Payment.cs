namespace MySportShope.API.Models.DTO
{
    public class Payment
    {
        public int ID { get; set; }
        public DateTime PaymentDate { get; set; }
        public int CardNumber { get; set; }
        public int CardMonth { get; set; }
        public int CardYear { get; set; }
        public int CardCvv { get; set; }

    }
}
