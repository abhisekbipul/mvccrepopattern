using Microsoft.EntityFrameworkCore;
using RepositoryPatternMvc.Models;

namespace RepositoryPatternMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Emp> emps { get; set; }
    }
}
