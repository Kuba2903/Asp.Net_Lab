using Lab3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab3.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CarController : Controller
    {

        private readonly ICarService _carService;

        public CarController(ICarService service)
        {
            _carService = service;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_carService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            Car model = new Car();
            model.Organizations = _carService
                .FindAllOrganizationsForVieModel()
                .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Tytul })
                .ToList();
            return View(model);
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
