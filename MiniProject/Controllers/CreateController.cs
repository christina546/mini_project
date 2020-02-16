using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniProject.Models;

namespace MiniProject.Controllers
{
    public class CreateController : Controller
    {
        List<Car> myList = new List<Car>()
        {
            new Car
            {
                id = "2J",
                vehicleType = "car",
                make = "Toyota",
                model = "Corolla",
                engine = "1.8 litre",
                numDoors = 5,
                numWheels = 4,
                bodyType = "Hatchback"
            },
                
            new Car
            {
                id = "3K",
                vehicleType = "car",
                make = "Hyundai",
                model = "i30",
                engine = "1.6 litre",
                numDoors = 5,
                numWheels = 4,
                bodyType = "Hatchback"
            }

        };
        public IActionResult Index()
        {
            return View(myList);
        }

        public IActionResult Add() 
        {
            var carViewModel = new Car();
            return this.View(carViewModel);
        }

     
    }
}