using System;
using System.Threading;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace Morpion
{
    class Program
    {
        public static int[,] grille = new int[3, 3]; // matrice pour stocker les coups joués
        // Fonction permettant l'affichage du Morpion
        public static void AfficherMorpion(int j, int k)
        {
            //compléter
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
               }
                }
                
           }       
        
		
        // Fonction permettant de changer dans le tableau qu'elle est le joueur qui à jouer
        // Bien vérifier que le joueur ne sor tpas du tableau et que la positionn'est pas déjà jouée
        public static bool AJouer(int j, int k, int joueur)
        {
            // A compléter
			
                
                	if (grille[j,k] == 0)
						Console.Write(" O |");
                	
					if (grille[j,k] == 1)
						Console.Write(" X |");
					
					if (grille[j,k] == 10)
					{
                		Console.Write(" _ |");
					}	
               
				 if (grille[j,k] != 0 && grille[j,k] != 1)
                {
				 	joueur=joueur-1;
                    Console.WriteLine("vous ne pouvez pas prendre cette case");
                    Console.WriteLine("\n");
                    Console.WriteLine("veuillez attendre 2s...");
                    Thread.Sleep(2000);
                }
			
            return false;
            
        }

        // Fonction permettant de vérifier si un joueur à gagner
        public static bool Gagner(int l, int c, int joueur)
        {

            
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
						// A compléter 
						AfficherMorpion(j,k);
						AJouer(j,k,joueur);
						try
						{
							
							
										
									
							if (essais > 9)
							{
								Console.WriteLine("Egalité");
								break;	
							}
							
							Console.WriteLine();
							if (joueur==1)
							{
								Console.Write("A toi de Jouer joueur 1");
							}
							else
							{
								Console.Write("A toi de Jouer joueur 2");
							}
							Console.WriteLine();
							Console.WriteLine();
							Console.Write("Ligne = "); 
							Console.WriteLine();
							Console.Write("Colonne = "); 

							
							essais = essais+1 ;
								
							// Peut changer en fonction de comment vous avez fait votre tableau.
							Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 9); // Permet de manipuler le curseur dans la fenêtre 
							l = int.Parse(Console.ReadLine()) -1; 
							// Peut changer en fonction de comment vous avez fait votre tableau.
							Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 10); // Permet de manipuler le curseur dans la fenêtre 
							c = int.Parse(Console.ReadLine()) -1;
							for (j=0; j < grille.GetLength(0); j++)
		        				for (k=0; k < grille.GetLength(1); k++)
							{
								if ((j==l)&&(k==c))
								{
									if (joueur==1)
									{
										grille[j,k] = 0;
									}
									if (joueur==2)
									{
										grille[j,k] = 1;
									}
								}
							}
							if ( l > 3 && l <1)
								Console.WriteLine("Cette ligne est impossible !");
								
							if (c > 3 && c < 1)
								Console.WriteLine("Cette colonne est impossible !");
							
							
							// A compléter 
								
						}
						catch (Exception e)
						{
							Console.WriteLine(e.ToString());
						}
						Console.Clear();

						// Changement de joueur
						// A compléter 
						if (!gagner)
						{
							if (joueur == 1)
								joueur = 2;
							else
								joueur = 1;
						}
						
					}; // Fin TQ

            // Fin de la partie
            // A compléter 
           
            if (gagner==true)
				Console.Write("Le joueur " , joueur , " gagne !") ;
				
            Console.ReadKey();
    }
  }
}
    

