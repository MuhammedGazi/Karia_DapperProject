using Karia.WebUI.DTOs.VideoDtos;
using Karia.WebUI.Repositories.VidesRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Karia.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VideoController(IVidesRepository _repository) : Controller
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
        public async Task<IActionResult> Create(CreateVideoDto dto)
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
        public async Task<IActionResult> Update(UpdateVideoDto dto)
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
