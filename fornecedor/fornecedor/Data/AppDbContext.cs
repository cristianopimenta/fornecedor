using Microsoft.EntityFrameworkCore;

namespace AppFornecedor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
        {
        }
        public DbSet<Fornecedor> fornecedor { get; set; }
    }
}
