using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eigenaar3
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon test = new Persoon();
            Console.WriteLine(test);
            Console.WriteLine();

            Auto a1 = new Auto();
            test.AddAuto(a1);
            Console.WriteLine(test);
            Console.WriteLine();

            Auto a2 = new Auto();
            test.AddAuto(a2);
            Console.WriteLine(test);
            Console.WriteLine();

            test.RemoveAuto(a1);
            Console.WriteLine(test);
        }
    }
}
