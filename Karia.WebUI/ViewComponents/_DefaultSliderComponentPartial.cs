using Karia.WebUI.Repositories.ProductRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Karia.WebUI.ViewComponents
{
    public class _DefaultSliderComponentPartial(IProductRepository _repository) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _repository.GetAllProductsAsync();
            return View(response);
        }
    }
}
