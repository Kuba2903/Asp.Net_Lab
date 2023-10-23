using Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public enum Operator
    {
        Add, Sub, Mul, Div, Unknown
    }
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result([FromForm]Calculator model)
        {
            if(!model.IsValid())
                return View("Error");

            return View(model);
        }

        public IActionResult Form()
        {
            return View();
        }
    }
}
