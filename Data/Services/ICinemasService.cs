using MovieHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieHouse.Data.Services
{
    public interface ICinemasService
    {
        Task<IEnumerable<CinemaModel>> GetCinemas();
        Task<CinemaModel> GetCinemaByIdAsync(int Id);
        void AddCinema(CinemaModel Cinema);
        Task DeleteCinemaAsync(int Id);
        Task<CinemaModel> UpdateCinemaAsync(int Id, CinemaModel Cinema);
    }
}
