using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            var newModel = new Vehicle
            {
                id = "1H",
                vehicleType = "Car",
                make = "Hyundai",
                model = "Accent"

            };
            return View(newModel);
        }
    }
}