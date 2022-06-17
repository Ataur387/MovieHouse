using MovieHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieHouse.Data.Services
{
    public interface IProducersService
    {
        Task<IEnumerable<ProducerModel>> GetProducers();
        Task<ProducerModel> GetProducerByIdAsync(int Id);
        void AddProducer(ProducerModel Producer);
        Task DeleteProducerAsync(int Id);
        Task<ProducerModel> UpdateProducerAsync(int Id, ProducerModel Producer);
    }
}
