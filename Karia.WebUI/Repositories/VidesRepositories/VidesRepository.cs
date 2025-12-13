using Dapper;
using Karia.WebUI.Context;
using Karia.WebUI.DTOs.VideoDtos;
using System.Data;

namespace Karia.WebUI.Repositories.VidesRepositories
{
    public class VidesRepository(AppDbContext context) : IVidesRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task CreateAsync(CreateVideoDto dto)
        {
            string query = "insert into videos (Url,BackgroundImageUrl) values (@Url,@BackgroundImageUrl)";
            var parameters = new DynamicParameters(dto);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task DeleteAsync(int id)
        {
            string query = "Delete from videos where VideoId=@VideoId";
            var parameters = new DynamicParameters();
            parameters.Add("@VideoId", id);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task<IEnumerable<ResultVideoDto>> GetAllAsync()
        {
            string query = "Select * from videos";
            return await _db.QueryAsync<ResultVideoDto>(query);
        }

        public async Task<UpdateVideoDto> GetByIdAsync(int id)
        {
            string query = "select * from videos where VideoId=@VideoId";
            var parameters = new DynamicParameters();
            parameters.Add("@VideoId", id);
            return await _db.QueryFirstOrDefaultAsync<UpdateVideoDto>(query, parameters);
        }

        public async Task UpdateAsync(UpdateVideoDto dto)
        {
            string query = "update videos set Url=@Url,BackgroundImageUrl=@BackgroundImageUrl where VideoId=@VideoId";
            var parameters = new DynamicParameters(dto);
            await _db.ExecuteAsync(query, parameters);
        }
    }
}
