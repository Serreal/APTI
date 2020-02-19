using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlucht4
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
        private List<Persoon> PassagiersLijst = new List<Persoon>();
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

        public Persoon ZoekPassagier(Persoon passagier)
        {
            if (PassagiersLijst.Contains(passagier))
            {
                return passagier;
            }
            return null;
        }
        public Persoon ZoekPassagierOpNaam(string passagier)
        {
            foreach (Persoon p in PassagiersLijst)
            {
                if (p.Voornaam == passagier)
                {
                    return p;
                }
            }
            return null;
        }
        public bool AddPassagier(Persoon passagier)
        {
            if (passagier != null)
            {
                PassagiersLijst.Add(passagier);
                return true;
            }
            return false;
        }

        public bool RemovePassagier(Persoon passagier)
        {
            if (passagier != null)
            {
                PassagiersLijst.Remove(passagier);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string vlucht = $"Vlucht {Vluchtnummer}: vliegt van {Vertrek} naar {Bestemming}";
            if (PassagiersLijst != null)
            {
                foreach (Persoon passagier in PassagiersLijst)
                {
                    vlucht += passagier.ToString();
                }
            }
            return vlucht.ToString();
        }
    }
}
