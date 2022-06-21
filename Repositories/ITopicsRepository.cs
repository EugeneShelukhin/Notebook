using Notebook.Models;

namespace Notebook.Repositories
{
    public interface ITopicsRepository
    {
        Task CreateAsync(Topic model);
        Task<IEnumerable<Topic>> GetAllAsync();
        Task<Topic?> GetByIdAsync(int id);
    }
}