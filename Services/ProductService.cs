using E_Shop.Data;
using E_Shop.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_Shop.Services
{
    public class ProductService
    {
        private AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProductListAsync()
        {
            return await _context.Product.ToListAsync();
        }

        public async Task<Product> Create(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
