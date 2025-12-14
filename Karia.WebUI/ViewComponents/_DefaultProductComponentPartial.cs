using Karia.WebUI.Repositories.ProductRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Karia.WebUI.ViewComponents
{
    public class _DefaultProductComponentPartial(IProductRepository _repository) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _repository.GetLast6ProductsAsync();
            return View(response);
        }
    }
}
