using MovieHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieHouse.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<ActorModel>> GetActorsAsync();
        Task<ActorModel> GetActorByIdAsync(int Id);
        Task AddActorAsync(ActorModel Actor);
        Task DeleteActorAsync(int Id);
        Task<ActorModel> UpdateActorAsync(int Id, ActorModel Actor);

    }
}
