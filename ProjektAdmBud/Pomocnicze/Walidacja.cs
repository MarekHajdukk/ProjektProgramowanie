using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjektAdmBud
{
    public class Walidacja
    {
        public bool SprawdzHaslo(string wprowadzoneHaslo)
        {
            string prawidloweHaslo = "projekt"; // haslodo logowania
            return wprowadzoneHaslo == prawidloweHaslo;
        }
    }
}
