using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minors2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Persoon test = new Persoon("Jef", DateTime.Today.AddYears(-19));
                Console.WriteLine(test);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
