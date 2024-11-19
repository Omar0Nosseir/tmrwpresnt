namespace tmrwpresnt.Models
{
    public class PaymentCard
    {
        public int Id { get; set; }
        public int Cardnumber {  get; set; }
        public string? Cardname { get; set; }
        public DateTime? Expiredate { get; set; }

        public User? Users { get; set; } = new User();

    }
}
