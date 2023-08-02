using Drinkshop.Interfaces;
using Drinkshop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Drinkshop.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _order;
        private readonly ShoppingCart _shoppingCart;
        public OrderController(IOrderRepository order, ShoppingCart shoppingCart)
        {
            _order = order;   
            _shoppingCart = shoppingCart;
        }
        public IActionResult Checkout()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            if (items.Count == 0) ModelState.AddModelError("", "Your card is empty");
            
                _order.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CompleteCheckout");
            
            return View(order);
                
            
        }
        public IActionResult CompleteCheckout   () 
        {
            return View();
        }
    }
}
