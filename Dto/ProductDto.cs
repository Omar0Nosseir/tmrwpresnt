using System.ComponentModel.DataAnnotations.Schema;
using tmrwpresnt.Models;

namespace tmrwpresnt.Dto
{
    public class ProductDto
    {
        public string? Name { get; set; }
        public double price { get; set; }

        public IList<UserDto>? Users { get; set; } = new List<UserDto>();


        public int CatId { get; set; }
        public CategoryDto? category { get; set; } = new CategoryDto();
    }
}
