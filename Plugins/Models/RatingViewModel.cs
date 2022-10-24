using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace epi21_test.Plugins.Models
{
    public class RatingViewModel
    {
        public List<Rating> Ratings { get; set; }

        public List<Rating> CreateRatings()
        {
            var ratings = new List<Rating>();
            //will not delete since it is hardcoded 
            var rating1 = new Rating()
            {
                Movie = "Inception",
                Value = 8.9
            };

            var rating2 = new Rating()
            {
                Movie = "Die Hard",
                Value = 7.5
            };

            ratings.Add(rating1);
            ratings.Add(rating2);

            return ratings;
        }
    }

    public class Rating
    {
        public string Movie { get; set; }

        public double Value { get; set; }
    }
}
