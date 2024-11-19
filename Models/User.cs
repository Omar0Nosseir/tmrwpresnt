using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tmrwpresnt.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public IList<Product> Products { get; set; } = new List<Product>();

        [ForeignKey(nameof(Card.Id))]
        public int CardId { get; set; }
        public PaymentCard Card { get; set; } = new PaymentCard();


    }
}
