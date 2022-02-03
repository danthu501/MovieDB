using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDB.Model
{
    public class Rating
    {
        public int RatingId { get; set; }
        public Reviewer Reviewer { get; set; }
        public int RevScore { get; set; }
        public Movies Movie  { get; set; }


    }
}
