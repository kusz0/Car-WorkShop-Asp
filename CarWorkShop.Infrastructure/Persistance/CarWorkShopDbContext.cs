using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Infrastructure.Persistance
{
    public class CarWorkShopDbContext : DbContext
    {
        public DbSet<Entity.Entities.CarWorkShop> CarWorkShops { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;DataBase=CarWorkShopDb;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entity.Entities.CarWorkShop>().OwnsOne(c => c.ContactDetails);
        }
    
    }
}
