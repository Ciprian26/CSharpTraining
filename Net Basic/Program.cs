using Microsoft.EntityFrameworkCore;
using Net_Basic.DataAccessLayer;
using Net_Basic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp {
    static class Program {
        static void Main(string[] args)
        {
            using (var context = new MovieContext())
            {
                context.Database.EnsureCreated();

                var movie = new Movie
                {
                    Title = "Interstellar",
                    ReleaseYear = 2014,
                    Director = "Christopher Nolan",
                    Genres = new List<MovieGenre>
                    {
                        new MovieGenre { Genre = "Action" },
                        new MovieGenre { Genre = "Sci-Fi" }
                    }
                };

                var actor1 = new Actor { Name = "Matthew McConaughey", BirthYear = 1968 };
                var actor2 = new Actor { Name = "Matt Damon", BirthYear = 1970 };

                movie.Genres.ForEach(g => g.Movie = movie);
                movie.Actors = new List<MovieActor>
                {
                    new MovieActor { Actor = actor1 },
                    new MovieActor { Actor = actor2 }
                };

                context.Movies.Add(movie);
                context.Actors.AddRange(actor1, actor2);
                context.SaveChanges();

                var selectedMovie = context.Movies
                    .Include(m => m.Genres)
                    .FirstOrDefault(m => m.Title == "Interstellar");

                if (selectedMovie != null)
                {
                    Console.WriteLine("Selected Movie: " + selectedMovie.Title);
                    Console.WriteLine("Genres:");
                    foreach (var genre in selectedMovie.Genres)
                    {
                        Console.WriteLine(genre.Genre);
                    }
                }
                else
                {
                    Console.WriteLine("Movie not found.");
                }
            }
        }
    }
}