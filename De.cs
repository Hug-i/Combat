﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PetitJeu_1
{
    public class De
    {
        Random random = new Random();
        public int LanceLeDe()
        {
            return random.Next(1, 7);
        }
    }
}
