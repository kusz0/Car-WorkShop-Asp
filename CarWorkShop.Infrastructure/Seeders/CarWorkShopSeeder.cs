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


    }
}
