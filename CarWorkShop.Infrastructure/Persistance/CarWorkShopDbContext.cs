using CarWorkShop.Entity.Entities;
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
        public CarWorkShopDbContext(DbContextOptions<CarWorkShopDbContext> dbcOptions) : base(dbcOptions)
        {
            
        }
        public DbSet<Entity.Entities.CarWorkShop> CarWorkShops { get; set; }
        public DbSet<CarWorkShopContactDetails> CarWorkShopContactDetails { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entity.Entities.CarWorkShop>().OwnsOne(c => c.ContactDetails);



        }
    
    }
}
