using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmPros.ApplicationLogic.Entities.FarmEntities;
using FarmPros.ApplicationLogic.Services.Interfaces;
using FarmPros.ApplicationLogic.ViewModels.FarmViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Principal;

namespace FarmPros.Controllers
{
    public class FarmController : BaseController
    {
        private readonly IFarmService _farmService;
        private readonly UserManager<IdentityUser> _userManager;

        public FarmController(IFarmService farmService,
            UserManager<IdentityUser> userManager)
        {
            _farmService = farmService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var userFarms = _farmService.GetUserFarms((await _userManager.FindByEmailAsync(UserEmail)).Id);
            return View(userFarms.Select(f => new FarmViewModel
            {
                Id = f.Id,
                Name = f.Name,
                StreetAddress = f.StreetAddress,
                Surburb = f.Suburb,
                City = f.City,
                Province = f.Province,
                Country = f.Country,
                PostalCode = f.PostalCode
            }));
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
                UserId = (await _userManager.FindByEmailAsync(UserEmail)).Id,
                Name = model.Name,
                StreetAddress = model.StreetAddress,
                Suburb = model.Surburb,
                City = model.City,
                Province = model.Province,
                Country = model.Country,
                PostalCode = model.PostalCode
            });

            return RedirectToAction("Index");
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

            return View("Index");
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var farm = await _farmService.GetFarmByIdAsync(id);

            return View(new FarmViewModel 
            {
                Id = farm.Id,
                Name = farm.Name,
                StreetAddress = farm.StreetAddress,
                Surburb = farm.Suburb,
                City = farm.City,
                Province = farm.Province,
                Country = farm.Country,
                PostalCode = farm.PostalCode
            });
        }
    }
}
