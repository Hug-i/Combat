using System;
using System.Collections.Generic;
using System.Text;

namespace PetitJeu_1
{
    class MonstreFacile
    {
        private bool _IsAlive;
        public bool IsAlive { get { return _IsAlive; } set { _IsAlive = value; } }

        public MonstreFacile()
        {

        }

        public void Attaque (Joueur joueur)
        {
            De deJoueur = new De();
            De deMonstre = new De();

            int scoreLancerJoueur = deJoueur.LanceLeDe();
            int scoreLancerMonstre = deMonstre.LanceLeDe();

            if (scoreLancerJoueur<scoreLancerMonstre)
            {
                int scoreSecondLancerJoueur = deJoueur.LanceLeDe();
                if (scoreSecondLancerJoueur>2)
                    joueur.SubitDegats(10);
            }
            joueur.Attaque(MonstreFacile);
        }
    }
}
