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
            var allcategories = await categoryService.GetCategoryListAsync();
            ViewData["CategoryId"] = new SelectList(allcategories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product Product)
        {

            await Service.Create(Product);
            return View(Product);
        }
    }
}
