using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RettangoliVari
{
    public class Rettangolo
    {
        // ATTRIBUTI / CARATTESTICHE
        public int baseRettangolo;
        public int altezzaRettangolo;
            

        // STATI -
       
        

        // COSTRUTTORE
        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;

        }

        // METODI
        public int calcolaArea()
        {
            int risultatoArea = baseRettangolo * altezzaRettangolo;
            return risultatoArea; 
        }
        public int calcolaPerimetro()
        {
            int risultatoPerimetro = 2 * (baseRettangolo + altezzaRettangolo);
            return risultatoPerimetro;
        }

        public void stampaRettangolo()
        {
            Console.WriteLine("-- Rettangolo --");
            Console.WriteLine("base: " + baseRettangolo + "Cm");
            Console.WriteLine("altezza: " + altezzaRettangolo + "Cm");
            Console.WriteLine("Perimetro: " + calcolaPerimetro + "Cm");
            Console.WriteLine("Area: " + calcolaArea + "Cm");
        }
       
    }
}
