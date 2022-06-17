using MovieHouse.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieHouse.Models
{
    public class MovieModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public string ImageURL { get; set; }
        public Genre Genre{ get; set;}

        //Relationship
        public List<ActorMovieModel> Actors_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        public CinemaModel Cinema { get; set; }
        //Producer
        public int ProducerId { get; set; }
        public ProducerModel Producer { get; set; }
        //Director
        public int DirectorId { get; set; }
        public DirectorModel Director { get; set; }
    }
}
