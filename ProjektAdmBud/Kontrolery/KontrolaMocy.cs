using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektAdmBud
{
    public class KontrolaMocy
    {
        private bool pradWlaczony;

        public KontrolaMocy()
        {
            pradWlaczony = false; // domyslene ustawienie
        }

        public void ZarzadzajMoca()
        {
            Console.WriteLine($"Aktualny status mocy: {(pradWlaczony ? "Włączony" : "Wyłączony")}");
            Console.WriteLine("Włączyć prąd? (tak/nie)");
            string odpowiedz = Console.ReadLine();

            if (odpowiedz.ToLower() == "tak")
            {
                pradWlaczony = true;
                Console.WriteLine("Prąd został włączony.");
            }
            else
            {
                pradWlaczony = false;
                Console.WriteLine("Prąd został wyłączony.");
            }
        }
    }
}