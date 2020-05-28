using OdeToFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
                {
                    new Restaurant {Id = 1, Name= "Veto's", Cuisine = CuisineType.Italian},
                    new Restaurant {Id = 2, Name = "Lemongrass", Cuisine = CuisineType.Thai},
                    new Restaurant {Id = 3, Name = "Monde", Cuisine = CuisineType.French},
                };
        }

        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.Id = restaurants.Max(r => r.Id) + 1;
        }
        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }
        
        public void Update(Restaurant restaurant)
        {
            var existing = Get(restaurant.Id);
            if(existing != null)
            {
                existing.Name = restaurant.Name;
                existing.Cuisine = restaurant.Cuisine;
            }
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
