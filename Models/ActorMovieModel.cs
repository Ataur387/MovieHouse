using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieHouse.Models
{
    public class ActorMovieModel
    {
        public int MovieId { get; set; }
        public MovieModel Movie { get; set; }
        public int ActorId { get; set; }
        public ActorModel Actor { get; set; }

    }
}
