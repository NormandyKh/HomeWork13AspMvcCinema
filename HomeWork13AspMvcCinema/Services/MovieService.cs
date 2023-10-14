using HomeWork13AspMvcCinema.Data;
using HomeWork13AspMvcCinema.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieData.Models;

namespace HomeWork13AspMvcCinema.Services
{
    public class MovieService : IMovieService
    {
        private readonly AppDbContext _context;

        public MovieService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Movie movie)
        {
            _context.Add(movie);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Id == id);    

            if(movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
        }

        public Movie Edit(Movie movie)
        {
            var existingMovie = _context.Movies.FirstOrDefault(m => m.Id == movie.Id);

            if (existingMovie != null)
            {
                existingMovie.Title = movie.Title;
                existingMovie.Description = movie.Description;
                existingMovie.Genre = movie.Genre;
                existingMovie.Director = movie.Director;
                _context.SaveChanges();
            }

            return existingMovie;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _context.Movies.ToList();
        }

        public Movie GetMovieById(int id)
        {
            return _context.Movies.FirstOrDefault(m => m.Id == id);
        }
    }
}
