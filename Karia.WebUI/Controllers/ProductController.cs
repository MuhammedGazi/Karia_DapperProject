using Karia.WebUI.DTOs.ProductDtos;
using Karia.WebUI.Repositories.CategoryRepositories;
using Karia.WebUI.Repositories.ProductRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Karia.WebUI.Controllers
{
    public class ProductController(IProductRepository repository, ICategoryRepository _categoryRepository) : Controller
    {
        public async Task GetCategoriesAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();
            List<SelectListItem> categoryList = (from x in categories
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.CategoryId.ToString()
                                                 }).ToList();

            ViewBag.Categories = categoryList;
        }
        public async Task<IActionResult> Index()
        {
            var result = await repository.GetAllProductsAsync();
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            await GetCategoriesAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDto dto)
        {
            await repository.CreateAsync(dto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            await GetCategoriesAsync();
            var result = await repository.GetByIdAsync(id);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateProductDto dto)
        {
            await repository.UpdateAsync(dto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await repository.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
