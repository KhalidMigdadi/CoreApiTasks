using AngularCoreAPIApp.Server.ReuestDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularCoreAPIApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AngularCoreAPIApp.Server.IDataService.IDataService _data;


        public ProductController(AngularCoreAPIApp.Server.IDataService.IDataService data)
        {
            _data = data;
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            var products = _data.GetAllProduct();

            return Ok(products);
        }





        [HttpGet("productId")]
        public IActionResult GetProductById(int id)
        {
            var productById = _data.GetProductById(id);

            if (productById == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(productById);
            }

        }


        [HttpDelete("deleteProduct")]
        public IActionResult deleteProduct(int id)
        {
            var product = _data.deleteProduct(id);
            if (product != false)
            {

                return Ok();
            }
            return NotFound();

        }


        [HttpPost("add")]
        public IActionResult AddProduct([FromBody] ReqDTO product)
        {
            if (product == null)
                return BadRequest();

            _data.AddProduct(product);
            return StatusCode(201, product);
        }


        [HttpPut]
        public IActionResult updateProduct(int id, [FromForm] ReqDTO product)
        {
            if (product == null)
                return BadRequest();

            _data.updateProduct(id, product);
            return Ok(product);
        }

    }
}
