using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktijkVoorbeeld1
{
    //Visibility: class persoon = internal -> niet private maar enkel toegankelijk voor het project waar je momenteel in werkt.Kan ook een foutmelding veroorzaken dus altijd public maken(public class persoon).
    public class Persoon
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime Geboortedatum { get; set; }

        public Persoon(string voornaam, string achternaam, DateTime geboortedatum) //constructor met de meeste parameters altijd bovenaan zetten
        {
            Voornaam = voornaam.ToLower(); //moet altijd volledig in kleine letters (beslist in de les)
            Achternaam = achternaam;
            Geboortedatum = geboortedatum;
        }

        public Persoon() : this("John", "Doe", DateTime.Now.AddYears(-18)) //Overload constructor met default waarden (waarden die logisch zijn) -> overload = gebruik maakend van een vorige constructor, methode, etc
        {
            //Persoon is altijd exact 18 jaar oud
        }

        public int Wandel(int afstand, int hoogte) //methode met 2 parameters
        {
            return afstand - 1 + (hoogte / 2);
        }

        public int Wandel(int afstand) //Methode met 1 parameter die opbouwt vanop de vorige methode.
        {
            return this.Wandel(afstand, 0 /*hoogte*/);
        }
        //Nut van bovenstaand methodes is, als je de main methode (de methode met de meeste paramenters, 2) aanpast dan moet je aan de onderste niets veranderen. -> overloading, je past dit doe bij methodes/algoritmes die bij elkaar horen
    } 
    
}
