using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektAdmBud
{
    public class MonitorowanieTemperatury
    {
        public void PokazDane()
        {
            // generowanie danych o tamp i wilgotnosci
            Random rnd = new Random();
            double temperatura = rnd.Next(-10, 35); // temp od -10 do 35
            double wilgotnosc = rnd.Next(20, 80); // wilgotnosc od 20 do 80 %

            Console.WriteLine($"Aktualna temperatura: {temperatura}°C, wilgotność: {wilgotnosc}%");
        }
    }
}
