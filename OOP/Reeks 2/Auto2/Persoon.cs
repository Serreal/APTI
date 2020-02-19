using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto2
{
    public enum Geslacht
    {
        Man,
        Vrouw
    }
    class Persoon
    {
        public Geslacht Geslacht { get; set; }
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public DateTime Geboortedatum { get; set; }

        public Persoon(string voornaam, string naam, Geslacht geslacht, DateTime geboortedatum)
        {
            Voornaam = voornaam;
            Naam = naam;
            Geslacht = geslacht;
            Geboortedatum = geboortedatum;
        }

        public Persoon(string voornaam, string naam) : this(voornaam, naam, Geslacht.Vrouw, new DateTime(2000, 1, 1))
        { }

        public Persoon(): this("Bob", "Van Bob")
        { }

        public int BerekenLeeftijd(DateTime datum)
        {
            int leeftijd;
            if (datum.Day >= Geboortedatum.Day && datum.Month >= Geboortedatum.Month)
            {
                leeftijd = datum.Year - Geboortedatum.Year;
            }
            else
            {
                leeftijd = (datum.Year - Geboortedatum.Year) - 1;
            }
            return leeftijd;
        }
        public int BerekenLeeftijd()
        {
            return this.BerekenLeeftijd(DateTime.Today);
        }

        public override string ToString()
        {
            string persoon = $"{Voornaam} {Naam} is {BerekenLeeftijd()} jaar oud";
            return persoon.ToString();
        }
    }
}
