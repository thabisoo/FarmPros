using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmPros.ApplicationLogic.Entities.FarmEntities;
using FarmPros.ApplicationLogic.Services.Interfaces;
using FarmPros.ApplicationLogic.ViewModels.FarmViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FarmPros.Controllers
{
    public class FarmController : Controller
    {
        private readonly IFarmService _farmService;

        public FarmController(IFarmService farmService)
        {
            _farmService = farmService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }    

        [HttpPost]
        public async Task<IActionResult> Create(FarmViewModel model)
        {
            await _farmService.AddFarmAsync(new FarmEntity
            {
                Name = model.Name
            });
            
            return View("Index", GetUserFarms());
        }

        public IActionResult Edit(Guid id)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(FarmViewModel model)
        {
            await _farmService.AddFarmAsync(new FarmEntity
            {
                Name = model.Name
            });

            return View("Index", GetUserFarms());
        }

        private IEnumerable<FarmViewModel> GetUserFarms()
        {
            var farms = _farmService.GetUserFarms(Guid.NewGuid());

            var userFarmViewModels = farms.Select(f => new FarmViewModel
            {
                Id = f.Id,
                Name = f.Name
            });

            return userFarmViewModels;
        }
    }
}
