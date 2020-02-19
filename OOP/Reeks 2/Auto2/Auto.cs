using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto2
{
    class Auto
    {
        public string Merk { get; set; }
        public string Type { get; set; }
        public string Nummerplaat { get; set; }
        public int Kilometers { get; set; }
        Persoon Persoon { get; set; }

        public Auto(string merk, string type, string nummerplaat, int kilometers, Persoon persoon)
        {
            Merk = merk;
            Type = type;
            Nummerplaat = nummerplaat;
            Kilometers = kilometers;
            Persoon = persoon;
        }
        public Auto() : this("Onbekend", "Onbekend", "1-AAA-000", 0, new Persoon())
        { }

        public int UiteindelijkeAfstand(int aantalJaar)
        {
            int kilometers = 0;
            for (int i = 0; i < aantalJaar; i++)
            {
                kilometers += 20000;
            }
            return kilometers;
        }

        public int UiteindelijkeAfstand()
        {
            return this.UiteindelijkeAfstand(10);
        }

        public override string ToString()
        {
            string strauto = $"De auto met nummerplaat {Nummerplaat} heeft {Kilometers} km afgelegt.\nEigenaar: {Persoon}";
            return strauto.ToString();
        }
    }
}
