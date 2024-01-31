using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjektAdmBud
{
    public class Usterka
    {
        public string Opis { get; set; }
        public DateTime DataZgloszenia { get; set; }

        public Usterka(string opis)
        {
            Opis = opis;
            DataZgloszenia = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{DataZgloszenia}: {Opis}";
        }
    }
}
