using Models;

namespace Notebook.Data
{
    public interface IDotnetCLIRepository
    {
        bool SaveChanges();
        IEnumerable<DotnetCLI> GetAll();
        DotnetCLI? GetById(int id);
        void Create(DotnetCLI model);
    }
}