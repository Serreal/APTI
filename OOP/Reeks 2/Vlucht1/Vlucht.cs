using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlucht1
{
    public enum Bestemming
    {
        Frankrijk,
        Engeland,
        Duitsland
    }
    public enum Vertrek
    {
        België
    }
    public class Vlucht
    {
        private static int vluchtnummer = 0;
        public int Vluchtnummer { get; set; }
        public Vertrek Vertrek { get; set; }
        public Bestemming Bestemming { get; set; }
        public DateTime DatumVertrek { get; set; }
        public DateTime DatumAankomst { get; set; }

        public Vlucht(Vertrek vertrek, Bestemming bestemming, DateTime datumVertrek, DateTime datumAankomst)
        {
            Vluchtnummer = vluchtnummer++;
            Vertrek = vertrek;
            Bestemming = bestemming;
            DatumVertrek = datumVertrek;
            DatumAankomst = datumAankomst;
        }

        public Vlucht() : this(Vertrek.België, Bestemming.Engeland, DateTime.Today, DateTime.Today.AddDays(14))
        { }

        public string Vluchtduur()
        {
            TimeSpan vluchtduur = DatumAankomst - DatumVertrek;
            return ($"Vlucht {this.Vluchtnummer} duurt " + vluchtduur);
        }

        public override string ToString()
        {
            string vlucht = $"Vlucht {Vluchtnummer}: vliegt van {Vertrek} naar {Bestemming}";
            return vlucht.ToString();
        }
    }
}
