using Karia.WebUI.Repositories.TestimonialRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Karia.WebUI.ViewComponents
{
    public class _DefaultTestimonialComponentPartial(ITestimonialRepository _repository) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _repository.GetAllAsync();
            return View(response);
        }
    }
}
