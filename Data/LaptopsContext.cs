using ISellLaptops.Models;
using Microsoft.EntityFrameworkCore;


namespace ISellLaptops.Data
{
    public class LaptopsContext : DbContext
    {
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ThereBeLaptops;Integrated Security=True;");
        }

        public LaptopsContext()
        {

        }

        public LaptopsContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }
    }
}
