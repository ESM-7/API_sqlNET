using Microsoft.EntityFrameworkCore;
using Api_v1.Models;

namespace Api_v1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Mapeo de tabla y esquema
            modelBuilder.Entity<Department>().ToTable("Department", "HumanResources");

            // Clave primaria
            modelBuilder.Entity<Department>().HasKey(d => d.DepartmentID);
        }
    }
}
