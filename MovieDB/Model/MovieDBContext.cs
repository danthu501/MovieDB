using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDB.Model
{
    public class MovieDBContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director>  Directors { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<Movies>  Movies { get; set; }
        public DbSet<MovieType> MovieTypes { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Reviewer>  Reviewers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-6TSF82P; Initial Catalog = MovieDB; Integrated Security = True; ");
        }

    }
}
