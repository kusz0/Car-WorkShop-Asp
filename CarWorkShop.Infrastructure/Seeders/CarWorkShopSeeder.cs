using CarWorkShop.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Infrastructure.Seeders
{
    internal class CarWorkShopSeeder
    {
        private readonly CarWorkShopDbContext _dbContext;
        public CarWorkShopSeeder(CarWorkShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if(await _dbContext.Database.CanConnectAsync())
            {
                if(!_dbContext.CarWorkShops.Any())
                {
                    var mazdaAso = new Entity.Entities.CarWorkShop() {
                        Id = 1,
                        Name = "Mazda",
                        Description="Authorized mazda serwis full pro",
                        ContactDetails = new()
                        {
                            PhoneNumber = "+48999222444",
                            City = "Warszawa",
                            Street = "Szeroka",
                            PostalCode = "22-555"
                        }
                    };
                    _dbContext.CarWorkShops.Add(mazdaAso);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
