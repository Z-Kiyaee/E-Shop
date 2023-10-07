using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace E_Shop.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
