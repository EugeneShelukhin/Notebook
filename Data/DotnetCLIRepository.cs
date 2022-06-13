using Models;

namespace Notebook.Data
{
    public class DotnetCLIRepository : IDotnetCLIRepository
    {
        private readonly AppDbContext _context;

        public DotnetCLIRepository(AppDbContext context)
        {
            _context = context;
        }


        public void Create(DotnetCLI model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _context.DotnetCLIs.Add(model);
        }

        public IEnumerable<DotnetCLI> GetAll()
        {
            return _context.DotnetCLIs.ToArray();
        }

        public DotnetCLI? GetById(int id)
        {
            return _context.DotnetCLIs.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}