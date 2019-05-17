using System;
using System.Collections.Generic;
using System.Text;
using Zadanie;

namespace ConsoleApp1
{
    public class Wojownik : Postac
    {
        public Wojownik(string imie, string hp) : base(imie, hp)
        {

        }
        public string Walcz()
        {
            return "Walczę";
        }

        public string Patroluj()
        {
            return "Patroluję";
        }

        public string Pilnuj()
        {
            return "Pilnuje";
        }
    }
}
