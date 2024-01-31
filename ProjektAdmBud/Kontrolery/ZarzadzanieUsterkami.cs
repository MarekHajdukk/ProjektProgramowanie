using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjektAdmBud
{
    public class ZarzadzanieUsterkami
    {
        private MenadzerBazyDanych menadzerBazyDanych;

        public ZarzadzanieUsterkami()
        {
            menadzerBazyDanych = new MenadzerBazyDanych("usterki.txt"); // plik w ktorym beda usterki
        }

        public void ZarzadzajUsterkami()
        {
            Console.WriteLine("Zgłosić usterkę? (tak/nie)");
            string odpowiedz = Console.ReadLine();

            if (odpowiedz.ToLower() == "tak")
            {
                Console.WriteLine("Wpisz opis usterki:");
                string opisUsterki = Console.ReadLine();
                Usterka usterka = new Usterka(opisUsterki);
                menadzerBazyDanych.ZapiszDoPliku(usterka.ToString());
                Console.WriteLine("Usterka została zgłoszona.");
            }
            else
            {
                Console.WriteLine("Anulowano zgłaszanie usterki.");
            }
        }
    }
}
