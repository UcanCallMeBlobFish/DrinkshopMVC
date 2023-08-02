using Drinkshop.Models;
using Drinkshop.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Drinkshop.Components
{
    public class ShoppingCartSummary:ViewComponent
    {

        private readonly ShoppingCart _shoppingcart;
        public ShoppingCartSummary(ShoppingCart shoppingcart)
        {
            _shoppingcart = shoppingcart;
        }

        public IViewComponentResult Invoke() 
        {
            var item = _shoppingcart.GetShoppingCartItems();
            _shoppingcart.ShoppingCartItems = item;

            var passdata = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingcart,
                ShoppingCartTotal = _shoppingcart.GetShoppingCartTotal()
            };
            return View(passdata);
        }

    }
}
