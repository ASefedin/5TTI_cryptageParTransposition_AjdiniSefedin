using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuer = true;

        while (continuer)
        {
            // Convertir le mot-clé en un tableau de caractères
            Console.WriteLine("Entrez un mot-clé :");
            string motClef = Console.ReadLine();
            motClef = motClef.Replace(" ", "").Replace("-", "").Replace("_", "").Replace(",", "");
            char[] motClefs = motClef.ToCharArray();

            Console.WriteLine("Entrez une phrase :");
            string phrase = Console.ReadLine(); // Demande à l'utilisateur d'entrer une phrase

            phrase = phrase.Replace(" ", "").Replace("-", "").Replace("_", "").Replace(",", "");

            int longueurPhrase = phrase.Length;

            int tailleGrille = 1;
            while (tailleGrille * tailleGrille < longueurPhrase)
            {
                tailleGrille++;
            }
            Console.Clear();


            int[,] grille = new int[tailleGrille, tailleGrille]; // Crée une grille de la taille calculée

            // Convertir la phrase en un tableau de caractères  
            char[] caracteres = phrase.ToCharArray();

            // Placer chaque caractère du mot-clé dans la grille
            int indexClef = 0;
            for (int i = 0; i < tailleGrille; i++)
            {
                for (int j = 0; j < tailleGrille; j++)
                {
                    if (indexClef < motClefs.Length)
                    {
                        grille[i, j] = motClefs[indexClef];
                        indexClef++;
                    }
                }
            }

            // Placer chaque caractère dans la grille
            int index = 0;
            for (int i = 0; i < tailleGrille; i++)
            {
                for (int j = 0; j < tailleGrille; j++)
                {
                    if (index < caracteres.Length)
                    {
                        grille[i, j] = caracteres[index];
                        index++;
                    }
                }
            }

            // Afficher le mot-clé
            Console.WriteLine("Votre mot-clé :");
            Console.WriteLine("");
            Console.WriteLine(motClef);
            Console.WriteLine("");

            // Afficher le mot
            Console.WriteLine("Votre mot :");
            Console.WriteLine("");
            string motUser = phrase.ToString();
            Console.WriteLine(motUser);
            Console.WriteLine("");


            // Afficher les numéros attribués à chaque lettre du mot-clé
            Console.WriteLine("Numéros :");
            Console.WriteLine("");
            for (int i = 0; i < motUser.Length; i++)
            {
                Console.Write(i + 1 + " | ");
            }
            Console.WriteLine();

            // Afficher la grille avec des bordures
            Console.WriteLine("");
            Console.WriteLine("Grille :");
            Console.WriteLine("");
            Console.WriteLine("+" + new string('-', tailleGrille) + "+");
            for (int i = 0; i < tailleGrille; i++)
            {
                Console.Write("|");
                for (int j = 0; j < tailleGrille; j++)
                {
                    if (grille[i, j] != '\0')
                    {
                        Console.Write((char)grille[i, j]);
                    }
                    else
                    {
                        Console.Write("");
                    }
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("+" + new string('-', tailleGrille) + "+");

            Console.WriteLine("Voulez-vous encoder une autre phrase ? (o/n)");
            string reponse = Console.ReadLine();
            if (reponse.ToLower() != "o")
            {
                continuer = false;
            }
            Console.Clear();
        }
    }
}