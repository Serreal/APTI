using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlucht1
{
    class Program
    {
        static readonly Random rnd = new Random();
        static void Main(string[] args)
        {
            Vlucht vlucht1 = new Vlucht(Vertrek.België, Bestemming.Duitsland, DateTime.Today, DateTime.Today.AddHours(rnd.Next(20)));
            Vlucht vlucht2 = new Vlucht();
            Console.WriteLine(vlucht1);
            Console.WriteLine(vlucht2);
            Console.WriteLine(vlucht1.Vluchtduur());
            Console.WriteLine(vlucht2.Vluchtduur());
        }
    }
}
