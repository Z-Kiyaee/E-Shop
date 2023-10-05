using E_Shop.Data;
using E_Shop.Models.Entities;
using Microsoft.EntityFrameworkCore;

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

        public async Task<Category> Create(Category category)
        {
            _context.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }
    }
}
