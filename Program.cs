using System;
using System.Collections.Generic;

namespace PetitJeu_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Points = 0;
            Joueur hero = new Joueur();

            
            De deMonstre = new De();
            while (hero.IsAlive == true)
            {
                if (deMonstre.LanceLeDe() > 3)
                {
                    MonstreFacile monstre = new MonstreDifficile();
                }
                else
                {
                    MonstreFacile monstre = new MonstreFacile();
                }
                hero.Attaque(monstre);
                

                Console.ReadKey(true);
            }
        }
    }
}
