using Microsoft.EntityFrameworkCore;
using MovieHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieHouse.Data.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly AppDbContext _context;
        public MoviesService(AppDbContext context)
        {
            _context = context;
        }
        public void AddMovie(MovieModel Movie)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(int Id)
        {
            throw new NotImplementedException();
        }

        public MovieModel GetMovieById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MovieModel>> GetMovies()
        {
            var AllMovies = await _context.Movies.Include(n => n.Cinema).ToListAsync();
            return AllMovies;
        }

        public MovieModel UpdateMovie(int Id, MovieModel Movie)
        {
            throw new NotImplementedException();
        }
    }
}
