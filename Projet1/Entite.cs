using System;
using System.Collections.Generic;
using System.Text;



namespace Projet1
{
    // Classe de base qui donne les attributs pour tout le monde ( ennemies et heros )
    public abstract class Entite
    {
        protected string nom;
        protected bool estMort = false;
        protected int pv;
        protected int degatsMin;
        protected int degatsMax;
        protected Random random = new Random();


        public Entite(string nom,
                      int pv,
                      int degatsMin,
                      int degatsMax)
        {
            this.nom = nom;
            this.pv = pv;
            this.degatsMin = degatsMin;
            this.degatsMax = degatsMax;
        }


        // Methode qui permet aux entités de s'affronter et de décrire la séquence
        // Donne des PV au vainqueur après chaque victoire
        public void Attaquer(Entite uneEntite)
        {
            int degats = random.Next(degatsMin, degatsMax);
            uneEntite.PerdrePointsDeVie(degats);

            Console.WriteLine(this.nom + "(" + this.pv + ")" + " attaque: " + uneEntite.nom);
            Console.WriteLine(uneEntite.nom + " a perdu " + degats + " points de vie ");
            Console.WriteLine("Il reste " + uneEntite.pv + " point de vie à " + uneEntite.nom);
            if (uneEntite.estMort)
            {
                Console.WriteLine(uneEntite.nom + " est mort !");
                pv += 15;
            }
        }



        // Methode qui permet de perdre des PV et se solde par la mort 
        // Une condition permet d'eviter les PV négatifs 
        protected void PerdrePointsDeVie(int pointsDeVie)
        {
            this.pv -= pointsDeVie;
            if (this.pv <= 0)
            {
                this.pv = 0;
                estMort = true;
            }
        }


        // Definition du statut estMort
        public bool EstMort()
        {
            return this.estMort;
        }










    }
}
