using System;
using System.Collections.Generic;
using System.Text;

namespace PetitJeu_1
{
    class MonstreFacile
    {
        private bool _IsAlive;

        public bool IsAlive { get { return _IsAlive; } set { _IsAlive = value; } }


        public int Attaque ()
        {
            De deMonstre = new De();
            return deMonstre.LanceLeDe();
        }
    }
}
