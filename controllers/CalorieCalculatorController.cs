using Microsoft.AspNetCore.Mvc;
using CalorieCalculator.Models;

namespace CalorieCalculator.Controllers
{
    public class CalorieCalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalorieCalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateCalories();
                return View("Result", model);
            }
            return View(model);
        }

        public IActionResult Result(CalorieCalculatorModel model)
        {
            return View(model);
        }
    }
}
