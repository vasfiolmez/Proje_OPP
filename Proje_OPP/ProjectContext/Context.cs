using Microsoft.EntityFrameworkCore;
using Proje_OPP.Entity;

namespace Proje_OPP.ProjectContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-O6URGDO7\\SQLEXPRESS;database=DbNewOopCore;integrated security=true;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
