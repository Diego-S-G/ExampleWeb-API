using ExampleWeb.Domain.Models;

namespace ExampleWeb.Domain.Services
{
    public interface IExampleService
    {
        Task<IEnumerable<Example>> GetListAsync();
        Task<Example> GetCompleteAsync(int id);
        Task<Example> CreateAsync(Example example);
        Task<Example> UpdateAsync(int id, Example example);
        bool Delete(int id);
    }
}
