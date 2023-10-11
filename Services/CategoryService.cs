using E_Shop.Data;
using E_Shop.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace E_Shop.Services
{
    public class CategoryService
    {
        private AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetCategoryListAsync()
        {
            return await _context.Category.ToListAsync();
        }

        public async Task Create(Category category)
        {
            _context.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task<Category?> GetCategoryByIdAsync(int id)
        {
            return await _context.Category.Include(e => e.ProductList).SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task Edit(Category category)
        {
            var updatedCategory = await _context.Category.SingleOrDefaultAsync(e => e.Id == category.Id);
            updatedCategory.Name = category.Name;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Category category)
        {
            _context.Category.Remove(category);
            await _context.SaveChangesAsync();
        }
    }
}
