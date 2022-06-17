using MovieHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieHouse.Data.Services
{
    public interface IDirectorsService
    {
        Task<IEnumerable<DirectorModel>> GetDirectors();
        Task<DirectorModel> GetDirectorByIdAsync(int Id);
        void AddDirector(DirectorModel Director);
        Task DeleteDirectorAsync(int Id);
        Task<DirectorModel> UpdateDirectorAsync(int Id, DirectorModel Director);
    }
}
