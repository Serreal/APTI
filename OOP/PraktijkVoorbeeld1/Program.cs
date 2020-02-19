using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktijkVoorbeeld1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon persoon = new Persoon("Sander", "Standaert", new DateTime(2000, 4, 11)); //DateTime = new DateTime(); gezien vorige periode bij periode.
            Persoon testPersoon = new Persoon();
            Console.WriteLine(testPersoon.Voornaam);
            Console.WriteLine(testPersoon.Wandel(3));
            Console.WriteLine(persoon);
        }
    }
}
