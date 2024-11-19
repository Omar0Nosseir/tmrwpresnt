using Microsoft.EntityFrameworkCore;
using tmrwpresnt.Models;

namespace tmrwpresnt.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> users { get; set; }
        public DbSet<Category> categories {  get; set; }
        public DbSet<Product> products {  get; set; }
        public DbSet<PaymentCard> payemntcards {  get; set; }
        

    }
}
