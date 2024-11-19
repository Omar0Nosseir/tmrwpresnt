using Microsoft.AspNetCore.Mvc;
using System.Xml;
using tmrwpresnt.Dto;
using tmrwpresnt.Repos.CategoryRepos;

namespace tmrwpresnt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController : ControllerBase 
    {
        private readonly ICategoryRepo _catrepo;

        public CategoryController(ICategoryRepo catrepo)
        {
            _catrepo = catrepo;
        }
        [HttpGet]
        public IActionResult Getall()
        {
            return Ok(_catrepo.GetAll());
        }
        [HttpGet("ay sho5a5")]
        public IActionResult Getbyid(int id)
        {
            return Ok(_catrepo.GetById(id));
        }
        [HttpPost]
        public IActionResult Add(CategoryDto catDto)
        {
            _catrepo.Add(catDto);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(CategoryDto catDto)
        {
            _catrepo.Update(catDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _catrepo.Delete(id);
            return Ok();
        }
    }
}
