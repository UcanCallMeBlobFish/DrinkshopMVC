using Drinkshop.Data;
using Drinkshop.Interfaces;
using Drinkshop.Models;

namespace Drinkshop.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Categories => _context.Categories;
    }
}
