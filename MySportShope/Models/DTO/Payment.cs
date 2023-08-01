namespace MySportShope.API.Models.DTO
{
    public class Payment
    {
        public int Id { get; set; }
        public List<Orders> Orders { get; set; }
        public DateTime PaymentDate { get; set; }

        //Need to add more information like 3 num on back card

    }
}
