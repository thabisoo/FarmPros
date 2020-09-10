using FarmPros.ApplicationLogic.Entities.FarmEntities;
using FarmPros.ApplicationLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarmPros.ApplicationLogic.Services
{
    public class FarmService : IFarmService
    {
        public Task<FarmEntity> AddFarmAsync(FarmEntity farmEntity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FarmEntity> GetUserFarms(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
