using Microsoft.AspNetCore.Mvc;
using ProductWebMVC.Data;

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
