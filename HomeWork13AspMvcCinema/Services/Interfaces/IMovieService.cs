using MovieData.Models;
using Newtonsoft.Json.Bson;

namespace HomeWork13AspMvcCinema.Services.Interfaces
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetAllMovies();

        Movie GetMovieById(int id);

        void Add(Movie movie);

        Movie Edit(Movie movie);   

        void Delete(int id); 
    }
}
