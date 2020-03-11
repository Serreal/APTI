using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Film testfilm = new Film("Bob", "Lob", "Sob", Genre.Action, DateTime.Today);
            Actor testactor = new Actor("Mob", "Qob");
            testfilm.AddRating(4);
            testfilm.AddRating(1);
            testfilm.AddRating(3);
            testfilm.AddRating(2);
            testfilm.AddActor(testactor);
            Console.WriteLine(testfilm);
        }
    }
}
