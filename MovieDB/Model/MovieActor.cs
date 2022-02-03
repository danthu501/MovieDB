using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDB.Model
{
    public class MovieActor
    {
        public int MovieActorId { get; set; }
        public Movies Movie { get; set; }
        public Actor Actor { get; set; }
    }
}
