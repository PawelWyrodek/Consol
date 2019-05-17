using System;
using System.Collections.Generic;
using System.Text;
using Zadanie;

namespace ConsoleApp1
{
    public class Rolnik : Postac
    {
        public Rolnik(string imie, string hp) : base(imie, hp)
        {

        }
        public string Uprawiaj()
        {
            return "Uprawiaj";
        }

        public string Zbieraj()
        {
            return "Zbieram";
        }
    }
}
