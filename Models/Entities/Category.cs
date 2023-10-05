namespace E_Shop.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product>? ProductList { get; set; }
    }
}
