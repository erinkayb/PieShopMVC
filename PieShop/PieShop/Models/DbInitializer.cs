using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Pies.Any())
            {
                context.AddRange(

                new Pie
                {
                    Name = "Apple Pie",
                    Price = 10.99,
                    ShortDescription = "Warm pie",
                    LongDescription = "Warm pie made with apples and cinnamon.",
                    ImageThumbnailUrl = "https://res.cloudinary.com/erinkayb/image/upload/v1557136935/Apple-pie.jpg",
                    ImageUrl = "https://res.cloudinary.com/erinkayb/image/upload/v1557136935/Apple-pie.jpg",
                    IsPieOfTheWeek = true
                },
                new Pie
                {
                    Name = "Strawberry Cheesecake",
                    Price = 12.99,
                    ShortDescription = "Cold pie",
                    LongDescription = "Cool pie made with the creamiest cheese and fresh strawberries.",
                    ImageThumbnailUrl =
                        "https://res.cloudinary.com/erinkayb/image/upload/v1557136936/classic-strawberry-cheesecake.jpg",
                    ImageUrl =
                        "https://res.cloudinary.com/erinkayb/image/upload/v1557136936/classic-strawberry-cheesecake.jpg",
                    IsPieOfTheWeek = false
                },
                new Pie
                {
                    Name = "Blueberry Pie",
                    Price = 9.99,
                    ShortDescription = "Warm pie",
                    LongDescription = "Warm pie made with fresh blueberries.",
                    ImageThumbnailUrl =
                        "https://res.cloudinary.com/erinkayb/image/upload/v1557136936/Blueberry-Pie.jpg",
                    ImageUrl = "https://res.cloudinary.com/erinkayb/image/upload/v1557136936/Blueberry-Pie.jpg",
                    IsPieOfTheWeek = false
                },
                new Pie
                {
                    Name = "Cream Pie",
                    Price = 8.99,
                    ShortDescription = "Cold pie",
                    LongDescription = "Cool, creamy pie made with fresh cream.",
                    ImageThumbnailUrl = "https://res.cloudinary.com/erinkayb/image/upload/v1557136936/cream-pie.jpg",
                    ImageUrl = "https://res.cloudinary.com/erinkayb/image/upload/v1557136936/cream-pie.jpg",
                    IsPieOfTheWeek = false
                },
                new Pie
                {
                    Name = "Banana Cream Pie",
                    Price = 9.99,
                    ShortDescription = "Cold pie",
                    LongDescription = "Cool, creamy banana pie made with fresh bananas and full fat cream.",
                    ImageThumbnailUrl = "https://res.cloudinary.com/erinkayb/image/upload/v1557142471/banana-cream-pie.jpg",
                    ImageUrl = "https://res.cloudinary.com/erinkayb/image/upload/v1557142471/banana-cream-pie.jpg",
                    IsPieOfTheWeek = false
                },
                new Pie
                {
                    Name = "Cherry Pie",
                    Price = 11.99,
                    ShortDescription = "Warm pie",
                    LongDescription = "Warm pie made with fresh cherries.",
                    ImageThumbnailUrl =
                        "https://res.cloudinary.com/erinkayb/image/upload/v1557142471/Cherry-pie.jpg",
                    ImageUrl = "https://res.cloudinary.com/erinkayb/image/upload/v1557142471/Cherry-pie.jpg",
                    IsPieOfTheWeek = false
                }
                    );
                context.SaveChanges();
            }
        }
    }
}
