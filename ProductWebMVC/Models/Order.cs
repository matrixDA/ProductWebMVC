namespace ProductWebMVC.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
}
