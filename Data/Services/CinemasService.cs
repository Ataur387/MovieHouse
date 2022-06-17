using Microsoft.EntityFrameworkCore;
using MovieHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieHouse.Data.Services
{
    public class CinemasService : ICinemasService
    {
        private readonly AppDbContext _context;
        public CinemasService(AppDbContext context)
        {
            _context = context;
        }
        public void AddCinema(CinemaModel Cinema)
        {
            _context.Cinemas.Add(Cinema);
            _context.SaveChanges();
        }

        public async Task DeleteCinemaAsync(int Id)
        {
            var result = await _context.Cinemas.FirstOrDefaultAsync(a => a.Id == Id);
            _context.Cinemas.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<CinemaModel> GetCinemaByIdAsync(int Id)
        {
            var CinemaDetails = await _context.Cinemas.FirstOrDefaultAsync(c => c.Id == Id);
            return CinemaDetails;

        }

        public async Task<IEnumerable<CinemaModel>> GetCinemas()
        {
            var AllCinemas = await _context.Cinemas.ToListAsync();
            return AllCinemas;
        }

        public async Task<CinemaModel> UpdateCinemaAsync(int Id, CinemaModel Cinema)
        {
            _context.Update(Cinema);
            await _context.SaveChangesAsync();
            return Cinema;
        }
    }
}
