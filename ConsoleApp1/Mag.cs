using System;
using System.Collections.Generic;
using System.Text;
using Zadanie;

namespace ConsoleApp1
{
    class Mag : Postac
    {
        public Mag(string imie, string hp) : base(imie, hp)
        {
            
        }
        public string Walcz()
        {
            return "Walczę";
        }

        public string Pilnuj()
        {
            return "Pilnuję";
        }
        
    }
}
