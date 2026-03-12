using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace hrm_esop_demo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Esop> Esops { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<EsopParticipation> EsopParticipations { get; set; }
        public DbSet<User> Users { get; set; }
    }
}