using Microsoft.AspNetCore.Mvc;

namespace MVCLab.Controllers
{
    public class CarController : Controller
    {
        public IActionResult GetAll()
        {
            var cars = Models.Car.GetCars();
            return View(cars);
        }
    }
}

