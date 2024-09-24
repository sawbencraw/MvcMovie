using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "(Unrated)",
                    Price = 3.99M
                },
                                new Movie
                {
                    Title = "The Green Mile",
                    ReleaseDate = DateTime.Parse("1999-12-6"),
                    Genre = "Crime",
                    Rating = "R",
                    Price = 60M
                },
                                new Movie
                {
                    Title = "Despicable Me",
                    ReleaseDate = DateTime.Parse("2010-7-9"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 69M
                },
                                new Movie
                {
                    Title = "Pride and Prejudice",
                    ReleaseDate = DateTime.Parse("2005-11-11"),
                    Genre = "Romance",
                    Rating = "PG",
                    Price = 28M
                }
            );
            context.SaveChanges();
        }
    }
}