using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minors2
{
    class Persoon
    {
        const int MINLEEFTIJD = 18;
        private DateTime geboorteDatum;
        public DateTime GeboorteDatum 
        {
            get
            {
                return geboorteDatum;
            }
            set
            {
                if (value.AddYears(MINLEEFTIJD) > DateTime.Today)
                {
                    throw new Exception("Je mag geen minderjarig persoon aanmaken");
                }
                else
                {
                    geboorteDatum = value;
                }
            }
        }
        public string Voornaam { get; set; }

        public Persoon(string voornaam, DateTime geboortedatum)
        {
            GeboorteDatum = geboortedatum;
            Voornaam = voornaam;
        }

        public override string ToString()
        {
            string persoon = $"{Voornaam} is geboren op {GeboorteDatum.ToShortDateString()}";
            return persoon;
        }
    }
}
