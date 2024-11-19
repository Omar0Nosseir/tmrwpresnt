using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using tmrwpresnt.Models;

namespace tmrwpresnt.Dto
{
    public class UserDto
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        //Adding (matching existing data)
        public IList<int> ProductIds { get; set; } = new List<int>();

        //Retreving data & Adding new data

        public IList<ProductDto>? Products { get; set; } = new List<ProductDto>();


        public int CardId { get; set; }
        public PaymentCardDto Card { get; set; } = new PaymentCardDto();

    }
}
