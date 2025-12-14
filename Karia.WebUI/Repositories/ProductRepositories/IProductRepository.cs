using Karia.WebUI.DTOs.ProductDtos;

namespace Karia.WebUI.Repositories.ProductRepositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<ResultProductDto>> GetAllProductsAsync();
        Task<IEnumerable<ResultProductDto>> GetLast6ProductsAsync();
        Task<UpdateProductDto> GetByIdAsync(int id);
        Task CreateAsync(CreateProductDto dto);
        Task UpdateAsync(UpdateProductDto dto);
        Task DeleteAsync(int id);
    }
}
