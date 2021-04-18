using System;
using System.Collections.Generic;

namespace Domain.Classes
{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }

        public Cinema(string name, List<int> halls, List<Movie> movies)
        {
            Name = name;
            Halls = halls;
            ListOfMovies = movies;

            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("You have to enter Cinema name!");
            }
            if(halls == null || halls.Count == 0)
            {
                throw new Exception("There must be halls");
            }
            if(movies == null || movies.Count == 0)
            {
                throw new Exception("There must be movies");
            }
        }

        public void WatchMovie (Movie movie)
        {
            Console.WriteLine($"Watching {movie.Title}");
        }
    }
}
