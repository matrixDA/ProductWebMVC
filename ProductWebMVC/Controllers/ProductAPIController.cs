using Microsoft.AspNetCore.Mvc;
using ProductWebMVC.Data;

namespace ProductWebMVC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductAPIController : Controller
    {
        IProductService ctx;

        public ProductAPIController(IProductService product) 
        {
            ctx = product;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ctx.GetAllProducts());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetProductById(id));
        }
    }
}
