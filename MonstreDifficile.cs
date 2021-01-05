using System;
using System.Collections.Generic;
using System.Text;

namespace PetitJeu_1
{
    class MonstreDifficile : MonstreFacile
    {
        public new int Attaque()
        {
            De deMonstre= new De();
            return deMonstre.LanceLeDe();
        }
    }
}
