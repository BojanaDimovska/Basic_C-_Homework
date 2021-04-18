using Domain.Enums;
using System;

namespace Domain.Classes
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie (string title, Genre genre, int rating)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = 5 * rating;

            if(rating < 1 || rating > 5)
            {
                throw new Exception("The rating has to be between 1 and 5");
            }

            if (string.IsNullOrEmpty(title))
            {
                throw new Exception("You didn't enter a movie title. Try again.");
            }
        }
    }
}
