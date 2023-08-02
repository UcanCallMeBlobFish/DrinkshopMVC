using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Drinkshop.Models; // Replace "Drinkshop.Models" with the correct namespace that contains the Drink, Category, ShoppingCartItem, Order, and OrderDetail classes.
using Microsoft.AspNetCore.Identity;

namespace Drinkshop.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Category> Categories { get; set; } 

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set;}

        public DbSet<Order> orders { get; set; }

        public DbSet<OrderDetail> ordersDetail { get; set; }    

    }
}
