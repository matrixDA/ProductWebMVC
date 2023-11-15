using Microsoft.AspNetCore.Mvc;
using ProductWebMVC.Data;
using ProductWebMVC.Models;

namespace ProductWebMVC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductAPIController : Controller
    {
        IProductService ctx;

        public ProductAPIController(IProductService context) 
        {
            ctx = context;
        }

        [HttpGet]
        [Route("api/getproducts")]
        public IActionResult Get()
        {
            return Ok(ctx.GetAllProducts());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetProductById(id));
        }

        [HttpPost]
        public IActionResult Post(Product p)
        {
            var result = ctx.AddProduct(p);
            if (result == null)
            {
                return StatusCode(500, "A Product with this ID already exists!");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Product p)
        {
            var result = ctx.UpdateProduct(p);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();  
        }

        [HttpDelete("id")]
        [Route("api/delete")]
        public IActionResult Delete(int id)
        {
            var product = ctx.GetProductById(id);
            if (product == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveProductById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
    }
}
