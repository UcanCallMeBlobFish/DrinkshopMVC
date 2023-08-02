using Drinkshop.Models;

namespace Drinkshop.ViewModel
{
    public class DrinkViewModel
    {
        public IEnumerable<Drink> Drinks { get; set; }
        public string CurrentCategory { get; set; }
    }
}
