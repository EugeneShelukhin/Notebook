using Microsoft.EntityFrameworkCore;
using Notebook.Data;
using Notebook.Models;

namespace Notebook.Repositories
{
    public class TopicsRepository : ITopicsRepository
    {
        private readonly AppDbContext _context;

        public TopicsRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task CreateAsync(Topic model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            await _context.Topics.AddAsync(model);//?
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Topic>> GetAllAsync()
        {
            return await _context.Topics.ToArrayAsync();
        }

        public async Task<Topic?> GetByIdAsync(int id)
        {
            return await _context.Topics.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}