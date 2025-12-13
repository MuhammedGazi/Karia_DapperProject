using Karia.WebUI.DTOs.TestimonialDtos;
using Karia.WebUI.Repositories.TestimonialRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Karia.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController(ITestimonialRepository _repository) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var response = await _repository.GetAllAsync();
            return View(response);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTestimonialDto dto)
        {
            await _repository.CreateAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var response = await _repository.GetByIdAsync(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateTestimonialDto dto)
        {
            await _repository.UpdateAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
