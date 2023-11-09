using ProductWebMVC.Models;

namespace ProductWebMVC.Data
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}
