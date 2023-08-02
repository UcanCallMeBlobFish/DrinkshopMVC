using Drinkshop.Models;

namespace Drinkshop.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
