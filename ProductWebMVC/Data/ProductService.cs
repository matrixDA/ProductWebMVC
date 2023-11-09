using ProductWebMVC.Models;

namespace ProductWebMVC.Data
{
    public class ProductService : IProductService
    {
        ProductContext ctx;
        public ProductService(ProductContext context)
        {
            ctx = context;
        }
        List<Product> IProductService.GetAllProducts()
        {
            return ctx.Products.ToList();
        }

        Product IProductService.GetProductById(int Id)
        {
            return ctx.Products.FirstOrDefault(x => x.Id == Id);
        }
    }
}
