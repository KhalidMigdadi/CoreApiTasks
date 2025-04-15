using AngularCoreAPIApp.Server.ReuestDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularCoreAPIApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly AngularCoreAPIApp.Server.IDataService.IDataService _data;


        public CategoryController(AngularCoreAPIApp.Server.IDataService.IDataService data)
        {
            _data = data;
        }

        [HttpGet]
        public IActionResult GetAllCategory()
        {
            var cat = _data.GetAllCategory();

            return Ok(cat); // status is 200 => every thing is OK

        }


        [HttpGet("{id:int:min(2)}")] // catById/{id} // it will show in the URL 
        public IActionResult GetCategoryById(int id)
        {
            var categoryID = _data.GetCategoryById(id);

            if (categoryID == null)
            {
                return NotFound(); // status 404
            }

            return Ok(categoryID); // status 200 
        }


        [HttpGet("FirstCat")]
        public IActionResult GetFirstCategory()
        {
            var categoryID = _data.GetCategoryById;

            if (categoryID == null)
            {
                return NotFound();
            }

            return Ok(categoryID);
        }



        [HttpGet("{name:alpha:minlength(3)}")]
        public IActionResult GetCategoryByName(string name)
        {
            var categoryName = _data.GetCategoryByName(name);

            if (categoryName == null)
            {
                return NotFound();
            }

            return Ok(categoryName);
        }


        [HttpDelete("deleteCategory/{id}")]
        public IActionResult deleteCategory(int id)
        {
            var category = _data.deleteCategory(id);
            if (category != false)
            {

                return Ok();
            }
            return NotFound();

        }

        [HttpPost("add")]
        public IActionResult AddCategory([FromBody] ReqDTO category)
        {
            if (category == null)
                return BadRequest();

            _data.AddCategory(category);
            return StatusCode(201, category);
        }

        [HttpPut]
        public IActionResult updateCategory(int id, [FromForm] ReqDTO category)
        {
            if (category == null)
                return BadRequest();

            _data.updateCategory(id, category);
            return Ok(category);
        }





    }
}
