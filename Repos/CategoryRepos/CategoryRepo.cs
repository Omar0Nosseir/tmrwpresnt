using tmrwpresnt.Dto;
using tmrwpresnt.Models;
using tmrwpresnt.Data;
using Microsoft.EntityFrameworkCore;

namespace tmrwpresnt.Repos.CategoryRepos
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly AppDbContext _context;

        public CategoryRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Add(CategoryDto catdto)
        {
            var cat = new Category
            {
                Name = catdto.Name,
                Products = catdto.Products.Select(x => new Product
                {
                    Name = x.Name,
                    price = x.price,
                }).ToList(),
            };
            _context.categories.Add(cat);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var cat = _context.categories.Find(id);
            if (cat != null)
            {
                _context.categories.Remove(cat);
                _context.SaveChanges();
            }
        }

        public List<CategoryDto> GetAll()
        {
            return _context.categories.Include(x => x.Products)
                .Select(x => new CategoryDto
                {
                    Name = x.Name,
                    Products = x.Products.Select(x => new ProductDto
                    {
                        Name = x.Name,
                        price = x.price,
                    }).ToList(),
                }).ToList();
        }

        public CategoryDto? GetById(int id)
        {
            var cat = _context.categories.Find(id);
            if (cat == null)
            {
                return null;
            }
            return new CategoryDto
            {
                Name = cat.Name,
                Products = cat.Products.Select(x => new ProductDto
                {
                    Name = x.Name,
                    price = x.price,
                }).ToList()
            };

        }

        public bool Update(CategoryDto catdto)
        {
            var cat = new Category
            {
                Name = catdto.Name,
                Products = catdto.Products.Select(x => new Product
                {
                    Name = x.Name,
                    price = x.price,

                }).ToList(),
            };
            _context.categories.Update(cat);
            _context.SaveChanges();
            return true;
        }
    }
}

