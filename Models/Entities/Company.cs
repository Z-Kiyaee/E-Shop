using System.ComponentModel.DataAnnotations;

namespace E_Shop.Models.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Rate Rate { get; set; }
        public List<Product>? ProductList { get; set; }
        public List<User>? UserList { get; set; }

    }
}
