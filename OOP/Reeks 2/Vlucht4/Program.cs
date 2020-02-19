using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlucht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vlucht testvlucht = new Vlucht();
            Console.WriteLine("1:\n" + testvlucht);
            Console.WriteLine();

            Persoon p1 = new Persoon();
            testvlucht.AddPassagier(p1);
            Console.WriteLine("2:\n" + testvlucht);
            Console.WriteLine();

            Persoon p2 = new Persoon("Henk", "De Wenk");
            testvlucht.AddPassagier(p2);
            Console.WriteLine("3:\n" + testvlucht);
            Console.WriteLine();

            testvlucht.RemovePassagier(p1);
            Console.WriteLine("4:\n" + testvlucht);
            Console.WriteLine();

            Console.WriteLine("5:" + testvlucht.ZoekPassagier(p2));
            Console.WriteLine();

            Console.WriteLine("6:" + testvlucht.ZoekPassagier(p1));
            Console.WriteLine();

            Console.WriteLine("7:" + testvlucht.ZoekPassagierOpNaam("Henk"));
            Console.WriteLine();
        }
    }
}
