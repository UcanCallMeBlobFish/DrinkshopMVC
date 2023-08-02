using Drinkshop.Interfaces;
using Drinkshop.Models;
using Drinkshop.ViewModel;
using Microsoft.AspNetCore.Mvc;


namespace Drinkshop.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly IDrinkRepository _drink;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IDrinkRepository drink, ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
            _drink = drink; 
        }

        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            var sCVM = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(sCVM);
        }
        public IActionResult AddToShoppingCart(int drinkId)
        {
            var selectedDrink = _drink.Drinks().Where(p => p.DrinkId == drinkId).FirstOrDefault();
            if (selectedDrink != null)
            {
                _shoppingCart.AddToCart(selectedDrink, 1);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromShoppingCart(int drinkId)
        {
            var selectedDrink = _drink.Drinks().Where(p => p.DrinkId == drinkId).FirstOrDefault();
            if (selectedDrink != null)
            {
                _shoppingCart.RemoveFromCart(selectedDrink);
            }
            return RedirectToAction("Index");

        }
    }
}
