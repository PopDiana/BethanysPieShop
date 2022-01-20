using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
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
                new Pie{Id = 1, Name = "Apple Pie", Price = 12.95M,  ShortDescription = "Our famous apple pies!", LongDescription = "Our famous apple pies!", IsPieOfTheWeek = true, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Apple_pie.jpg/450px-Apple_pie.jpg", ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Apple_pie.jpg/450px-Apple_pie.jpg" },
                new Pie{Id = 2, Name = "Blueberry Cheese Cake", Price = 18.95M,  ShortDescription = "You'll love it!", LongDescription = "You'll love it!", IsPieOfTheWeek = false, ImageUrl = "https://www.lifeloveandsugar.com/wp-content/uploads/2018/08/Lemon-Blueberry-Cheesecake4-1.jpg", ImageThumbnailUrl = "https://www.lifeloveandsugar.com/wp-content/uploads/2018/08/Lemon-Blueberry-Cheesecake4-1.jpg"},
                new Pie{Id = 3, Name = "Cheese Cake", Price = 18.95M,  ShortDescription = "Plain cheese cake. Plain pleasure.", LongDescription = "Plain cheese cake. Plain pleasure", IsPieOfTheWeek = false, ImageUrl = "https://www.bbcgoodfood.com/sites/default/files/styles/recipe/public/user-collections/my-colelction-image/2015/12/recipe-image-legacy-id--22204_10.jpg?itok=8aYjQs4e", ImageThumbnailUrl = "https://www.bbcgoodfood.com/sites/default/files/styles/recipe/public/user-collections/my-colelction-image/2015/12/recipe-image-legacy-id--22204_10.jpg?itok=8aYjQs4e"},
                new Pie{Id = 4, Name = "Cherry Pie", Price = 15.95M,  ShortDescription = "A summer classic!", LongDescription = "A summer classic!", IsPieOfTheWeek = false, ImageUrl = "https://prettysimplesweet.com/wp-content/uploads/2016/07/CherryPie_04.webp", ImageThumbnailUrl = "https://prettysimplesweet.com/wp-content/uploads/2016/07/CherryPie_04.webp"}

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
