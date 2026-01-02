using _Bootstrap.Models;

namespace _Bootstrap.Models
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public string CategoryName { get; set; }
        public bool isInStock { get; set; }
        public string Message { get; set; }
    }
}
