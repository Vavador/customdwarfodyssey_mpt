using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public class GameObjet
    {
        public string nom { get; set; }
        public string description { get; set; }
        public int beauty { get; set; }
        public int drunkness { get; set; }
        public int mood { get; set; }
        public int cost { get; set; }
        public int energyCost { get; set; }

        //constructeur

        public GameObjet()
        { }

        public GameObjet (string unNom, string uneDescription, int aBeauty, int aDrunkness, int aMood, int aCost, int aEnergycost)
        {
            this.nom = unNom;
            this.description = uneDescription;
            this.beauty = aBeauty;
            this.drunkness = aDrunkness;
            this.mood = aMood;
            this.cost = aCost;
            this.energyCost = aEnergycost;
        }
    }
}
