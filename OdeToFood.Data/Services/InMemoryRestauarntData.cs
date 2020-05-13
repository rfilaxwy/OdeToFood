using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestauarntData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestauarntData()
        {
            restaurants = new List<Restaurant>();
            {
                new Restaurant { Id = 1, Name = "Veto'sandwichs", Cuisine = CuisineType.Italian };
                new Restaurant { Id = 2, Name = "Monde", Cuisine = CuisineType.French };
                new Restaurant { Id = 3, Name = "Fuko", Cuisine = CuisineType.Japanese }
            }
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
