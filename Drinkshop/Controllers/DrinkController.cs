using Drinkshop.Interfaces;
using Drinkshop.Models;
using Drinkshop.Repository;
using Drinkshop.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Drinkshop.Controllers
{
    public class DrinkController : Controller
    {
        private readonly IDrinkRepository _drinkrepository;
        private readonly ICategoryRepository _categoryRepository;
        public DrinkController(IDrinkRepository drinkrepository, ICategoryRepository categoryrepository)
        {
            _categoryRepository = categoryrepository;
            _drinkrepository = drinkrepository;

        }
        [HttpGet("Drink/List/{category?}")]
        public ViewResult List(string category)
        {
            string inputstring = category?.ToLowerInvariant();
            var lista = Enumerable.Empty<Drink>();
            if (string.IsNullOrEmpty(inputstring))
            {
                lista = _drinkrepository.Drinks();
                category = "AllDrinks";
            }

            else if (inputstring == "alcoholic") lista = _drinkrepository.Drinks().Where(a => a.Category.CategoryName.ToLowerInvariant() == inputstring);
            else if (inputstring == "non-alcoholic") lista = _drinkrepository.Drinks().Where(a => a.Category.CategoryName.ToLowerInvariant() == inputstring);

            var passdata = new DrinkViewModel()
            {
                Drinks = lista,
                CurrentCategory = category
            };
            return View(passdata);
        }
    }
}