using ProductWebMVC.Models;

namespace ProductWebMVC.Data
{
    public interface IProductService
    {
        int? AddProduct(Product p);
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        int? RemoveProductById(int id);
        int? UpdateProduct(Product p);
    }
}
