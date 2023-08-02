using Drinkshop.Interfaces;
using Drinkshop.Models;
using Drinkshop.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Drinkshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepository _drinks;
        public HomeController(IDrinkRepository drinks)
        {
            _drinks = drinks;
        }

        public IActionResult Index()
        {
            
            var temp = _drinks.PrefferedDrinks;

            var data = new PrefferedDrinkViewModel()
            {
                PrefferedDrink = temp
            };

            return View(data);
        }
    }
}