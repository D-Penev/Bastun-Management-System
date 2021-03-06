﻿namespace BMS.Controllers
{
    using BMS.GlobalData;
    using BMS.Models;
    using BMS.Services.Contracts;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Authorize]
    public class FuelAndWeightController : Controller
    {
        private readonly IFuelAndWeightService _fuelAndWeightService;

        public FuelAndWeightController(IFuelAndWeightService fuelAndWeightService)
        {
            _fuelAndWeightService = fuelAndWeightService;
        }


        [HttpGet]
        public IActionResult FuelForm()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterFuelForm(FuelFormInputModel fuelInputModel)
        {
            if (ModelState.IsValid)
            {
                if (await _fuelAndWeightService.AddFuelForm(fuelInputModel))
                {
                    return RedirectToAction("Index", "Home");
                }

                TempData["Error"] = FuelAndWeightErrorMessages.FuelFormInvalid;
                return View("FuelForm");
            }

            return View("FuelForm");
        }

        [HttpGet]
        public IActionResult RegisterWeightForm()
        {
            return View();
        }

        [HttpPost]
        public  async Task<IActionResult> RegisterWeightForm(WeightFormInputModel weightInputModel)
        {
            if (ModelState.IsValid)
            {
                if (await _fuelAndWeightService.AddWeightForm(weightInputModel))
                {
                    return RedirectToAction("Index", "Home");
                }

                TempData["Error"] = FuelAndWeightErrorMessages.WeightFormInvalid;
                return View();
            }

            return View();
        }
    }
}
