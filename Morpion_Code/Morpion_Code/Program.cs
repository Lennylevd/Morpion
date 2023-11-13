using System;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Threading;

namespace Morpion
{
    class Program
    {
        public static int[,] grille = new int[3, 3]; // matrice pour stocker les coups joués

        // Fonction permettant l'affichage du Morpion
        public static void AfficherMorpion(int j, int k)
        {
            for (j = 0; j < grille.GetLength(0); j++)
            {
            	Console.Write("\n|---|---|---|\n");
                Console.Write("|");
                for (k = 0; k < grille.GetLength(1); k++)
               {
                	if (grille[j,k] == 0)
						Console.Write(" O |");
                	
					if (grille[j,k] == 1)
						Console.Write(" X |");
					
					if (grille[j,k] == 10)
					{
                		Console.Write(" _ |");
					}


                }}}

        // Fonction permettant de changer
        // dans le tableau qu'elle est le 
        // joueur qui à jouer
        // Bien vérifier que le joueur ne sort
        // pas du tableau et que la position
        // n'est pas déjà jouée
        public static bool AJouer(int j, int k, int joueur)
        {
            // A compléter 
            return false;
        }

        // Fonction permettant de vérifier
        // si un joueur à gagner
        public static bool Gagner(int l, int c, int joueur)
        {
            // A compléter 
            bool gagner = false;
            if(grille[0,0]==0 && grille[0,1]==0 && grille[0,2]==0 || grille[0,0]==1 && grille[0,1]==1 && grille[0,2]==1)
                        	{
                        		return true;
                        	}
							if(grille[1,0]==0 && grille[1,1]==0 && grille[1,2]==0 || grille[1,0]==1 && grille[1,1]==1 && grille[1,2]==1)
                        	{
                        		return true;
                        	}
							if(grille[2,0]==0 && grille[2,1]==0 && grille[2,2]==0 || grille[2,0]==1 && grille[2,1]==1 && grille[2,2]==1)
                        	{
                        		return true;
                        	}
							if(grille[0,0]==0 && grille[1,0]==0 && grille[2,0]==0 || grille[0,0]==1 && grille[1,0]==1 && grille[2,0]==1)
                        	{
                        		return true;
                        	}
							if(grille[0,1]==0 && grille[1,1]==0 && grille[2,1]==0 || grille[0,1]==1 && grille[1,1]==1 && grille[2,1]==1)
                        	{
                        		return true;
                        	}
							if(grille[0,2]==0 && grille[1,2]==0 && grille[2,2]==0 || grille[0,2]==1 && grille[1,2]==1 && grille[2,2]==1)
                        	{
                        		return true;
                        	}
							if(grille[0,0]==0 && grille[1,1]==0 && grille[2,2]==0 || grille[0,0]==1 && grille[1,1]==1 && grille[2,2]==1)
                        	{
                        		return true;
                        	}
							if(grille[0,2]==0 && grille[1,1]==0 && grille[2,0]==0 || grille[0,2]==1 && grille[1,1]==1 && grille[2,0]==1)
                        	{
                        		return true;
                        	}
							
            return false;
        }

        // Programme principal
        static void Main(string[] args)
        {
            //--- Déclarations et initialisations --
            int LigneDébut = Console.CursorTop;     // par rapport au sommet de la fenêtre
            int ColonneDébut = Console.CursorLeft; // par rapport au sommet de la fenêtre
            int essais = 0;    // compteur d'essais
	        int joueur = 1 ;   // 1 pour la premier joueur, 2 pour le second
	        int l, c = 0;      // numéro de ligne et de colonne
            int j, k = 0;      // Parcourir le tableau en 2 dimensions
            bool gagner = false; // Permet de vérifier si un joueur à gagné 
            bool bonnePosition = false; // Permet de vérifier si la position souhaité est disponible

	        //--- initialisation de la grille ---
            // On met chaque valeur du tableau à 10
	        for (j=0; j < grille.GetLength(0); j++)
		        for (k=0; k < grille.GetLength(1); k++)
			        grille[j,k] = 10;
					while(!gagner && essais != 9)
					{
						if(Gagner(0,0,1))
						   {
						   	gagner = true;
						   	if (joueur==2)
						   	{
						   		Console.Clear();
						   		Console.WriteLine("Le joueur 1 a gagné");
						   		Thread.Sleep(5000);
								System.Environment.Exit(0);
						   	}
						   	else
						   	{
						   		Console.Clear();
						   		Console.WriteLine("Le joueur 2 a gagné");
						   		Thread.Sleep(5000);
								System.Environment.Exit(0);
						   	}
						   	
						   }
						AfficherMorpion(j, k);

						// A compléter 
						try
						{
							
							if (joueur == 1)
							{
								Console.WriteLine();
								Console.WriteLine("Joueur 1 à toi !");
							}
							if (joueur == 2)
							{
								Console.WriteLine();
								
								Console.WriteLine("Joueur 2 à toi !");
							}
							Console.WriteLine();
							Console.WriteLine("Ligne   =    ");
							Console.WriteLine("Colonne =    ");
							Console.WriteLine("nombre d'essais:");
							Console.WriteLine(essais);
							// Peut changer en fonction de comment vous avez fait votre tableau.
							Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 9); // Permet de manipuler le curseur dans la fenêtre 
							l = int.Parse(Console.ReadLine()) - 1; 
							// Peut changer en fonction de comment vous avez fait votre tableau.
							Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 10); // Permet de manipuler le curseur dans la fenêtre 
							c = int.Parse(Console.ReadLine()) - 1;
							Console.WriteLine();
							Console.WriteLine();
							for (j=0; j < grille.GetLength(0); j++)
		        			for (k=0; k < grille.GetLength(1); k++)
							{
								
									if ((j==l)&&(k==c))
							{
								if (joueur==1)
								{
									if (grille[j,k] != 0 && grille[j,k] != 1)
									grille[j,k] = 0;
								}
								if (joueur==2)
								{
									if (grille[j,k] != 0 && grille[j,k] != 1)
									grille[j,k] =1;
								}
								
								
                        	
							}}
							joueur++;
							essais++;
                        	if(joueur==3)
                        		joueur=joueur-2;								
							// A compléter 

						}
						catch (Exception e)
						{
							Console.WriteLine(e.ToString());
						}
						Console.Clear();

						// Changement de joueur
						// A compléter 

					}; // Fin TQ

            // Fin de la partie
            // A compléter 

            Console.ReadKey();
    }
  }
}
