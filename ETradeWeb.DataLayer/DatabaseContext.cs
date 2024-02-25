using ETradeWeb.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeWeb.DataLayer
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Roles> Roless { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrdersLines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=HALIL;Initial Catalog=ETradeDB;Integrated Security=True;MultipleActiveResultsets=True;TrustServerCertificate=True;");

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().Property(m => m.Name).IsRequired().HasColumnType("varchar(100)");
            modelBuilder.Entity<Roles>().HasData(new Roles
            {
                Id = 1,
                Name = "Admin"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Name = "Admin",
                Surname = "admin",
                Phone = "525654635",
                AktifMi = true,
                
                Email = "admin@eticaret.com",
                Username = "admin",
                Password = "123456",
                // Roles = new Roles{Id=1},
                RolesId = 1,


            });

            base.OnModelCreating(modelBuilder);
        }


    }
}
