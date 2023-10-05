using E_Shop.Models.Entities;
using E_Shop.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_Shop.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryService Service;

        public CategoryController(CategoryService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var list = await Service.GetCategoryListAsync();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            await Service.Create(category);
            return View(category);
        }
    }
}
