
using System;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=154.56.47.12;Database=u574456636_furniture_web;User=u574456636_tugba_web;Password=T96531533d*;");
        }

        public DbSet<Category> Categories { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        //public DbSet<Contact> Contacts { get; set; }
    }
}



/*
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {

        // DbContext için constructor ekleyin
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Bu metodu boş bırakın, çünkü bağlantı yapılandırmasını constructor içinde yapıyoruz.
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
*/