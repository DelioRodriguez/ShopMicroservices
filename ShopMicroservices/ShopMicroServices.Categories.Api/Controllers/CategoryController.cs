using Microsoft.AspNetCore.Mvc;
using ShopMicroservices.Categories.Domain.Interfaces;

namespace ShopMicroServices.Categories.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoriesRepository categoriesRepository;

        public CategoryController(ICategoriesRepository categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }
        
        //GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Value1", "Value2" };
        }
        //GET: api/<CategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        //POST: api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }
        //PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }
        
        //DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
        }
        
        

    }
}