using Drinkshop.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Drinkshop.ViewModel;
namespace Drinkshop.Components
{
    public class CategoryDrop:ViewComponent
    {
        private readonly ICategoryRepository _category;
        public CategoryDrop(ICategoryRepository category)
        {
            _category = category;
        }

        public IViewComponentResult Invoke()
        {
            var temp = _category.Categories;
            var categories = new Categorylist()
            {
                Categories = temp.ToList(),
            };

            
            return View(categories);
        }

    }
}
