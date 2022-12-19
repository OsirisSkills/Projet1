using System;
using System.Collections.Generic;
using System.Text;


namespace Projet1

{
    // Classe du heros qui pourra progresser en XP et qui herite d'Entite
    public abstract class Personnage : Entite
    {
        private int niveau;
        private int experience;

        public Personnage(string nom, int pv, int degatsMin, int degatsMax) : base(nom, pv, degatsMin, degatsMax)
        {
            this.nom = nom;
            niveau = 1;
            experience = 0;
        }

        
        // Methode qui permet de gagner de l'XP et des points de compétences à chaque gain de niveau

        public void GagnerExperience(int experience)
        {
            this.experience += experience;
            while (this.experience >= ExperienceRequise())
            {
                niveau += 1;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" GG : vous avez atteint le niveau " + niveau + " !");

                pv += 20;
                degatsMin += 3;
                degatsMax += 6;
            }
        }


        // Methode qui permet de calculter quels sont les seuils d'XP requis pour passer un niveau
        public double ExperienceRequise()
        {
            return Math.Round(4 * (Math.Pow(niveau, 3) / 5));
        }

        // Methode qui permet d'afficher les caractéritisques du héros
        public string Caracteristiques()
        {
            return this.nom + "\n" + "Niveau: " + niveau + "\n" + "Points d'expérience: (" + experience + "/" + ExperienceRequise() + "\n" + "Dégats: [" + degatsMin + ";" + degatsMax + "]" + "\n" + "Point de vie: " + pv;
        }
    }
}
