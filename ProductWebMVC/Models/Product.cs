namespace ProductWebMVC.Models
{
    public class Product
    {

        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string GetText()
        {
            return $"{Id} \t {Price} \t {Description}";
        }

    }
}
