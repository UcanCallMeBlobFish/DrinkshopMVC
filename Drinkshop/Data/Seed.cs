using Drinkshop.Models;

namespace Drinkshop.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var services = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = services.ServiceProvider.GetService<AppDbContext>();
                if (!context.Drinks.Any())
                {
                    context.Drinks.AddRange(new Drink
                    {
                        Name = "Whiskey",
                        Price = 12.50M,
                        ShortDescription = "A classic alcoholic beverage",
                        LongDescription = "Whiskey is a distilled alcoholic beverage made from fermented grain mash. Various grains (which may be malted) are used for different varieties, including barley, corn, rye, and wheat. It is aged in wooden casks, generally made of charred white oak. The taste and aroma of whiskey can vary depending on factors such as the grain used, the distillation process, and the aging period.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://static.londonwinecompetition.com/cont/blog/imagePot/Wine-bottle-anatomy-2.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "https://static.londonwinecompetition.com/cont/blog/imagePot/Wine-bottle-anatomy-2.jpg"
                    },
new Drink
{
    Name = "Mocktail",
    Price = 6.95M,
    ShortDescription = "A refreshing non-alcoholic drink",
    LongDescription = "A mocktail is a non-alcoholic cocktail, typically consisting of a combination of fruit juices, syrups, and other flavored ingredients. Mocktails offer a refreshing and flavorful experience without the effects of alcohol. They are a popular choice for those who prefer not to consume alcoholic beverages.",
    Category = Categories["Non-alcoholic"],
    ImageUrl = "https://static.londonwinecompetition.com/cont/blog/imagePot/Wine-bottle-anatomy-2.jpg",
    InStock = true,
    IsPreferredDrink = false,
    ImageThumbnailUrl = "https://static.londonwinecompetition.com/cont/blog/imagePot/Wine-bottle-anatomy-2.jpg"
},
new Drink
{
    Name = "Tea",
    Price = 3.75M,
    ShortDescription = "A soothing and popular beverage",
    LongDescription = "Tea is an aromatic beverage commonly prepared by pouring hot or boiling water over cured or fresh tea leaves. It is one of the most widely consumed drinks in the world and comes in various flavors, including black, green, white, oolong, and herbal teas. Tea is often enjoyed for its comforting and soothing qualities.",
    Category = Categories["Non-alcoholic"],
    ImageUrl = "https://static.londonwinecompetition.com/cont/blog/imagePot/Wine-bottle-anatomy-2.jpg",
    InStock = true,
    IsPreferredDrink = true,
    ImageThumbnailUrl = "https://static.londonwinecompetition.com/cont/blog/imagePot/Wine-bottle-anatomy-2.jpg"
},
new Drink
{
    Name = "Vodka",
    Price = 10.25M,
    ShortDescription = "A popular distilled spirit",
    LongDescription = "Vodka is a clear distilled spirit with a high alcohol content. It is typically made from fermented grains such as wheat, rye, or corn. Vodka is known for its versatility in cocktails and is often used as a base for a wide range of mixed drinks. It is also popular for its smooth and neutral taste.",
    Category = Categories["Alcoholic"],
    ImageUrl = "https://static.londonwinecompetition.com/cont/blog/imagePot/Wine-bottle-anatomy-2.jpg",
    InStock = true,
    IsPreferredDrink = false,
    ImageThumbnailUrl = "https://static.londonwinecompetition.com/cont/blog/imagePot/Wine-bottle-anatomy-2.jpg"
},
new Drink
{
    Name = "Lemonade",
    Price = 4.50M,
    ShortDescription = "A classic and refreshing summer drink",
    LongDescription = "Lemonade is a sweet and tangy beverage made from lemon juice, water, and sugar. It is a popular drink, especially during the hot summer months, and is often served chilled with ice. Lemonade can be customized with various fruit flavors and herbs to create different refreshing variations.",
    Category = Categories["Non-alcoholic"],
    ImageUrl = "https://static.londonwinecompetition.com/cont/blog/imagePot/Wine-bottle-anatomy-2.jpg",
    InStock = true,
    IsPreferredDrink = true,
    ImageThumbnailUrl = "https://static.londonwinecompetition.com/cont/blog/imagePot/Wine-bottle-anatomy-2.jpg"
},
new Drink
{
    Name = "Rum",
    Price = 9.75M,
    ShortDescription = "A popular Caribbean spirit",
    LongDescription = "Rum is a distilled alcoholic beverage made from sugarcane byproducts, such as molasses, or directly from sugarcane juice. It is a staple spirit in many Caribbean countries and is used in a variety of cocktails. The taste of rum can range from sweet to spicy and is often associated with tropical flavors.",
    Category = Categories["Alcoholic"],
    ImageUrl = "https://static.londonwinecompetition.com/cont/blog/imagePot/Wine-bottle-anatomy-2.jpg",
    InStock = true,
    IsPreferredDrink = false,
    ImageThumbnailUrl = "https://static.londonwinecompetition.com/cont/blog/imagePot/Wine-bottle-anatomy-2.jpg"
},
new Drink
{
    Name = "Cappuccino",
    Price = 5.25M,
    ShortDescription = "An espresso-based Italian coffee",
    LongDescription = "Cappuccino is a popular Italian coffee drink made with a shot of espresso, steamed milk, and a layer of frothed milk. It is typically served in a small cup and is known for its rich and creamy texture. Cappuccino is enjoyed worldwide and is a favorite choice among coffee enthusiasts.",
    Category = Categories["Non-alcoholic"],
    ImageUrl = "https://static.londonwinecompetition.com/cont/blog/imagePot/Wine-bottle-anatomy-2.jpg",
    InStock = true,
    IsPreferredDrink = true,
    ImageThumbnailUrl = "https://static.londonwinecompetition.com/cont/blog/imagePot/Wine-bottle-anatomy-2.jpg"
},
new Drink
{
    Name = "Gin",
    Price = 11.50M,
    ShortDescription = "A beloved botanical spirit",
    LongDescription = "Gin is a distilled alcoholic beverage characterized by its predominant use of juniper berries and other botanicals to impart flavor. It is a key ingredient in classic cocktails such as the Martini and Negroni. The flavor profile of gin can vary widely based on the combination of botanicals used during distillation.",
    Category = Categories["Alcoholic"],
    ImageUrl = "https://static.londonwinecompetition.com/cont/blog/imagePot/Wine-bottle-anatomy-2.jpg",
    InStock = true,
    IsPreferredDrink = false,
    ImageThumbnailUrl = "https://static.londonwinecompetition.com/cont/blog/imagePot/Wine-bottle-anatomy-2.jpg"
});
                    context.SaveChanges();
                }
            }
        }

            private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Alcoholic", Description="All alcoholic drinks" },
                        new Category { CategoryName = "Non-alcoholic", Description="All non-alcoholic drinks" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
    }
