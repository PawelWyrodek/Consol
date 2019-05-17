using System;

namespace Zadanie
{
    public class Postac
    {
        string imie;
        string hp;

        public Postac(string imie, string hp)
        {
            this.imie = imie;
            this.hp = hp;
        }

        public string PrzedstawSie()
        {
            return "Nazwyam się: " + imie;
        }
    }
}
