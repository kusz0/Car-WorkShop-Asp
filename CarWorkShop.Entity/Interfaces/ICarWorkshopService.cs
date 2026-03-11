using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Entity.Interfaces
{
    public interface ICarWorkshopService
    {
        Task Create(Entity.Entities.CarWorkShop carWorkshop);
    }
}
