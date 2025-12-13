using Karia.WebUI.DTOs.CollectionDtos;

namespace Karia.WebUI.Repositories.CollectionRepositories
{
    public interface ICollectionRepository
    {
        Task<IEnumerable<ResultCollectionDto>> GetAllAsync();
        Task<UpdateCollectionDto> GetByIdAsync(int id);
        Task CreateAsync(CreateCollectionDto dto);
        Task UpdateAsync(UpdateCollectionDto dto);
        Task DeleteAsync(int id);
    }
}
