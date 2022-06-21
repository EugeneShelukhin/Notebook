using Microsoft.EntityFrameworkCore;
using Notebook.Data;
using Notebook.Models;

namespace Notebook.Repositories
{
    public class ArticlesRepository : IArticlesRepository
    {
        private readonly AppDbContext _context;

        public ArticlesRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task CreateAsync(Article model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            await _context.Articles.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Article>> GetAllAsync()
        {
            return await _context.Articles.ToArrayAsync();
        }

        public async Task<Article?> GetByIdAsync(int id)
        {
            return await _context.Articles.FirstOrDefaultAsync(x => x.Id == id);
        }

    }
}