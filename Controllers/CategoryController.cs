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
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var category = await Service.GetCategoryByIdAsync(id);
            return View(category);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var category = await Service.GetCategoryByIdAsync(id);
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Category category)
        {
            await Service.Edit(category);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var category = await Service.GetCategoryByIdAsync(id);
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Category category)
        {
            await Service.Delete(category);
            return RedirectToAction("Index");
        }
    }
}
