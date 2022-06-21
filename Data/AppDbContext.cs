using Microsoft.EntityFrameworkCore;
using Notebook.Models;

namespace Notebook.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}