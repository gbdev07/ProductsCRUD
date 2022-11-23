using Microsoft.EntityFrameworkCore;

namespace ProductsCRUD.Models
{
    public class Context : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=CrudProducts;Integrated Security=True");
        }
    }
}
