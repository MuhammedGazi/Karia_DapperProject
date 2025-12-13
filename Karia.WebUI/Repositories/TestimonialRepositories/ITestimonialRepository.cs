using Karia.WebUI.DTOs.TestimonialDtos;

namespace Karia.WebUI.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<IEnumerable<ResultTestimonialDto>> GetAllAsync();
        Task<UpdateTestimonialDto> GetByIdAsync(int id);
        Task CreateAsync(CreateTestimonialDto dto);
        Task UpdateAsync(UpdateTestimonialDto dto);
        Task DeleteAsync(int id);

    }
}
