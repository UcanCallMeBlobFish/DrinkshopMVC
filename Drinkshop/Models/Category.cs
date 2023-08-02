namespace Drinkshop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        //Navigation Property


                    
                    
                    
         public List<Drink> Drinks { get; set; }
    }
}
