using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public class Clothes : GameObjet
    {
        public Clothes(string unNom, string uneDescription, int aBeauty, int aDrunkness, int aMood, int aCost, int aEnergycost)
           :base(unNom, uneDescription, aBeauty, aDrunkness, aMood, aCost, aEnergycost)
        {


        }
    }
}
