using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieDB.Model
{
    public class Movies
    {
        [Key]
        public int MovieId { get; set; }
        public string Title { get; set; }
        public List<MovieType> MovieTypes { get; set; }
        public DateTime published { get; set; }
        public string language { get; set; }
        public string RealaseCountry { get; set; }
        public List<Actor> Actors { get; set; }

    }
}
