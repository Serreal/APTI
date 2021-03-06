﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eigenaar3
{
    class Auto
    {
        public string Merk { get; set; }
        public string Type { get; set; }
        public string Nummerplaat { get; set; }
        public int Kilometers { get; set; }
        public Auto(string merk, string type, string nummerplaat, int kilometers)
        {
            Merk = merk;
            Type = type;
            Nummerplaat = nummerplaat;
            Kilometers = kilometers;
        }
        public Auto() : this("Onbekend", "Onbekend", "1-AAA-000", 0)
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
            string strauto = $"\nDe auto met nummerplaat {Nummerplaat} heeft {Kilometers} km afgelegt.";
            return strauto;
        }
    }
}
