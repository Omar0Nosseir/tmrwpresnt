using System.ComponentModel.DataAnnotations.Schema;

namespace tmrwpresnt.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double price { get; set; }

        public IList<User> Users { get; set; } = new List<User>();


        [ForeignKey(nameof(category.Id))]
        public int CatId {  get; set; } 
        public Category? category { get; set; } = new Category();

    }
}
