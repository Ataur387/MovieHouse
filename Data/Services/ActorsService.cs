using Microsoft.EntityFrameworkCore;
using MovieHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieHouse.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddActorAsync(ActorModel Actor)
        {
            await _context.Actors.AddAsync(Actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteActorAsync(int Id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(a => a.Id == Id);
            _context.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<ActorModel> GetActorByIdAsync(int Id)
        {
            var ActorDetails = await _context.Actors.FirstOrDefaultAsync(n => n.Id == Id);
            return ActorDetails;
        }

        public async Task<IEnumerable<ActorModel>> GetActorsAsync()
        {
            var AllActors = await _context.Actors.ToListAsync();
            return AllActors;
        }

        public async Task<ActorModel> UpdateActorAsync(int Id, ActorModel Actor)
        {
            _context.Update(Actor);
            await _context.SaveChangesAsync();
            return Actor;
        }
    }
}
