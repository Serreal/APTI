using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> afkortingen = new Dictionary<string, string>();

            afkortingen.Add("200", "OK");
            afkortingen.Add("404", "Not Found");
            afkortingen.Add("500", "Interne Serverfout");
            afkortingen.Add("401", "Unauthorized");

            Console.Write("Welke error code wil je opzoeken?: ");
            string strinput = Console.ReadLine();

            string value = "niet gevonden";

            if (afkortingen.ContainsKey(strinput))
            {
                afkortingen.TryGetValue(strinput, out value);
                Console.WriteLine($"Key {strinput} heeft value: {value}");
            }
            else
            {
                Console.WriteLine($"Key {strinput} {value}");
            }
        }
    }
}
