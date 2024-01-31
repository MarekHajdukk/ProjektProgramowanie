using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace ProjektAdmBud
{
    public class MenadzerBazyDanych
    {
        private string sciezkaPliku;

        public MenadzerBazyDanych(string nazwaPliku)
        {
            sciezkaPliku = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nazwaPliku);
        }

        public void ZapiszDoPliku(string tekst)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(sciezkaPliku, true))
                {
                    writer.WriteLine(tekst);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd podczas zapisu do pliku: " + ex.Message);
            }
        }

        public void UsunWszystkieDane()
        {
            try
            {
                // usuwanie pliku 
                File.WriteAllText(sciezkaPliku, string.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd podczas usuwania danych: " + ex.Message);
            }
        }

        public List<string> OdczytajZPliku()
        {
            try
            {
                List<string> linie = new List<string>();
                using (StreamReader reader = new StreamReader(sciezkaPliku))
                {
                    string linia;
                    while ((linia = reader.ReadLine()) != null)
                    {
                        linie.Add(linia);
                    }
                }
                return linie;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd podczas odczytu z pliku: " + ex.Message);
                return new List<string>();
            }
        }

        // CRUD update?
    }
}
