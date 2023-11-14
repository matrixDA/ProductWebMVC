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
        public List<Product> GetAllProducts()
        {
            return ctx.Products.ToList();
        }

        public Product GetProductById(int Id)
        {
            return ctx.Products.FirstOrDefault(x => x.Id == Id);
        }
    }
}
