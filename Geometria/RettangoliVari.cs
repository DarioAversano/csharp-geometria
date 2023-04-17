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
    
        public int calcolaPerimetro()
        {
            int calcolaPerimetro = baseRettangolo * altezzaRettangolo;
            return calcolaPerimetro;
            Console.WriteLine(calcolaPerimetro);
        }

        //public string stampaRettangolo()
        //{


        //}
       
    }
}
