using System;
using System.Collections.Generic;
using System.Text;


namespace Projet1
{
    public class Monstre : Entite
    {
        // Classe du monstre générique qui hérite d'Entite avec seulement 1 constructeur
        public Monstre(string nom, int pv, int degatsMin, int degatsMax) : base(nom, pv, degatsMin, degatsMax)
        {

        }
        // Méthode qui permet de décrire le statut du monstre
        public override string ToString()
        {
            return "Nom : " + nom + " PV: " + pv + " Dégats Min: " + degatsMin + " Dégats Max: " + degatsMax;
        }

    }
}
