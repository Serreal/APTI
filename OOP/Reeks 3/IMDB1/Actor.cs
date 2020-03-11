using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB1
{
    class Actor
    {
        public string Name { get; set; }
        public string FirstName { get; set; }

        public Actor(string name, string firstName)
        {
            Name = name;
            FirstName = firstName;
        }

        public override string ToString()
        {
            string actor = $"\n\tName: {Name}\n\tFirst Name: {FirstName}";
            return actor.ToString();
        }
    }
}
