using Drinkshop.Models;

namespace Drinkshop.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks();
        IEnumerable<Drink> PrefferedDrinks { get; }

        Drink GetDrinkById(int id);
    }
}
