using Drinkshop.Data;
using Drinkshop.Interfaces;
using Drinkshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Drinkshop.Repository
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly AppDbContext _context;
        public DrinkRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Drink> PrefferedDrinks => _context.Drinks.Where(a => a.IsPreferredDrink == true);

        public IEnumerable<Drink> Drinks()
        {
            return _context.Drinks.Include(a => a.Category);
        }

        public Drink GetDrinkById(int id)
        {
            return _context.Drinks.Where(a => a.DrinkId == id).FirstOrDefault();
        }
    }
}
