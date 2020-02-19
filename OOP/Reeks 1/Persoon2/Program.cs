using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persoon2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon sander = new Persoon("Sander", "Standaert", Geslacht.Man, new DateTime(2000, 4, 11));
            Persoon testpersoon = new Persoon("Jan", "Van");
            Console.WriteLine(sander);
            Console.WriteLine(testpersoon);
            Console.WriteLine(sander.BerekenLeeftijd(new DateTime(2017, 5, 4)));
        }
    }
}
