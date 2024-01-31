using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektAdmBud
{
    public class KontrolaOswietlenia
    {
        private bool oswietlenieWlaczony;

        public KontrolaOswietlenia()
        {
            oswietlenieWlaczony = false; // domyslne ustawienie
        }

        public void ZarzadzajOswietleniem()
        {
            Console.WriteLine($"Aktualny status oświetlenia: {(oswietlenieWlaczony ? "Włączone" : "Wyłączone")}");
            Console.WriteLine("Włączyć oświetlenie? (tak/nie)");
            string odpowiedz = Console.ReadLine();

            if (odpowiedz.ToLower() == "tak")
            {
                oswietlenieWlaczony = true;
                Console.WriteLine("Oświetlenie zostało włączone.");
            }
            else
            {
                oswietlenieWlaczony = false;
                Console.WriteLine("Oświetlenie zostało wyłączone.");
            }
        }
    }
}