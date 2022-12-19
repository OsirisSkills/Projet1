using System;
using System.Collections.Generic;


namespace Projet1
{

    // Classe principale qui va gérer le jeu
    class MaitreDuJeu
{

        static void Main(string[] args)
        {
            Menu();
        }

        // Méthode permettant d'affronter un monstre aléatoire dans la liste pré-établie
        static void Jouer(Personnage monPerso)
        {
            Random random;
            List<Monstre> monstres;

            random = new Random();
            monstres = new List<Monstre>();


            monstres.Add(new Monstre("Ecureuil mutant", 10, 25, 30));
            monstres.Add(new Monstre("Goule", 80, 25, 30));
            monstres.Add(new Monstre("Super mutant", 80, 25, 30));
            monstres.Add(new Monstre("Coloss mutant", 150, 50, 50));
            monstres.Add(new Monstre("Chien mutant", 25, 25, 30));

            var rng = random.Next(monstres.Count  );
            var monstre = monstres[rng];

            bool victoire = true;
            bool suivant = false;

           
// !
            while (!monstre.EstMort())
            {
                // Heros qui attaque en premier
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(monstre.ToString());
                Console.ForegroundColor = ConsoleColor.Red;
                monPerso.Attaquer(monstre);
                Console.WriteLine();
                Console.ReadKey(true);

                if (monPerso.EstMort())
                {
                    victoire = false;
                    break;
                }

                // Tour du monstre si il n'est pas mort
                if (!monPerso.EstMort())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    monstre.Attaquer(monPerso);
                    Console.WriteLine();
                    Console.ReadKey(true);
                }
            }

            // Gain d'XP et combat suivant si victoire
            if (victoire)
            {
                monPerso.GagnerExperience(5);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine(monPerso.Caracteristiques());


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();

                while (!suivant)
                {
                    Console.WriteLine("Combat suivant ? O/N ");
                    string saisie = Console.ReadLine().ToUpper();
                    if (saisie == "O")
                    {
                        suivant = true;
                        Jouer(monPerso);
                    }
                    else if (saisie == "N")
                    {
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("C'est perdu !!");
                Console.ReadKey();
            }
        }

        // Methode qui permet de choisir un heros avec des capacités differentes

        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Titre du game");
            Console.WriteLine();
            Console.WriteLine("Choisis ta classe: ");
            Console.WriteLine("1: Guerrier");
            Console.WriteLine("2: Archer");
            Console.WriteLine("3: Nain");
            Console.WriteLine("4: Quitter");
            Console.WriteLine();

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Vous avez choisis Guerrier !");
                    Console.WriteLine();
                    Jouer(new Guerrier("Aragorn", 200, 50, 50));
                    break;
                case "2":
                    Console.WriteLine("Vous avez choisis Archer !");
                    Console.WriteLine();
                    Jouer(new Archer("Legolas", 150, 20, 25));
                    break;
                case "3":
                    Console.WriteLine("Vous avez choisis Nain !");
                    Console.WriteLine();
                    Jouer(new Nain("Gimli", 200, 15, 20));
                    break;
                case "4":
                    break;
            }
        }
    }
}
