using ExampleWeb.Domain.Models;
using ExampleWeb.Domain.Repositories;
using ExampleWeb.Domain.Services;

namespace ExampleWeb.Infrastructure.Services
{
    public class ExampleService : IExampleService
    {
        private readonly IExampleRepository _repository;

        public ExampleService(IExampleRepository repository)
        {
            _repository = repository;
        }

        public Task<Example> CreateAsync(Example example)
        {
            return _repository.CreateAsync(example);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public Task<Example> GetCompleteAsync(int id)
        {
            return _repository.GetCompleteAsync(id);
        }

        public Task<IEnumerable<Example>> GetListAsync()
        {
            return _repository.GetListAsync();
        }

        public Task<Example> UpdateAsync(int id, Example example)
        {
            return _repository.UpdateAsync(id, example);
        }
    }
}
