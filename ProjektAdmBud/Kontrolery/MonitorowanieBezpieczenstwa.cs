using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektAdmBud
{
    public class MonitorowanieBezpieczenstwa
    {
        private MenadzerBazyDanych menadzerBazyDanych;

        public MonitorowanieBezpieczenstwa()
        {
            menadzerBazyDanych = new MenadzerBazyDanych("logowania.txt"); // plik w ktorym beda logi
        }

        public void ZapiszLogLogowania(string info)
        {
            menadzerBazyDanych.ZapiszDoPliku(info);
        }
    }
}