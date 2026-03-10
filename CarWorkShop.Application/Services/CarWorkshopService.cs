using CarWorkShop.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Application.Services
{
    internal class CarWorkshopService
    {
        private readonly ICarWorkshorRepository _carWorkshorRepository;
        public CarWorkshopService(ICarWorkshorRepository carWorkshorRepository)
        {
            _carWorkshorRepository = carWorkshorRepository;
        }
        public async Task Create(Entity.Entities.CarWorkShop carWorkshop) 
        {
               
        }
    }
}
