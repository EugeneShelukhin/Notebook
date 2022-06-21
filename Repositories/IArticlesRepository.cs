using Notebook.Models;

namespace Notebook.Repositories
{
    public interface IArticlesRepository
    {
        Task CreateAsync(Article model);
        Task<IEnumerable<Article>> GetAllAsync();
        Task<Article?> GetByIdAsync(int id);
    }
}