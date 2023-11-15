using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class CarController : Controller
    {

        private readonly ICarService _carService;

        public CarController(ICarService service)
        {
            _carService = service;
        }
        public IActionResult Index()
        {
            return View(_carService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Car car)
        {
            if(ModelState.IsValid)
            {
                _carService.Add(car);
                return RedirectToAction("Index");
            }else
                return View(car);
        }

        

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var car = _carService.FindById(id);

            if (car != null)
            {
                return View(car);
            }

           return NotFound();
            
        }

        [HttpPost]
        public IActionResult Edit(Car editedCar)
        {
            if (ModelState.IsValid)
            {
                _carService.Update(editedCar);
                return RedirectToAction("Index");
            }

            return View(editedCar);
            
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var car = _carService.FindById(id);

            if (car != null)
                return View(car);
            else
                return NotFound();
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            var car = _carService.FindById(id);

            if (car != null)
            {
                _carService.Delete(id);
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var car = _carService.FindById(id);

            if (car != null)
                return View(car);
            else
                return NotFound();
        }
    }
}
