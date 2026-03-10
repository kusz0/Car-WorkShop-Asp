using CarWorkShop.Entity.Interfaces;
using CarWorkShop.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Infrastructure.Repositories
{
    internal class CarWorkshopRepo : ICarWorkshorRepository
    {
        private readonly CarWorkShopDbContext _dbContext;
        public CarWorkshopRepo(CarWorkShopDbContext dbContex)
        {
           _dbContext = dbContex;
        }
        public async Task Create(Entity.Entities.CarWorkShop carWorkshop)
        {
            _dbContext.Add(carWorkshop);
            await _dbContext.SaveChangesAsync(); 
        }


    }
}
