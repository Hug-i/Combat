using System;
using System.Collections.Generic;

namespace PetitJeu_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MonstreFacile> monstres = new List<MonstreFacile>();
            Joueur hero = new Joueur();

            
            De deMonstre = new De();
            while (hero.IsAlive == true)
            {
                if (deMonstre.LanceLeDe() > 3)
                {
                    monstres.Add (MonstreFacile monstre = new MonstreFacile());
                }
                else
                {
                    monstres.Add (MonstreFacile monstre = new MonstreFacile());
                }
                hero.Attaque(monstre);
                

                Console.ReadKey(true);
            }
        }
    }
}
