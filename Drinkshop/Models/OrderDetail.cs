namespace Drinkshop.Models
{
    public class OrderDetail
    {

        public int OrderDetailId { get; set; }
        public int OrderId { get; set; } //fk
        public int DrinkId { get; set; }  //fk
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Drink Drink { get; set; }  //nav
        public virtual Order Order { get; set; } //nav

    }
}
