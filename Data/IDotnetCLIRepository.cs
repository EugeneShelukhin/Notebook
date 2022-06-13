using Models;

namespace Notebook.Data
{
    public interface IDotnetCLIRepository
    {
        bool SaveChanges();
        IEnumerable<DotnetCLI> GetAll();
        IEnumerable<DotnetCLI> GetById(int id);
        void Create(DotnetCLI model);
    }
}