using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getal1
{
    class Program
    {
        static void Main(string[] args)
        {
            int teller = 1;
            int som = 0;

            do
            {
                Console.Write("Geef een getal in: ");

                try
                {
                    int getal = int.Parse(Console.ReadLine());
                    Console.WriteLine($"getal {teller}: {getal}");
                    som += getal;
                    teller++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Fout formaat");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Getal was te groot");
                }
                catch (Exception)
                {
                    Console.WriteLine("Fout");
                }
            } while (teller <= 3);

            Console.WriteLine($"De som van deze getallen: {som}");
        }
    }
}
