namespace Drinkshop.Models
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public string Name { get; set; }

        public string ShortDescription { get; set; } //for main page

        public string LongDescription { get; set; } // for detail page

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } //for main page

        public string ImageThumbnailUrl { get; set; } //for detail page

        public bool IsPreferredDring { get; set; } // first page

        public bool InStock { get; set; }

        //navigation Properties drink:1<->Category:Many
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public bool IsPreferredDrink { get; internal set; }
    }
}
