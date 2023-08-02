using Drinkshop.Data;
using Drinkshop.Interfaces;
using Drinkshop.Models;

namespace Drinkshop.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;
        private readonly ShoppingCart _shoppingCart;
        public OrderRepository(AppDbContext context, ShoppingCart shoppingCart)
        {
            _context = context;
            _shoppingCart = shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _context.orders.Add(order);
            _context.SaveChanges();

            foreach (var item in _shoppingCart.ShoppingCartItems)
            {
                var orderdet = new OrderDetail()
                {
                    Amount = item.Amount,
                    DrinkId = item.Drink.DrinkId,
                    OrderId = order.OrderId,
                    Price = item.Drink.Price
                };

                _context.ordersDetail.Add(orderdet);
            }
            _context.SaveChanges(); 
        }
    }
}
