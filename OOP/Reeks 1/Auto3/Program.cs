using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto test = new Auto();
            Auto auto1 = new Auto("BMW", "Handmatig", "1-ABC-234",12345);
            Console.WriteLine(test);
            Console.WriteLine(auto1);
            Console.WriteLine(test.UiteindelijkeAfstand(5));
            Console.WriteLine(auto1.UiteindelijkeAfstand());
        }
    }
}
