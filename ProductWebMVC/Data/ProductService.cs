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

        public int? AddProduct(Product p)
        {
           var product = this.GetProductById(p.Id);

            if (product != null) 
            {
                return null;
            }
            ctx.Products.Add(p);
            return ctx.SaveChanges();
        }


        public List<Product> GetAllProducts()
        {
            return ctx.Products.ToList();
        }

        public Product GetProductById(int Id)
        {
            return ctx.Products.FirstOrDefault(x => x.Id == Id);
        }

        public int? RemoveProductById(int id)
        {
            var product = this.GetProductById(id);
            if (product == null)
            {
                return null;
            }
            ctx.Products.Remove(product);
            return ctx.SaveChanges();
        }

        public int? UpdateProduct(Product p)
        {
            ctx.Products.Update(p); 
            return ctx.SaveChanges();
        }
    }
}
