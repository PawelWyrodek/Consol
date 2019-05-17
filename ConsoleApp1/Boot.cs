using System;
using System.Collections.Generic;
using System.Text;
using Zadanie;

namespace ConsoleApp1
{
    class Boot
    {
        static public void Main(String[] args)
        {
            List<Postac> postacie = new List<Postac>();
            postacie.Add(new Wojownik("Gerald", "150"));
            postacie.Add(new Mag("Merlin", "100"));
            postacie.Add(new Rolnik("Blazej", "50"));

            foreach (Postac postac in postacie)
            {
                Console.WriteLine(postac.PrzedstawSie());
            }

            Console.ReadKey();
        }
    }
}
