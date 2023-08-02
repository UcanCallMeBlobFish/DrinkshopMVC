using Drinkshop.Interfaces;
using Drinkshop.Models;

namespace Drinkshop.FakeData
{
    public class FakeCategoryRepository:ICategoryRepository
    {

        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                     {
                         new Category { CategoryName = "Alcoholic", Description = "All alcoholic drinks" },
                         new Category { CategoryName = "Non-alcoholic", Description = "All non-alcoholic drinks" }
                     };
            }
        }
    }
}
