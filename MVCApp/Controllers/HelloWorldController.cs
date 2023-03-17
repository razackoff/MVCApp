using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel() 
            { 
                Name="Sif",
                Age=2
            };
            return View(doggo);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Hello()
        {
            DogViewModel doggo = new DogViewModel()
            {
                Name = "Shibimaru",
                Age =
5
            };
            return View(doggo);
        }
    }
}
