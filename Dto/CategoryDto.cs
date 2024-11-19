using tmrwpresnt.Models;

namespace tmrwpresnt.Dto
{
    public class CategoryDto
    {
        public string? Name { get; set; }

        //Adding
        public List<int> ProductIds { get; set; } = new List<int>();
        //Retreving
        public IList<ProductDto> Products { get; set; } = new List<ProductDto>();

    }
}
