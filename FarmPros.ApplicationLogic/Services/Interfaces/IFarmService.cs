using FarmPros.ApplicationLogic.Entities.FarmEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarmPros.ApplicationLogic.Services.Interfaces
{
    public interface IFarmService
    {
        Task<FarmEntity> AddFarmAsync(FarmEntity farmEntity);
        IEnumerable<FarmEntity> GetUserFarms(Guid userId);
    }
}
