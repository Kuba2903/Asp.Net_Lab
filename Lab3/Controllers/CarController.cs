using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class CarController : Controller
    {

        static Dictionary<int,Car> _cars = new Dictionary<int,Car>();
        
        public IActionResult Index()
        {
            return View(_cars);
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
                int id = _cars.Keys.Count != 0 ? _cars.Keys.Max() : 0;
                car.Id = id + 1;
                _cars.Add(car.Id, car);
                return RedirectToAction("Index");
            }else
                return View(car);
        }

        

        [HttpGet]
        public IActionResult Edit(int id)
        {

            if (_cars.ContainsKey(id))
            {
                return View(_cars[id]);
            }
            else
            {
                return NotFound();
            };
        }

        [HttpPost]
        public IActionResult Edit(Car editedCar)
        {
            if (ModelState.IsValid)
            {
                if (_cars.ContainsKey(editedCar.Id))
                {
                    _cars[editedCar.Id] = editedCar;
                    return RedirectToAction("Index");
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return View(editedCar);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if(_cars.ContainsKey(id))
                return View(_cars[id]);
            else
                return NotFound();
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            if (_cars.ContainsKey(id))
            {
                _cars.Remove(id);
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
            if (_cars.ContainsKey(id))
                return View(_cars[id]);
            else
                return NotFound();
        }
    }
}
