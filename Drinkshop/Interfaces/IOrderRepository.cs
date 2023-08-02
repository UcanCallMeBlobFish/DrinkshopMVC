using Drinkshop.Models;

namespace Drinkshop.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
