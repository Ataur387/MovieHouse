using MovieHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieHouse.Data.Services
{
    public interface IMoviesService
    {
        Task<IEnumerable<MovieModel>> GetMovies();
        MovieModel GetMovieById(int Id);
        void AddMovie(MovieModel Movie);
        void DeleteMovie(int Id);
        MovieModel UpdateMovie(int Id, MovieModel Movie);
    }
}
