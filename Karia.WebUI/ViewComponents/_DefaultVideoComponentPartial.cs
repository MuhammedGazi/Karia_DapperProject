using Karia.WebUI.Repositories.VidesRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Karia.WebUI.ViewComponents
{
    public class _DefaultVideoComponentPartial(IVidesRepository _repository) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _repository.GetAllAsync();
            return View(response);
        }
    }
}
