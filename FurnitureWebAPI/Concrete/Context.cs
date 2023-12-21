
using FurnitureWebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FurnitureWebAPI.Concrete
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=154.56.47.12; Database=u574456636_furniture_web; User=u574456636_tugba_web; Password=T96531533d*;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}



