using MovieDB.Model;
using System;
using System.Linq;

namespace MovieDB
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieDBContext context = new MovieDBContext();

            var result = context.Movies;

            foreach (var item in result)
            {
                Console.WriteLine(item.Title +"ÅR:"+ item.published);
            }

            var result2 = context.Movies.Where(a => a.published < "2000,01,01");
               
               



        }
    }
}
