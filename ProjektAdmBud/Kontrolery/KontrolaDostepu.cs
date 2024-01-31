using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ProjektAdmBud
{
    public class KontrolaDostepu
    {
        private Walidacja walidacja;
        private MonitorowanieBezpieczenstwa monitorowanieBezpieczenstwa;

        public KontrolaDostepu()
        {
            walidacja = new Walidacja();
            monitorowanieBezpieczenstwa = new MonitorowanieBezpieczenstwa();
        }

        public bool Logowanie()
        {
            Console.WriteLine("Wpisz hasło administratora:");
            string haslo = Console.ReadLine();

            if (walidacja.SprawdzHaslo(haslo))
            {
                Console.WriteLine("Logowanie pomyślne.");
                monitorowanieBezpieczenstwa.ZapiszLogLogowania("Udane logowanie: " + DateTime.Now);
                return true;
            }
            else
            {
                Console.WriteLine("Nieprawidłowe hasło.");
                monitorowanieBezpieczenstwa.ZapiszLogLogowania("Nieudane logowanie: " + DateTime.Now);
                return false;
            }
        }
    }
}
