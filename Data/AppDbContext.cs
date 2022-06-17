using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieHouse.Models;

namespace MovieHouse.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base (options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovieModel>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<ActorMovieModel>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<ActorMovieModel>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ActorModel> Actors { get; set; }
        public DbSet<ProducerModel> Producers { get; set; }
        public DbSet<MovieModel> Movies { get; set; }
        public DbSet<DirectorModel> Directors { get; set; }
        public DbSet<CinemaModel> Cinemas { get; set; }
        public DbSet<ActorMovieModel> ActorMovies { get; set; }

    }
}
