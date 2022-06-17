using Microsoft.EntityFrameworkCore;
using MovieHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieHouse.Data.Services
{
    public class DirectorsService : IDirectorsService
    {
        private readonly AppDbContext _context;
        public DirectorsService(AppDbContext context)
        {
            _context = context;
        }
        public void AddDirector(DirectorModel director)
        {
            _context.Directors.Add(director);
            _context.SaveChanges();
        }

        public async Task DeleteDirectorAsync(int Id)
        {
            var result = await _context.Directors.FirstOrDefaultAsync(a => a.Id == Id);
            _context.Directors.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<DirectorModel> GetDirectorByIdAsync(int Id)
        {
            var DirectorDetails = await _context.Directors.FirstOrDefaultAsync(n => n.Id == Id);
            return DirectorDetails;
        }

        public async Task<IEnumerable<DirectorModel>> GetDirectors()
        {
            var AllDirectors = await _context.Directors.ToListAsync();
            return AllDirectors;
        }

        public async Task<DirectorModel> UpdateDirectorAsync(int Id, DirectorModel Director)
        {
            _context.Update(Director);
            await _context.SaveChangesAsync();
            return Director;
        }
    }
}
