using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmPros.ApplicationLogic.ViewModels.ProductCategoryViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FarmPros.Controllers
{
    public class ProductCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCategoryViewModel model)
        {
            return View("Index");
        }
    }
}
