using E_Shop.Models.Entities;
using E_Shop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_Shop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService Service;
        private readonly CategoryService categoryService;

        public ProductController(ProductService service, CategoryService categoryService)
        {
            Service = service;
            this.categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await Service.GetProductListAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var allCategories = await categoryService.GetCategoryListAsync();
            ViewData["CategoryId"] = new SelectList(allCategories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product Product)
        {
            await Service.Create(Product);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await Service.GetProductByIdAsync(id);
            return View(product);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var allCategories = await categoryService.GetCategoryListAsync();
            ViewData["CategoryId"] = new SelectList(allCategories, "Id", "Name");
            var product = await Service.GetProductByIdAsync(id);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            await Service.Edit(product);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var product = await Service.GetProductByIdAsync(id);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Product product)
        {
            await Service.Delete(product);
            return RedirectToAction("Index");
        }
    }
}
