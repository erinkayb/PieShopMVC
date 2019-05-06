using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;
        public MockPieRepository()
        {
            if(_pies == null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            _pies = new List<Pie>
            {
                new Pie()
                {
                    Id = 1, Name = "Apple Pie", Price = 10.99, ShortDescription = "Warm pie",
                    LongDescription = "Warm pie made with apples and cinnamon.", ImageThumbnailUrl = "https://res.cloudinary.com/erinkayb/image/upload/v1557136935/Apple-pie.jpg",
                    ImageUrl = "https://res.cloudinary.com/erinkayb/image/upload/v1557136935/Apple-pie.jpg", IsPieOfTheWeek = true
                },
                new Pie()
                {
                    Id = 1, Name = "Strawberry Cheesecake", Price = 12.99, ShortDescription = "Cold pie",
                    LongDescription = "Cool pie made with the creamiest cheese and fresh strawberries.", ImageThumbnailUrl = "https://res.cloudinary.com/erinkayb/image/upload/v1557136936/classic-strawberry-cheesecake.jpg",
                    ImageUrl = "https://res.cloudinary.com/erinkayb/image/upload/v1557136936/classic-strawberry-cheesecake.jpg", IsPieOfTheWeek = false
                },
                new Pie()
                {
                    Id = 1, Name = "Blueberry Pie", Price = 9.99, ShortDescription = "Warm pie",
                    LongDescription = "Warm pie made with fresh blueberries.", ImageThumbnailUrl = "https://res.cloudinary.com/erinkayb/image/upload/v1557136936/Blueberry-Pie.jpg",
                    ImageUrl = "https://res.cloudinary.com/erinkayb/image/upload/v1557136936/Blueberry-Pie.jpg", IsPieOfTheWeek = false
                },
                new Pie()
                {
                    Id = 1, Name = "Cream Pie", Price = 8.99, ShortDescription = "Cold pie",
                    LongDescription = "Cool, creamy pie made with fresh cream.", ImageThumbnailUrl = "https://res.cloudinary.com/erinkayb/image/upload/v1557136936/cream-pie.jpg",
                    ImageUrl = "https://res.cloudinary.com/erinkayb/image/upload/v1557136936/cream-pie.jpg", IsPieOfTheWeek = false
                },
            };
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId); 
        }
    }
}
