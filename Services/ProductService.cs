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
            return await _context.Product.Include(e => e.Category).ToListAsync();
        }

        public async Task Create(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _context.Product.Include(e => e.Category).SingleOrDefaultAsync(e => e.Id == id);
        }
        public async Task Edit(Product product)
        {
            var updatedProduct = await _context.Product.SingleOrDefaultAsync(e => e.Id == product.Id);
            updatedProduct.Name = product.Name;
            updatedProduct.Price = product.Price;
            updatedProduct.CategoryId = product.CategoryId;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Product product)
        {
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}
