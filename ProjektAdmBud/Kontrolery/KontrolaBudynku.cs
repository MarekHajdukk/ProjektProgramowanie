using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjektAdmBud
{
    public class KontrolaBudynku
    {
        private bool budynekOtwarty;

        public KontrolaBudynku()
        {
            budynekOtwarty = false; // domyslne ustawienie
        }

        public void ZarzadzajBudynkiem()
        {
            Console.WriteLine($"Aktualny status budynku: {(budynekOtwarty ? "Otwarty" : "Zamknięty")}");
            Console.WriteLine("Otworzyć budynek? (tak/nie)");
            string odpowiedz = Console.ReadLine();

            if (odpowiedz.ToLower() == "tak")
            {
                budynekOtwarty = true;
                Console.WriteLine("Budynek został otwarty.");
            }
            else
            {
                budynekOtwarty = false;
                Console.WriteLine("Budynek został zamknięty.");
            }
        }
    }
}
