using System.ComponentModel.DataAnnotations;

namespace E_Shop.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Product list:")]
        public List<Product>? ProductList { get; set; }
    }
}
