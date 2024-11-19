using tmrwpresnt.Models;

namespace tmrwpresnt.Dto
{
    public class PaymentCardDto
    {
        public int Id { get; set; }
        public int Cardnumber { get; set; }
        public string? Cardname { get; set; }
        public DateTime? Expiredate { get; set; }

        public UserDto? User { get; set; } = new UserDto();
    }
}
