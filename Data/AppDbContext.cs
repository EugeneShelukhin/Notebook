using Microsoft.EntityFrameworkCore;
using Models;

namespace Notebook.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<DotnetCLI> DotnetCLIs { get; set; }
    }
}