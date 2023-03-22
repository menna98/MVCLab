using Microsoft.AspNetCore.Mvc;

namespace MVCLab.Controllers
{
    public class CarController : Controller
    {
        public IActionResult GetAll()
        {
            var cars = Models.Car.GetCars(); //Model
            return View(cars);               //pass Model to view
        }
    }
}

