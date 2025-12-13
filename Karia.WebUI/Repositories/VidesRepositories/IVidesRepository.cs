using Karia.WebUI.DTOs.VideoDtos;

namespace Karia.WebUI.Repositories.VidesRepositories
{
    public interface IVidesRepository
    {
        Task<IEnumerable<ResultVideoDto>> GetAllAsync();
        Task<UpdateVideoDto> GetByIdAsync(int id);
        Task CreateAsync(CreateVideoDto dto);
        Task UpdateAsync(UpdateVideoDto dto);
        Task DeleteAsync(int id);
    }
}
