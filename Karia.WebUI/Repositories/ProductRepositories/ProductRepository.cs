using Dapper;
using Karia.WebUI.Context;
using Karia.WebUI.DTOs.ProductDtos;
using System.Data;

namespace Karia.WebUI.Repositories.ProductRepositories
{
    public class ProductRepository(AppDbContext context) : IProductRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task CreateAsync(CreateProductDto dto)
        {
            string query = "insert into products (Name,ImageUrl,Description,Price,CategoryId) values (@Name,@ImageUrl,@Description,@Price,@CategoryId)";
            var parameters = new DynamicParameters(dto);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task DeleteAsync(int id)
        {
            string query = "delete from products where ProductId=@ProductId";
            var parameters = new DynamicParameters();
            parameters.Add("@ProductId", id);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task<IEnumerable<ResultProductDto>> GetAllProductsAsync()
        {
            string query = "select p.ProductId,p.Name,p.ImageUrl,p.Description,p.Price,p.CategoryId,c.Name AS CategoryName from products as p inner join categories as c ON p.CategoryId = c.CategoryId";
            return await _db.QueryAsync<ResultProductDto>(query);
        }

        public async Task<UpdateProductDto> GetByIdAsync(int id)
        {
            string query = "select * from products where ProductId=@ProductId";
            var parameters = new DynamicParameters();
            parameters.Add("@ProductId", id);
            return await _db.QueryFirstOrDefaultAsync<UpdateProductDto>(query, parameters);
        }

        public async Task UpdateAsync(UpdateProductDto dto)
        {
            string query = "update products set Name=@Name,ImageUrl=@ImageUrl,Description=@Description,Price=@Price,CategoryId=@CategoryId where ProductId=@ProductId";
            var parameters = new DynamicParameters(dto);
            await _db.ExecuteAsync(query, parameters);
        }
    }
}
