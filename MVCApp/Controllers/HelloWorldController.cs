using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static  List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        { 
            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
        /*public IActionResult Hello()
        {
            DogViewModel doggo = new DogViewModel()
            {
                Name = "Shibimaru",
                Age = 2
5
            };
            return View(doggo);
        }*/
        
        public IActionResult HotelBookingDetails()
        {
            HotelBookingModel hotel = new HotelBookingModel()
            {
            Id = 1,
            GuestName = "Firuz",
            DateStart = new DateTime(2023, 3, 17, 0, 0, 0),
            DateEnd = new DateTime(2023, 3, 24, 0, 0, 0)
            };
            return View(hotel);
        }
    }
}
