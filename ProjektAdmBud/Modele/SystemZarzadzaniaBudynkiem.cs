using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjektAdmBud
{
    class SystemZarzadzaniaBudynkiem
    {
        private KontrolaDostepu kontrolaDostepu;
        private KontrolaMocy kontrolaMocy;
        private KontrolaOswietlenia kontrolaOswietlenia;
        private MonitorowanieTemperatury monitorowanietemperatury;
        private ZarzadzanieUsterkami zarzadzanieUsterkami;
        private KontrolaBudynku kontrolaBudynku;
        private bool isUserLoggedIn = false;

        public SystemZarzadzaniaBudynkiem()
        {
            kontrolaDostepu = new KontrolaDostepu();
            kontrolaMocy = new KontrolaMocy();
            kontrolaOswietlenia = new KontrolaOswietlenia();
            monitorowanietemperatury = new MonitorowanieTemperatury();
            zarzadzanieUsterkami = new ZarzadzanieUsterkami();
            kontrolaBudynku = new KontrolaBudynku();
        }

        public void Start()
        {
            Console.WriteLine("System Zarządzania Budynkiem został uruchomiony.");
            WyswietlDostepneKomendy();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Wpisz komendę:");
                string komenda = Console.ReadLine();

                switch (komenda.ToLower())
                {
                    case "login":
                        isUserLoggedIn = kontrolaDostepu.Logowanie();
                        break;
                    case "prad":
                        if (isUserLoggedIn) kontrolaMocy.ZarzadzajMoca();
                        else Console.WriteLine("Opcja dostępna tylko dla zalogowanych użytkowników.");
                        break;
                    case "oswietlenie":
                        if (isUserLoggedIn) kontrolaOswietlenia.ZarzadzajOswietleniem();
                        else Console.WriteLine("Opcja dostępna tylko dla zalogowanych użytkowników.");
                        break;
                    case "temperatura":
                        monitorowanietemperatury.PokazDane();
                        break;
                    case "usterki":
                        if (isUserLoggedIn) zarzadzanieUsterkami.ZarzadzajUsterkami();
                        else Console.WriteLine("Opcja dostępna tylko dla zalogowanych użytkowników.");
                        break;
                    case "status":
                        WyswietlStatus();
                        break;
                    case "pokazlogi":
                        if (isUserLoggedIn) PokazLogi();
                        else Console.WriteLine("Opcja dostępna tylko dla zalogowanych użytkowników.");
                        break;
                    case "pokazusterki":
                        if (isUserLoggedIn) PokazUsterki();
                        else Console.WriteLine("Opcja dostępna tylko dla zalogowanych użytkowników.");
                        break;
                    case "drzwi":
                        if (isUserLoggedIn) kontrolaBudynku.ZarzadzajBudynkiem();
                        else Console.WriteLine("Opcja dostępna tylko dla zalogowanych użytkowników.");
                        break;
                    case "usunlogi":
                        if (isUserLoggedIn)
                        {
                            MenadzerBazyDanych menadzerLogow = new MenadzerBazyDanych("logowania.txt");
                            menadzerLogow.UsunWszystkieDane();
                            Console.WriteLine("Logi zostały usunięte.");
                        }
                        else
                        {
                            Console.WriteLine("Opcja dostępna tylko dla zalogowanych użytkowników.");
                        }
                        break;
                    case "usunusterki":
                        if (isUserLoggedIn)
                        {
                            MenadzerBazyDanych menadzerUsterek = new MenadzerBazyDanych("usterki.txt");
                            menadzerUsterek.UsunWszystkieDane();
                            Console.WriteLine("Usterki zostały usunięte.");
                        }
                        else
                        {
                            Console.WriteLine("Opcja dostępna tylko dla zalogowanych użytkowników.");
                        }
                        break;

                    case "exit":
                        Console.WriteLine("Zamykanie systemu...");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Nieznana komenda.");
                        break;
                }
            }
        }

        private void WyswietlDostepneKomendy()
        {
            Console.WriteLine("Dostępne komendy: login, prad, oswietlenie, temperatura, usterki, status, pokazlogi, pokazusterki, drzwi, exit");
        }

        private void WyswietlStatus()
        {
            Console.WriteLine("Wersja systemu bezpieczeństwa: 2.0");
            monitorowanietemperatury.PokazDane();
        }
        private void PokazLogi()
        {
            MenadzerBazyDanych menadzerLogow = new MenadzerBazyDanych("logowania.txt");
            var logi = menadzerLogow.OdczytajZPliku();
            foreach (var log in logi)
            {
                Console.WriteLine(log);
            }
        }

        private void PokazUsterki()
        {
            MenadzerBazyDanych menadzerUsterek = new MenadzerBazyDanych("usterki.txt");
            var usterki = menadzerUsterek.OdczytajZPliku();
            foreach (var usterka in usterki)
            {
                Console.WriteLine(usterka);
            }
        }
    }
}