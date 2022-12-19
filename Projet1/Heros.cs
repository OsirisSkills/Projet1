using System;
using System.Collections.Generic;

using System.Text;


namespace Projet1
{
    public class Guerrier : Personnage
    {
        public Guerrier(string nom, int pv, int degatsMin, int degatsMax) : base(nom, pv, degatsMin, degatsMax)
        {

        }
    }

    public class Archer : Personnage
    {
        public Archer(string nom, int pv, int degatsMin, int degatsMax) : base(nom, pv, degatsMin, degatsMax)
        {

        }
    }

    public class Nain : Personnage
    {
        public Nain(string nom, int pv, int degatsMin, int degatsMax) : base(nom, pv, degatsMin, degatsMax)
        {

        }
    }
}
