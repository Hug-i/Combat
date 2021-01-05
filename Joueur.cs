using System;
using System.Collections.Generic;
using System.Text;

namespace PetitJeu_1
{
    class Joueur
    {
        private int _PointDeVie;
        private bool _IsAlive;
        public int PointDeVie { get { return _PointDeVie; } }
        public bool IsAlive { get { return _IsAlive; } }

        public Joueur()
        {
            _PointDeVie = 150;
        }
        public void Attaque (MonstreFacile monstre)
        {
            monstre.Attaque();
        }
        public void SubitDegats (int degats)
        {

        }

    }
}
