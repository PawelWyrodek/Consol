using System;

namespace Zadanie
{
    class Postac
    {
        public Postac(string Imie, string Hp);
        {
         string imie = Imie;
         string hp = Hp;
        }

        postacie.add(new Wojownik("Zbyszko", '100'))
        postacie.add(new Mag("Merlin", '60'))
        postacie.add(new Rolnik("Stefan", '80'))

        List<Postac> postacie = new List<Postac>();

        for(int i = 0; i< 3; i++)
        {
          Console.WriteLine(postacie[i].PrzedstawSie());
        }
    }


    public string PrzedstawSie(string imie)
    {
        return imie;
    }


}
