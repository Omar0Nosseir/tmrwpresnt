using tmrwpresnt.Dto;

namespace tmrwpresnt.Repos.CategoryRepos
{
    public interface ICategoryRepo
    {
         CategoryDto? GetById(int id);
         List<CategoryDto> GetAll();

         void Add(CategoryDto catdto);
         bool Update(CategoryDto catdto);
         void Delete(int id); 
    }
}
