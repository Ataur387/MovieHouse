using Microsoft.EntityFrameworkCore;
using MovieHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieHouse.Data.Services
{
    public class ProducersService : IProducersService
    {
        private readonly AppDbContext _context;
        public ProducersService(AppDbContext context)
        {
            _context = context;
        }

        public void AddProducer(ProducerModel Producer)
        {
            _context.Producers.Add(Producer);
            _context.SaveChanges();
        }

        public async Task DeleteProducerAsync(int Id)
        {
            var result = await _context.Producers.FirstOrDefaultAsync(a => a.Id == Id);
            _context.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<ProducerModel> GetProducerByIdAsync(int Id)
        {
            var ProducerDetails =await _context.Producers.FirstOrDefaultAsync(n => n.Id == Id);
            return ProducerDetails;
        }

        public async Task<IEnumerable<ProducerModel>> GetProducers()
        {
            var AllProducers = await _context.Producers.ToListAsync();
            return AllProducers;
        }

        public async Task<ProducerModel> UpdateProducerAsync(int Id, ProducerModel Producer)
        {
            _context.Update(Producer);
            await _context.SaveChangesAsync();
            return Producer;
        }
    }
}
