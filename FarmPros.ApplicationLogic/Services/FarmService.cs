using FarmPros.ApplicationLogic.Entities.FarmEntities;
using FarmPros.ApplicationLogic.Services.Interfaces;
using FarmPros.Domain.EntityFrameworkCore;
using FarmPros.Domain.EntityFrameworkCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPros.ApplicationLogic.Services
{
    public class FarmService : IFarmService
    {
        private readonly IBaseRepository<Farm> _farmRepository;

        public FarmService(IBaseRepository<Farm> farmRepository)
        {
            _farmRepository = farmRepository;
        }

        public async Task<FarmEntity> AddFarmAsync(FarmEntity farmEntity)
        {
            var farm = new Farm
            {
                Id = farmEntity.Id,
                UserId = farmEntity.UserId,
                Name = farmEntity.Name,
                Description = farmEntity.Description,
                StreetAddress = farmEntity.StreetAddress,
                Suburb = farmEntity.Suburb,
                City = farmEntity.City,
                Province = farmEntity.Province,
                Country = farmEntity.Country,
                PostalCode = farmEntity.PostalCode
            };

            var result  = await _farmRepository.AddAsync(farm);
            await _farmRepository.SaveAsync();
            
            return new FarmEntity
            {
                Id = result.Id,
                UserId = result.UserId,
                Name = result.Name,
                Description = result.Description,
                StreetAddress = result.StreetAddress,
                Suburb = result.Suburb,
                City = result.City,
                Province = result.Province,
                Country = result.Country,
                PostalCode = result.PostalCode
            };
        }

        public async Task<FarmEntity> GetFarmByIdAsync(Guid id)
        {
            var farm = await _farmRepository.FindAsync(id);

            return new FarmEntity
            {
                Id = farm.Id,
                UserId = farm.UserId,
                Name = farm.Name,
                Description = farm.Description,
                StreetAddress = farm.StreetAddress,
                Suburb = farm.Suburb,
                City = farm.City,
                Province = farm.Province,
                Country = farm.Country,
                PostalCode = farm.PostalCode
            };
        }

        public IEnumerable<FarmEntity> GetUserFarms(string userId)
        {
            var userFarms = _farmRepository.Where(f => f.UserId == userId);

            return userFarms.Select(u => new FarmEntity
            {
                Id = u.Id,
                UserId = u.UserId,
                Name = u.Name,
                Description = u.Description,
                StreetAddress = u.StreetAddress,
                Suburb = u.Suburb,
                City = u.City,
                Province = u.Province,
                Country = u.Country,
                PostalCode = u.PostalCode
            });
        }
    }
}
