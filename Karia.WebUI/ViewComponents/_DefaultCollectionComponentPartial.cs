using Karia.WebUI.Repositories.CollectionRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Karia.WebUI.ViewComponents
{
    public class _DefaultCollectionComponentPartial(ICollectionRepository _repository) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _repository.GetAllAsync();
            return View(response);
        }
    }
}
