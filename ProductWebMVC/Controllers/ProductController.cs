using Microsoft.AspNetCore.Mvc;
using ProductWebMVC.Data;
using ProductWebMVC.Models;

namespace ProductWebMVC.Controllers
{
    public class ProductController : Controller
    {
        ProductContext ctx;

        public ProductController(ProductContext context)
        {
            ctx = context;
        }
        public IActionResult Index()
        {
            ViewData["products"] = ctx.Products.ToList();

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product p)
        {
            ctx.Products.Add(p);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
